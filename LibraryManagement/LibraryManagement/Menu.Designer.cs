
namespace LibraryManagement {
    partial class Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Panel_SideMenu = new System.Windows.Forms.Panel();
            this.Panel_Loan = new System.Windows.Forms.Panel();
            this.Button_ReturnBook = new System.Windows.Forms.Button();
            this.Button_BorrowBook = new System.Windows.Forms.Button();
            this.Button_ViewLoan = new System.Windows.Forms.Button();
            this.Button_Loan = new System.Windows.Forms.Button();
            this.Panel_Student = new System.Windows.Forms.Panel();
            this.Button_RemoveStudent = new System.Windows.Forms.Button();
            this.Button_AddStudent = new System.Windows.Forms.Button();
            this.Button_ViewStudent = new System.Windows.Forms.Button();
            this.Button_Student = new System.Windows.Forms.Button();
            this.Panel_Book = new System.Windows.Forms.Panel();
            this.Button_RemoveCopiedBook = new System.Windows.Forms.Button();
            this.Button_RemoveBook = new System.Windows.Forms.Button();
            this.Button_AddCopiedBook = new System.Windows.Forms.Button();
            this.Button_AddBook = new System.Windows.Forms.Button();
            this.Button_ViewCopiedBook = new System.Windows.Forms.Button();
            this.Button_ViewBook = new System.Windows.Forms.Button();
            this.Button_Book = new System.Windows.Forms.Button();
            this.Panel_Container = new System.Windows.Forms.Panel();
            this.Button_AddAuthor = new System.Windows.Forms.Button();
            this.Button_RemoveAuthor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_SideMenu.SuspendLayout();
            this.Panel_Loan.SuspendLayout();
            this.Panel_Student.SuspendLayout();
            this.Panel_Book.SuspendLayout();
            this.Panel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_SideMenu
            // 
            this.Panel_SideMenu.AutoScroll = true;
            this.Panel_SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Panel_SideMenu.Controls.Add(this.button1);
            this.Panel_SideMenu.Controls.Add(this.Panel_Loan);
            this.Panel_SideMenu.Controls.Add(this.Button_Loan);
            this.Panel_SideMenu.Controls.Add(this.Panel_Student);
            this.Panel_SideMenu.Controls.Add(this.Button_Student);
            this.Panel_SideMenu.Controls.Add(this.Panel_Book);
            this.Panel_SideMenu.Controls.Add(this.Button_Book);
            this.Panel_SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_SideMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_SideMenu.Name = "Panel_SideMenu";
            this.Panel_SideMenu.Size = new System.Drawing.Size(250, 633);
            this.Panel_SideMenu.TabIndex = 0;
            // 
            // Panel_Loan
            // 
            this.Panel_Loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Panel_Loan.Controls.Add(this.Button_ReturnBook);
            this.Panel_Loan.Controls.Add(this.Button_BorrowBook);
            this.Panel_Loan.Controls.Add(this.Button_ViewLoan);
            this.Panel_Loan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Loan.Location = new System.Drawing.Point(0, 609);
            this.Panel_Loan.Name = "Panel_Loan";
            this.Panel_Loan.Size = new System.Drawing.Size(229, 144);
            this.Panel_Loan.TabIndex = 2;
            // 
            // Button_ReturnBook
            // 
            this.Button_ReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ReturnBook.FlatAppearance.BorderSize = 0;
            this.Button_ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ReturnBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ReturnBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_ReturnBook.Location = new System.Drawing.Point(0, 80);
            this.Button_ReturnBook.Name = "Button_ReturnBook";
            this.Button_ReturnBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_ReturnBook.Size = new System.Drawing.Size(229, 40);
            this.Button_ReturnBook.TabIndex = 9;
            this.Button_ReturnBook.Text = "Return Book";
            this.Button_ReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ReturnBook.UseVisualStyleBackColor = true;
            this.Button_ReturnBook.Click += new System.EventHandler(this.Button_ReturnBook_Click);
            // 
            // Button_BorrowBook
            // 
            this.Button_BorrowBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_BorrowBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_BorrowBook.FlatAppearance.BorderSize = 0;
            this.Button_BorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BorrowBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_BorrowBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_BorrowBook.Location = new System.Drawing.Point(0, 40);
            this.Button_BorrowBook.Name = "Button_BorrowBook";
            this.Button_BorrowBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_BorrowBook.Size = new System.Drawing.Size(229, 40);
            this.Button_BorrowBook.TabIndex = 6;
            this.Button_BorrowBook.Text = "Borrow Book";
            this.Button_BorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_BorrowBook.UseVisualStyleBackColor = true;
            this.Button_BorrowBook.Click += new System.EventHandler(this.Button_BorrowBook_Click);
            // 
            // Button_ViewLoan
            // 
            this.Button_ViewLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ViewLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ViewLoan.FlatAppearance.BorderSize = 0;
            this.Button_ViewLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ViewLoan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ViewLoan.ForeColor = System.Drawing.Color.Snow;
            this.Button_ViewLoan.Location = new System.Drawing.Point(0, 0);
            this.Button_ViewLoan.Name = "Button_ViewLoan";
            this.Button_ViewLoan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_ViewLoan.Size = new System.Drawing.Size(229, 40);
            this.Button_ViewLoan.TabIndex = 10;
            this.Button_ViewLoan.Text = "View Current Loan";
            this.Button_ViewLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ViewLoan.UseVisualStyleBackColor = true;
            this.Button_ViewLoan.Click += new System.EventHandler(this.Button_ViewLoan_Click_1);
            // 
            // Button_Loan
            // 
            this.Button_Loan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.Button_Loan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Loan.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Loan.FlatAppearance.BorderSize = 0;
            this.Button_Loan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Loan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Loan.ForeColor = System.Drawing.Color.Snow;
            this.Button_Loan.Location = new System.Drawing.Point(0, 569);
            this.Button_Loan.Name = "Button_Loan";
            this.Button_Loan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Button_Loan.Size = new System.Drawing.Size(229, 40);
            this.Button_Loan.TabIndex = 3;
            this.Button_Loan.Text = "Loan";
            this.Button_Loan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Loan.UseVisualStyleBackColor = false;
            this.Button_Loan.Click += new System.EventHandler(this.Button_Loan_Click_1);
            // 
            // Panel_Student
            // 
            this.Panel_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Panel_Student.Controls.Add(this.Button_RemoveStudent);
            this.Panel_Student.Controls.Add(this.Button_AddStudent);
            this.Panel_Student.Controls.Add(this.Button_ViewStudent);
            this.Panel_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Student.Location = new System.Drawing.Point(0, 423);
            this.Panel_Student.Name = "Panel_Student";
            this.Panel_Student.Size = new System.Drawing.Size(229, 146);
            this.Panel_Student.TabIndex = 1;
            // 
            // Button_RemoveStudent
            // 
            this.Button_RemoveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_RemoveStudent.FlatAppearance.BorderSize = 0;
            this.Button_RemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveStudent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveStudent.ForeColor = System.Drawing.Color.Snow;
            this.Button_RemoveStudent.Location = new System.Drawing.Point(0, 80);
            this.Button_RemoveStudent.Name = "Button_RemoveStudent";
            this.Button_RemoveStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_RemoveStudent.Size = new System.Drawing.Size(229, 40);
            this.Button_RemoveStudent.TabIndex = 9;
            this.Button_RemoveStudent.Text = "Remove Student";
            this.Button_RemoveStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_RemoveStudent.UseVisualStyleBackColor = true;
            this.Button_RemoveStudent.Click += new System.EventHandler(this.Button_RemoveStudent_Click);
            // 
            // Button_AddStudent
            // 
            this.Button_AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_AddStudent.FlatAppearance.BorderSize = 0;
            this.Button_AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddStudent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddStudent.ForeColor = System.Drawing.Color.Snow;
            this.Button_AddStudent.Location = new System.Drawing.Point(0, 40);
            this.Button_AddStudent.Name = "Button_AddStudent";
            this.Button_AddStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_AddStudent.Size = new System.Drawing.Size(229, 40);
            this.Button_AddStudent.TabIndex = 8;
            this.Button_AddStudent.Text = "Add Student";
            this.Button_AddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_AddStudent.UseVisualStyleBackColor = true;
            this.Button_AddStudent.Click += new System.EventHandler(this.Button_AddStudent_Click);
            // 
            // Button_ViewStudent
            // 
            this.Button_ViewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ViewStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ViewStudent.FlatAppearance.BorderSize = 0;
            this.Button_ViewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ViewStudent.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ViewStudent.ForeColor = System.Drawing.Color.Snow;
            this.Button_ViewStudent.Location = new System.Drawing.Point(0, 0);
            this.Button_ViewStudent.Name = "Button_ViewStudent";
            this.Button_ViewStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_ViewStudent.Size = new System.Drawing.Size(229, 40);
            this.Button_ViewStudent.TabIndex = 6;
            this.Button_ViewStudent.Text = "View Student";
            this.Button_ViewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ViewStudent.UseVisualStyleBackColor = true;
            this.Button_ViewStudent.Click += new System.EventHandler(this.Button_ViewStudent_Click);
            // 
            // Button_Student
            // 
            this.Button_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.Button_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Student.FlatAppearance.BorderSize = 0;
            this.Button_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Student.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Student.ForeColor = System.Drawing.Color.Snow;
            this.Button_Student.Location = new System.Drawing.Point(0, 383);
            this.Button_Student.Name = "Button_Student";
            this.Button_Student.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Button_Student.Size = new System.Drawing.Size(229, 40);
            this.Button_Student.TabIndex = 2;
            this.Button_Student.Text = "Student";
            this.Button_Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Student.UseVisualStyleBackColor = false;
            this.Button_Student.Click += new System.EventHandler(this.Button_Student_Click_1);
            // 
            // Panel_Book
            // 
            this.Panel_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.Panel_Book.Controls.Add(this.Button_RemoveCopiedBook);
            this.Panel_Book.Controls.Add(this.Button_RemoveBook);
            this.Panel_Book.Controls.Add(this.Button_RemoveAuthor);
            this.Panel_Book.Controls.Add(this.Button_AddCopiedBook);
            this.Panel_Book.Controls.Add(this.Button_AddAuthor);
            this.Panel_Book.Controls.Add(this.Button_AddBook);
            this.Panel_Book.Controls.Add(this.Button_ViewCopiedBook);
            this.Panel_Book.Controls.Add(this.Button_ViewBook);
            this.Panel_Book.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Book.Location = new System.Drawing.Point(0, 40);
            this.Panel_Book.Name = "Panel_Book";
            this.Panel_Book.Size = new System.Drawing.Size(229, 343);
            this.Panel_Book.TabIndex = 0;
            // 
            // Button_RemoveCopiedBook
            // 
            this.Button_RemoveCopiedBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveCopiedBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_RemoveCopiedBook.FlatAppearance.BorderSize = 0;
            this.Button_RemoveCopiedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveCopiedBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveCopiedBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_RemoveCopiedBook.Location = new System.Drawing.Point(0, 280);
            this.Button_RemoveCopiedBook.Name = "Button_RemoveCopiedBook";
            this.Button_RemoveCopiedBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_RemoveCopiedBook.Size = new System.Drawing.Size(229, 40);
            this.Button_RemoveCopiedBook.TabIndex = 9;
            this.Button_RemoveCopiedBook.Text = "Remove Copied Book";
            this.Button_RemoveCopiedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_RemoveCopiedBook.UseVisualStyleBackColor = true;
            this.Button_RemoveCopiedBook.Click += new System.EventHandler(this.Button_RemoveCopiedBook_Click);
            // 
            // Button_RemoveBook
            // 
            this.Button_RemoveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_RemoveBook.FlatAppearance.BorderSize = 0;
            this.Button_RemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_RemoveBook.Location = new System.Drawing.Point(0, 240);
            this.Button_RemoveBook.Name = "Button_RemoveBook";
            this.Button_RemoveBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_RemoveBook.Size = new System.Drawing.Size(229, 40);
            this.Button_RemoveBook.TabIndex = 8;
            this.Button_RemoveBook.Text = "Remove Book";
            this.Button_RemoveBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_RemoveBook.UseVisualStyleBackColor = true;
            this.Button_RemoveBook.Click += new System.EventHandler(this.Button_RemoveBook_Click);
            // 
            // Button_AddCopiedBook
            // 
            this.Button_AddCopiedBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddCopiedBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_AddCopiedBook.FlatAppearance.BorderSize = 0;
            this.Button_AddCopiedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddCopiedBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddCopiedBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_AddCopiedBook.Location = new System.Drawing.Point(0, 160);
            this.Button_AddCopiedBook.Name = "Button_AddCopiedBook";
            this.Button_AddCopiedBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_AddCopiedBook.Size = new System.Drawing.Size(229, 40);
            this.Button_AddCopiedBook.TabIndex = 6;
            this.Button_AddCopiedBook.Text = "Add Copied Book";
            this.Button_AddCopiedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_AddCopiedBook.UseVisualStyleBackColor = true;
            this.Button_AddCopiedBook.Click += new System.EventHandler(this.Button_AddCopiedBook_Click);
            // 
            // Button_AddBook
            // 
            this.Button_AddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_AddBook.FlatAppearance.BorderSize = 0;
            this.Button_AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_AddBook.Location = new System.Drawing.Point(0, 80);
            this.Button_AddBook.Name = "Button_AddBook";
            this.Button_AddBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_AddBook.Size = new System.Drawing.Size(229, 40);
            this.Button_AddBook.TabIndex = 4;
            this.Button_AddBook.Text = "Add Book";
            this.Button_AddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_AddBook.UseVisualStyleBackColor = true;
            this.Button_AddBook.Click += new System.EventHandler(this.Button_AddBook_Click);
            // 
            // Button_ViewCopiedBook
            // 
            this.Button_ViewCopiedBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ViewCopiedBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ViewCopiedBook.FlatAppearance.BorderSize = 0;
            this.Button_ViewCopiedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ViewCopiedBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ViewCopiedBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_ViewCopiedBook.Location = new System.Drawing.Point(0, 40);
            this.Button_ViewCopiedBook.Name = "Button_ViewCopiedBook";
            this.Button_ViewCopiedBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_ViewCopiedBook.Size = new System.Drawing.Size(229, 40);
            this.Button_ViewCopiedBook.TabIndex = 3;
            this.Button_ViewCopiedBook.Text = "View Copied Book";
            this.Button_ViewCopiedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ViewCopiedBook.UseVisualStyleBackColor = true;
            this.Button_ViewCopiedBook.Click += new System.EventHandler(this.Button_ViewCopiedBook_Click);
            // 
            // Button_ViewBook
            // 
            this.Button_ViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ViewBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ViewBook.FlatAppearance.BorderSize = 0;
            this.Button_ViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ViewBook.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ViewBook.ForeColor = System.Drawing.Color.Snow;
            this.Button_ViewBook.Location = new System.Drawing.Point(0, 0);
            this.Button_ViewBook.Name = "Button_ViewBook";
            this.Button_ViewBook.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_ViewBook.Size = new System.Drawing.Size(229, 40);
            this.Button_ViewBook.TabIndex = 1;
            this.Button_ViewBook.Text = "View Book";
            this.Button_ViewBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ViewBook.UseVisualStyleBackColor = true;
            this.Button_ViewBook.Click += new System.EventHandler(this.Button_ViewBook_Click);
            // 
            // Button_Book
            // 
            this.Button_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.Button_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Book.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Book.FlatAppearance.BorderSize = 0;
            this.Button_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Book.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Book.ForeColor = System.Drawing.Color.Snow;
            this.Button_Book.Location = new System.Drawing.Point(0, 0);
            this.Button_Book.Name = "Button_Book";
            this.Button_Book.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Button_Book.Size = new System.Drawing.Size(229, 40);
            this.Button_Book.TabIndex = 1;
            this.Button_Book.Text = "Book";
            this.Button_Book.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Book.UseVisualStyleBackColor = false;
            this.Button_Book.Click += new System.EventHandler(this.Button_Book_Click_1);
            // 
            // Panel_Container
            // 
            this.Panel_Container.BackColor = System.Drawing.Color.Gainsboro;
            this.Panel_Container.Controls.Add(this.pictureBox1);
            this.Panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Container.Location = new System.Drawing.Point(250, 0);
            this.Panel_Container.Name = "Panel_Container";
            this.Panel_Container.Size = new System.Drawing.Size(700, 633);
            this.Panel_Container.TabIndex = 1;
            // 
            // Button_AddAuthor
            // 
            this.Button_AddAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AddAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_AddAuthor.FlatAppearance.BorderSize = 0;
            this.Button_AddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AddAuthor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AddAuthor.ForeColor = System.Drawing.Color.Snow;
            this.Button_AddAuthor.Location = new System.Drawing.Point(0, 120);
            this.Button_AddAuthor.Name = "Button_AddAuthor";
            this.Button_AddAuthor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_AddAuthor.Size = new System.Drawing.Size(229, 40);
            this.Button_AddAuthor.TabIndex = 10;
            this.Button_AddAuthor.Text = "Add Author";
            this.Button_AddAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_AddAuthor.UseVisualStyleBackColor = true;
            this.Button_AddAuthor.Click += new System.EventHandler(this.Button_AddAuthor_Click);
            // 
            // Button_RemoveAuthor
            // 
            this.Button_RemoveAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_RemoveAuthor.FlatAppearance.BorderSize = 0;
            this.Button_RemoveAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveAuthor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RemoveAuthor.ForeColor = System.Drawing.Color.Snow;
            this.Button_RemoveAuthor.Location = new System.Drawing.Point(0, 200);
            this.Button_RemoveAuthor.Name = "Button_RemoveAuthor";
            this.Button_RemoveAuthor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Button_RemoveAuthor.Size = new System.Drawing.Size(229, 40);
            this.Button_RemoveAuthor.TabIndex = 11;
            this.Button_RemoveAuthor.Text = "Remove Author";
            this.Button_RemoveAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_RemoveAuthor.UseVisualStyleBackColor = true;
            this.Button_RemoveAuthor.Click += new System.EventHandler(this.Button_RemoveAuthor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagement.Properties.Resources.LibraryIcon;
            this.pictureBox1.Location = new System.Drawing.Point(233, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LibraryManagement.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 753);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(229, 52);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 633);
            this.Controls.Add(this.Panel_Container);
            this.Controls.Add(this.Panel_SideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Panel_SideMenu.ResumeLayout(false);
            this.Panel_Loan.ResumeLayout(false);
            this.Panel_Student.ResumeLayout(false);
            this.Panel_Book.ResumeLayout(false);
            this.Panel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_SideMenu;
        private System.Windows.Forms.Panel Panel_Book;
        private System.Windows.Forms.Button Button_RemoveBook;
        private System.Windows.Forms.Button Button_AddCopiedBook;
        private System.Windows.Forms.Button Button_AddBook;
        private System.Windows.Forms.Button Button_ViewCopiedBook;
        private System.Windows.Forms.Button Button_ViewBook;
        private System.Windows.Forms.Button Button_RemoveCopiedBook;
        private System.Windows.Forms.Panel Panel_Loan;
        private System.Windows.Forms.Button Button_ReturnBook;
        private System.Windows.Forms.Button Button_BorrowBook;
        private System.Windows.Forms.Panel Panel_Student;
        private System.Windows.Forms.Button Button_RemoveStudent;
        private System.Windows.Forms.Button Button_AddStudent;
        private System.Windows.Forms.Button Button_ViewStudent;
        private System.Windows.Forms.Button Button_Loan;
        private System.Windows.Forms.Button Button_Student;
        private System.Windows.Forms.Button Button_Book;
        private System.Windows.Forms.Panel Panel_Container;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Button_ViewLoan;
        private System.Windows.Forms.Button Button_AddAuthor;
        private System.Windows.Forms.Button Button_RemoveAuthor;
    }
}