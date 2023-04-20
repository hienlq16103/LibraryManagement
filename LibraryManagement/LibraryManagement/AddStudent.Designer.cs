
namespace LibraryManagement {
    partial class AddStudent {
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Textbox_StudentId = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Textbox_Email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_StudentName = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(159, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter student information";
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
            this.Button_ExitButton.TabIndex = 11;
            this.Button_ExitButton.Text = "X";
            this.Button_ExitButton.UseVisualStyleBackColor = true;
            this.Button_ExitButton.Click += new System.EventHandler(this.Button_ExitButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Textbox_StudentId);
            this.panel3.Location = new System.Drawing.Point(66, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 45);
            this.panel3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Id:";
            // 
            // Textbox_StudentId
            // 
            this.Textbox_StudentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_StudentId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_StudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Textbox_StudentId.Location = new System.Drawing.Point(138, 12);
            this.Textbox_StudentId.Name = "Textbox_StudentId";
            this.Textbox_StudentId.Size = new System.Drawing.Size(405, 25);
            this.Textbox_StudentId.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Textbox_Email);
            this.panel4.Location = new System.Drawing.Point(66, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 45);
            this.panel4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_Email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Textbox_Email.Location = new System.Drawing.Point(87, 12);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.Size = new System.Drawing.Size(456, 25);
            this.Textbox_Email.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Textbox_StudentName);
            this.panel1.Location = new System.Drawing.Point(66, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 45);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student name:";
            // 
            // Textbox_StudentName
            // 
            this.Textbox_StudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox_StudentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_StudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Textbox_StudentName.Location = new System.Drawing.Point(176, 12);
            this.Textbox_StudentName.Name = "Textbox_StudentName";
            this.Textbox_StudentName.Size = new System.Drawing.Size(367, 25);
            this.Textbox_StudentName.TabIndex = 5;
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
            this.Button_Add.Location = new System.Drawing.Point(66, 462);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(125, 52);
            this.Button_Add.TabIndex = 15;
            this.Button_Add.UseVisualStyleBackColor = false;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 633);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Button_ExitButton);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_ExitButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Textbox_StudentId;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Textbox_Email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_StudentName;
        private System.Windows.Forms.Button Button_Add;
    }
}