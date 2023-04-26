using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement {
    public partial class AddStudent : Form {
        public AddStudent() {
            InitializeComponent();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button_Add_Click(object sender, EventArgs e) {
            string insertString = "INSERT INTO Student VALUES (@studentId,@studentName,@email)";
            if (Textbox_StudentId.Text == "") {
                MessageBox.Show("Student Id is empty", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_StudentName.Text == "") {
                MessageBox.Show("Student name is empty", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                try {
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.Parameters.AddWithValue("@studentId", Textbox_StudentId.Text);
                    cmd.Parameters.AddWithValue("@studentName", Textbox_StudentName.Text);
                    cmd.Parameters.AddWithValue("@email", Textbox_Email.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student information is recorded", "Information is added successfully", MessageBoxButtons.OK);
                }
                catch {
                    MessageBox.Show("Can not add information", "Error", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }

        private void Textbox_StudentId_TextChanged(object sender, EventArgs e) {

        }
    }
}
