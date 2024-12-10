using Newtonsoft.Json;
using QLKTX.Domains.Interface;
using QLKTX.Models;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class Login : Form
    {
        private const string CredentialsFilePath = "credentials.dat";
        private readonly IUserRepository _userRepository;

        public Login(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var loginInfo = this.LoadCredentials();
            this.userName_TextBox.Text = loginInfo.UserName;
            this.password_TextBox.Text = loginInfo.Password;
            this.isSaveLogin_checkBox.Checked = loginInfo.IsRemember;
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _userRepository.Queryable(x => x.UserName == userName_TextBox.Text).FirstOrDefaultAsync()?.Result;
                if (user is null)
                {
                    MessageBox.Show($"Tài khoản '{userName_TextBox.Text}' không tồn tại.", "Đăng nhập thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex) 
            { 

            }
            
        }

        private LoginModel LoadCredentials()
        {
            if (File.Exists(CredentialsFilePath))
            {
                try
                {
                    var encryptedData = File.ReadAllBytes(CredentialsFilePath);
                    var decryptedData = UnprotectData(encryptedData);
                    var data = Encoding.UTF8.GetString(decryptedData).Split('\n');
                    return new LoginModel() { UserName = data.FirstOrDefault(), Password = data.LastOrDefault() };
                }
                catch
                {
                }
            }

            return new LoginModel();
        }

        private void SaveCredentials(string username, string password)
        {
            var data = $"{username}\n{password ?? ""}";
            var encryptedData = ProtectData(Encoding.UTF8.GetBytes(data));
            File.WriteAllBytes(CredentialsFilePath, encryptedData);
        }

        private void ClearCredentials()
        {
            if (File.Exists(CredentialsFilePath))
            {
                File.Delete(CredentialsFilePath);
            }
        }

        private byte[] ProtectData(byte[] data)
        {
            return ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
        }

        private byte[] UnprotectData(byte[] data)
        {
            return ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
        }
    }
}
