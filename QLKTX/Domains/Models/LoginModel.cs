using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Models
{
    internal class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsRemember => !string.IsNullOrEmpty(this.Password);
    }
}
