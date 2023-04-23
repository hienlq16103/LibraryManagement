
namespace LibraryManagement {
    partial class BorrowBook {
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
            this.label3 = new System.Windows.Forms.Label();
            this.Button_ExitButton = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Combobox_BookName = new System.Windows.Forms.ComboBox();
            this.Combobox_CopyNumber = new System.Windows.Forms.ComboBox();
            this.Combobox_StudentName = new System.Windows.Forms.ComboBox();
            this.LoanDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(244, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Borrow Book";
            // 
            // Button_ExitButton
            // 
            this.Button_ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ExitButton.FlatAppearance.BorderSize = 0;
            this.Button_ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ExitButton.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Button_ExitButton.Location = new System.Drawing.Point(12, 12);
            this.Button_ExitButton.Name = "Button_ExitButton";
            this.Button_ExitButton.Size = new System.Drawing.Size(40, 40);
            this.Button_ExitButton.TabIndex = 12;
            this.Button_ExitButton.Text = "X";
            this.Button_ExitButton.UseVisualStyleBackColor = true;
            this.Button_ExitButton.Click += new System.EventHandler(this.Button_ExitButton_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.Gainsboro;
            this.Button_Add.BackgroundImage = global::LibraryManagement.Properties.Resources.add;
            this.Button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Add.FlatAppearance.BorderSize = 0;
            this.Button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(74, 543);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(125, 52);
            this.Button_Add.TabIndex = 16;
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Combobox_BookName
            // 
            this.Combobox_BookName.DisplayMember = "studentName";
            this.Combobox_BookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_BookName.FormattingEnabled = true;
            this.Combobox_BookName.Location = new System.Drawing.Point(232, 126);
            this.Combobox_BookName.Name = "Combobox_BookName";
            this.Combobox_BookName.Size = new System.Drawing.Size(358, 24);
            this.Combobox_BookName.TabIndex = 17;
            this.Combobox_BookName.ValueMember = "studentId";
            this.Combobox_BookName.SelectedIndexChanged += new System.EventHandler(this.Combobox_BookName_SelectedIndexChanged);
            // 
            // Combobox_CopyNumber
            // 
            this.Combobox_CopyNumber.DisplayMember = "studentName";
            this.Combobox_CopyNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_CopyNumber.FormattingEnabled = true;
            this.Combobox_CopyNumber.Location = new System.Drawing.Point(232, 184);
            this.Combobox_CopyNumber.Name = "Combobox_CopyNumber";
            this.Combobox_CopyNumber.Size = new System.Drawing.Size(358, 24);
            this.Combobox_CopyNumber.TabIndex = 18;
            this.Combobox_CopyNumber.ValueMember = "studentId";
            this.Combobox_CopyNumber.SelectedIndexChanged += new System.EventHandler(this.Combobox_CopyNumber_SelectedIndexChanged);
            // 
            // Combobox_StudentName
            // 
            this.Combobox_StudentName.DisplayMember = "studentName";
            this.Combobox_StudentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_StudentName.FormattingEnabled = true;
            this.Combobox_StudentName.Location = new System.Drawing.Point(232, 248);
            this.Combobox_StudentName.Name = "Combobox_StudentName";
            this.Combobox_StudentName.Size = new System.Drawing.Size(358, 24);
            this.Combobox_StudentName.TabIndex = 19;
            this.Combobox_StudentName.ValueMember = "studentId";
            this.Combobox_StudentName.SelectedIndexChanged += new System.EventHandler(this.Combobox_StudentName_SelectedIndexChanged);
            // 
            // LoanDate
            // 
            this.LoanDate.CustomFormat = "dd-MM-yyyy";
            this.LoanDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LoanDate.Location = new System.Drawing.Point(232, 319);
            this.LoanDate.Name = "LoanDate";
            this.LoanDate.Size = new System.Drawing.Size(358, 23);
            this.LoanDate.TabIndex = 20;
            this.LoanDate.Value = new System.DateTime(2023, 4, 23, 8, 59, 35, 0);
            this.LoanDate.ValueChanged += new System.EventHandler(this.LoanDate_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 393);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(358, 23);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 23, 8, 59, 35, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(95, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(70, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Copy Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(70, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Student name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(106, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Loan Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(114, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Due Date";
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 633);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LoanDate);
            this.Controls.Add(this.Combobox_StudentName);
            this.Controls.Add(this.Combobox_CopyNumber);
            this.Controls.Add(this.Combobox_BookName);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_ExitButton);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_ExitButton;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.ComboBox Combobox_BookName;
        private System.Windows.Forms.ComboBox Combobox_CopyNumber;
        private System.Windows.Forms.ComboBox Combobox_StudentName;
        private System.Windows.Forms.DateTimePicker LoanDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}