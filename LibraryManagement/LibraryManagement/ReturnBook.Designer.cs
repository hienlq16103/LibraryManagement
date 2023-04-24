
namespace LibraryManagement {
    partial class ReturnBook {
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
            this.Button_ExitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Combobox_CopyNumber = new System.Windows.Forms.ComboBox();
            this.Combobox_BookName = new System.Windows.Forms.ComboBox();
            this.Button_ReturnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Button_ExitButton.TabIndex = 13;
            this.Button_ExitButton.Text = "X";
            this.Button_ExitButton.UseVisualStyleBackColor = true;
            this.Button_ExitButton.Click += new System.EventHandler(this.Button_ExitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(249, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 34);
            this.label3.TabIndex = 14;
            this.label3.Text = "Return Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(93, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Copy Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(118, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Book Name";
            // 
            // Combobox_CopyNumber
            // 
            this.Combobox_CopyNumber.DisplayMember = "studentName";
            this.Combobox_CopyNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_CopyNumber.FormattingEnabled = true;
            this.Combobox_CopyNumber.Location = new System.Drawing.Point(255, 175);
            this.Combobox_CopyNumber.Name = "Combobox_CopyNumber";
            this.Combobox_CopyNumber.Size = new System.Drawing.Size(358, 24);
            this.Combobox_CopyNumber.TabIndex = 26;
            this.Combobox_CopyNumber.ValueMember = "studentId";
            this.Combobox_CopyNumber.SelectedIndexChanged += new System.EventHandler(this.Combobox_CopyNumber_SelectedIndexChanged);
            // 
            // Combobox_BookName
            // 
            this.Combobox_BookName.DisplayMember = "studentName";
            this.Combobox_BookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_BookName.FormattingEnabled = true;
            this.Combobox_BookName.Location = new System.Drawing.Point(255, 117);
            this.Combobox_BookName.Name = "Combobox_BookName";
            this.Combobox_BookName.Size = new System.Drawing.Size(358, 24);
            this.Combobox_BookName.TabIndex = 25;
            this.Combobox_BookName.ValueMember = "studentId";
            this.Combobox_BookName.SelectedIndexChanged += new System.EventHandler(this.Combobox_BookName_SelectedIndexChanged);
            // 
            // Button_ReturnBook
            // 
            this.Button_ReturnBook.BackgroundImage = global::LibraryManagement.Properties.Resources._return;
            this.Button_ReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_ReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ReturnBook.FlatAppearance.BorderSize = 0;
            this.Button_ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_ReturnBook.Location = new System.Drawing.Point(548, 244);
            this.Button_ReturnBook.Name = "Button_ReturnBook";
            this.Button_ReturnBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_ReturnBook.Size = new System.Drawing.Size(65, 45);
            this.Button_ReturnBook.TabIndex = 31;
            this.Button_ReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_ReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Button_ReturnBook.UseVisualStyleBackColor = true;
            this.Button_ReturnBook.Click += new System.EventHandler(this.Button_ReturnBook_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 633);
            this.Controls.Add(this.Button_ReturnBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Combobox_CopyNumber);
            this.Controls.Add(this.Combobox_BookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ExitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Combobox_CopyNumber;
        private System.Windows.Forms.ComboBox Combobox_BookName;
        private System.Windows.Forms.Button Button_ReturnBook;
    }
}