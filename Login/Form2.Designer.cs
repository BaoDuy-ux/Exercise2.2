namespace Login
{
    partial class Form2
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
            this.bt_signup = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_confirmpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_signup
            // 
            this.bt_signup.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signup.Location = new System.Drawing.Point(125, 337);
            this.bt_signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(164, 43);
            this.bt_signup.TabIndex = 14;
            this.bt_signup.Text = "Đăng ký";
            this.bt_signup.UseVisualStyleBackColor = false;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(474, 337);
            this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(164, 43);
            this.bt_login.TabIndex = 13;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(318, 167);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(266, 41);
            this.tb_password.TabIndex = 12;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên đăng nhập";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(318, 94);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(266, 41);
            this.tb_username.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // tb_confirmpassword
            // 
            this.tb_confirmpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmpassword.Location = new System.Drawing.Point(318, 245);
            this.tb_confirmpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_confirmpassword.Name = "tb_confirmpassword";
            this.tb_confirmpassword.PasswordChar = '*';
            this.tb_confirmpassword.Size = new System.Drawing.Size(266, 41);
            this.tb_confirmpassword.TabIndex = 16;
            this.tb_confirmpassword.UseSystemPasswordChar = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_confirmpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_signup);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_confirmpassword;
    }
}