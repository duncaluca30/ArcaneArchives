namespace BookStoreApp
{
    partial class LoginForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnMinimize = new BookStoreApp.CustomControls.CustomMinimizeButton();
            this.btnClose = new BookStoreApp.CustomControls.CustomCloseButton();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(115, 91);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(167, 34);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(115, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 34);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(156, 60);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(99, 28);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "Username";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(156, 164);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(93, 28);
            this.labelPass.TabIndex = 5;
            this.labelPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(155, 256);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 41);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome Reader";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(155, 319);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 41);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(340, -1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(372, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(401, 391);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomCloseButton btnClose;
        private CustomControls.CustomMinimizeButton btnMinimize;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
    }
}