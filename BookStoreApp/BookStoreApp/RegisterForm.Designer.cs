namespace BookStoreApp
{
    partial class RegisterForm
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
            this.customCloseButton1 = new BookStoreApp.CustomControls.CustomCloseButton();
            this.customMinimizeButton1 = new BookStoreApp.CustomControls.CustomMinimizeButton();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.BackColor = System.Drawing.Color.Transparent;
            this.customCloseButton1.Location = new System.Drawing.Point(372, -1);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.TabIndex = 0;
            // 
            // customMinimizeButton1
            // 
            this.customMinimizeButton1.Location = new System.Drawing.Point(340, -1);
            this.customMinimizeButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customMinimizeButton1.Name = "customMinimizeButton1";
            this.customMinimizeButton1.Size = new System.Drawing.Size(30, 30);
            this.customMinimizeButton1.TabIndex = 1;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Location = new System.Drawing.Point(104, 9);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(211, 28);
            this.labelRegister.TabIndex = 2;
            this.labelRegister.Text = "Register a new account";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(156, 65);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(99, 28);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(115, 96);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 34);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(115, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 34);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepeatPassword.Location = new System.Drawing.Point(115, 257);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(174, 34);
            this.txtRepeatPassword.TabIndex = 6;
            this.txtRepeatPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Repeat Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(151, 317);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 40);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(401, 391);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepeatPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.customMinimizeButton1);
            this.Controls.Add(this.customCloseButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomCloseButton customCloseButton1;
        private CustomControls.CustomMinimizeButton customMinimizeButton1;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepeatPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
    }
}