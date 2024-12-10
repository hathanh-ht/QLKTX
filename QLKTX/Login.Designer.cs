namespace QLKTX
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isSaveLogin_checkBox = new System.Windows.Forms.CheckBox();
            this.userName_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(177, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỆ THÔNG QUẢN LÝ KÍ TÚC XÁ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // isSaveLogin_checkBox
            // 
            this.isSaveLogin_checkBox.AutoSize = true;
            this.isSaveLogin_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isSaveLogin_checkBox.Location = new System.Drawing.Point(128, 183);
            this.isSaveLogin_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isSaveLogin_checkBox.Name = "isSaveLogin_checkBox";
            this.isSaveLogin_checkBox.Size = new System.Drawing.Size(152, 21);
            this.isSaveLogin_checkBox.TabIndex = 3;
            this.isSaveLogin_checkBox.Text = "Ghi nhớ đăng nhập";
            this.isSaveLogin_checkBox.UseVisualStyleBackColor = true;
            // 
            // userName_TextBox
            // 
            this.userName_TextBox.Location = new System.Drawing.Point(263, 109);
            this.userName_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName_TextBox.Name = "userName_TextBox";
            this.userName_TextBox.Size = new System.Drawing.Size(224, 22);
            this.userName_TextBox.TabIndex = 4;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(263, 146);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(224, 22);
            this.password_TextBox.TabIndex = 5;
            this.password_TextBox.UseSystemPasswordChar = true;
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.login_Button.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button.Location = new System.Drawing.Point(281, 225);
            this.login_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(158, 35);
            this.login_Button.TabIndex = 6;
            this.login_Button.Text = "Đăng nhập";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.userName_TextBox);
            this.Controls.Add(this.isSaveLogin_checkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isSaveLogin_checkBox;
        private System.Windows.Forms.TextBox userName_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button login_Button;
    }
}

