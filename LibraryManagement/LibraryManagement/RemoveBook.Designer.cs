
namespace LibraryManagement {
    partial class RemoveBook {
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Button_RemoveStudent = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(103, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select book to remove";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "studentName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "studentId";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Button_RemoveStudent
            // 
            this.Button_RemoveStudent.BackgroundImage = global::LibraryManagement.Properties.Resources.delete;
            this.Button_RemoveStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_RemoveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_RemoveStudent.FlatAppearance.BorderSize = 0;
            this.Button_RemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RemoveStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_RemoveStudent.Location = new System.Drawing.Point(516, 100);
            this.Button_RemoveStudent.Name = "Button_RemoveStudent";
            this.Button_RemoveStudent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_RemoveStudent.Size = new System.Drawing.Size(65, 45);
            this.Button_RemoveStudent.TabIndex = 18;
            this.Button_RemoveStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_RemoveStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Button_RemoveStudent.UseVisualStyleBackColor = true;
            this.Button_RemoveStudent.Click += new System.EventHandler(this.Button_RemoveStudent_Click);
            // 
            // RemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 633);
            this.Controls.Add(this.Button_RemoveStudent);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveBook";
            this.Text = "RemoveBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ExitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Button_RemoveStudent;
    }
}