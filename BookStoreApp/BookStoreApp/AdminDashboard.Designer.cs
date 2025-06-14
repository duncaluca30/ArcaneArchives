using System.Drawing;
using System.Windows.Forms;

namespace BookStoreApp
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private CustomControls.CustomCloseButton btnClose;
        private CustomControls.CustomMinimizeButton btnMinimize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
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
            this.listViewBooks.Size = new System.Drawing.Size(443, 300);
            this.listViewBooks.TabIndex = 4;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "Title";
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
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddBook.Location = new System.Drawing.Point(12, 485);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(120, 40);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteBook.Location = new System.Drawing.Point(168, 485);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdateBook.Location = new System.Drawing.Point(335, 485);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(120, 40);
            this.btnUpdateBook.TabIndex = 10;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(388, 12);
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
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 562);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}