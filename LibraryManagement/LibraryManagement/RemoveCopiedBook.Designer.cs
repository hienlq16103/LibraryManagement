
namespace LibraryManagement {
    partial class RemoveCopiedBook {
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
            this.Button_RemoveCopiedBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Combobox_CopyNumber = new System.Windows.Forms.ComboBox();
            this.Combobox_BookName = new System.Windows.Forms.ComboBox();
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
            this.label3.Location = new System.Drawing.Point(191, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(432, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select copied book to remove";
            // 
            // Button_RemoveCopiedBook
            // 
            this.Button_RemoveCopiedBook.BackgroundImage = global::LibraryManagement.Properties.Resources.delete;
            this.Button_RemoveCopiedBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_RemoveCopiedBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveCopiedBook.FlatAppearance.BorderSize = 0;
            this.Button_RemoveCopiedBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveCopiedBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_RemoveCopiedBook.Location = new System.Drawing.Point(471, 263);
            this.Button_RemoveCopiedBook.Name = "Button_RemoveCopiedBook";
            this.Button_RemoveCopiedBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_RemoveCopiedBook.Size = new System.Drawing.Size(65, 45);
            this.Button_RemoveCopiedBook.TabIndex = 38;
            this.Button_RemoveCopiedBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_RemoveCopiedBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Button_RemoveCopiedBook.UseVisualStyleBackColor = true;
            this.Button_RemoveCopiedBook.Click += new System.EventHandler(this.Button_RemoveCopiedBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(80, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Copy number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(98, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Book name:";
            // 
            // Combobox_CopyNumber
            // 
            this.Combobox_CopyNumber.DisplayMember = "studentName";
            this.Combobox_CopyNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_CopyNumber.FormattingEnabled = true;
            this.Combobox_CopyNumber.Location = new System.Drawing.Point(265, 177);
            this.Combobox_CopyNumber.Name = "Combobox_CopyNumber";
            this.Combobox_CopyNumber.Size = new System.Drawing.Size(358, 24);
            this.Combobox_CopyNumber.TabIndex = 35;
            this.Combobox_CopyNumber.ValueMember = "studentId";
            this.Combobox_CopyNumber.SelectedIndexChanged += new System.EventHandler(this.Combobox_AuthorName_SelectedIndexChanged);
            // 
            // Combobox_BookName
            // 
            this.Combobox_BookName.DisplayMember = "studentName";
            this.Combobox_BookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_BookName.FormattingEnabled = true;
            this.Combobox_BookName.Location = new System.Drawing.Point(265, 109);
            this.Combobox_BookName.Name = "Combobox_BookName";
            this.Combobox_BookName.Size = new System.Drawing.Size(358, 24);
            this.Combobox_BookName.TabIndex = 34;
            this.Combobox_BookName.ValueMember = "studentId";
            this.Combobox_BookName.SelectedIndexChanged += new System.EventHandler(this.Combobox_BookName_SelectedIndexChanged);
            // 
            // RemoveCopiedBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 633);
            this.Controls.Add(this.Button_RemoveCopiedBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Combobox_CopyNumber);
            this.Controls.Add(this.Combobox_BookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveCopiedBook";
            this.Text = "RemoveCopiedBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ExitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_RemoveCopiedBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combobox_CopyNumber;
        private System.Windows.Forms.ComboBox Combobox_BookName;
    }
}