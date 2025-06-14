using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    partial class CustomerDashboard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCart = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.basket1 = new BookStoreApp.CustomControls.Basket();
            this.btnMinimize = new BookStoreApp.CustomControls.CustomMinimizeButton();
            this.btnClose = new BookStoreApp.CustomControls.CustomCloseButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.Location = new System.Drawing.Point(51, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 55);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "ArcaneArchives";
            // 
            // listViewBooks
            // 
            this.listViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.Price});
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.GridLines = true;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(12, 171);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(443, 379);
            this.listViewBooks.TabIndex = 4;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            this.listViewBooks.SelectedIndexChanged += new System.EventHandler(this.listViewBooks_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Titile";
            this.Title.Width = 180;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 180;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 80;
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(247, 129);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(164, 37);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Add to cart";
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(12, 131);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 34);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(211, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(30, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // basket1
            // 
            this.basket1.Location = new System.Drawing.Point(418, 131);
            this.basket1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.basket1.Name = "basket1";
            this.basket1.Size = new System.Drawing.Size(37, 34);
            this.basket1.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(388, 12);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(425, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 562);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.basket1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomCloseButton btnClose;
        private CustomControls.CustomMinimizeButton btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private CustomControls.Basket basket1;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}