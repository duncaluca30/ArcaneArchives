using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    partial class UpdateBook
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblBookTitle;
        private Label lblBookAuthor;
        private Label lblBookPrice;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private Button btnUpdate;
        private CustomControls.CustomCloseButton btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblBookTitle = new Label();
            this.lblBookAuthor = new Label();
            this.lblBookPrice = new Label();
            this.txtTitle = new TextBox();
            this.txtAuthor = new TextBox();
            this.txtPrice = new TextBox();
            this.btnUpdate = new Button();
            this.btnClose = new BookStoreApp.CustomControls.CustomCloseButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe Script", 16F, FontStyle.Bold | FontStyle.Italic);
            this.lblTitle.Location = new Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(200, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Book";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new Font("Segoe UI", 12F);
            this.lblBookTitle.Location = new Point(30, 80);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new Size(47, 28);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new Font("Segoe UI", 12F);
            this.txtTitle.Location = new Point(120, 77);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new Size(220, 34);
            this.txtTitle.TabIndex = 2;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new Font("Segoe UI", 12F);
            this.lblBookAuthor.Location = new Point(30, 130);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new Size(68, 28);
            this.lblBookAuthor.TabIndex = 3;
            this.lblBookAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new Font("Segoe UI", 12F);
            this.txtAuthor.Location = new Point(120, 127);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new Size(220, 34);
            this.txtAuthor.TabIndex = 4;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new Font("Segoe UI", 12F);
            this.lblBookPrice.Location = new Point(30, 180);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new Size(54, 28);
            this.lblBookPrice.TabIndex = 5;
            this.lblBookPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new Font("Segoe UI", 12F);
            this.txtPrice.Location = new Point(120, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new Size(220, 34);
            this.txtPrice.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnUpdate.Location = new Point(120, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(120, 40);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Book";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new Point(320, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(30, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new SizeF(11F, 28F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(370, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblTitle);
            this.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "UpdateBook";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "UpdateBook";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}