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
    public partial class RemoveStudent : Form {
        public RemoveStudent() {
            InitializeComponent();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            string deleteString = "DELETE FROM Student WHERE studentId = @studentId";
            if (Textbox_StudentId.Text == "") {
                MessageBox.Show("Please enter a valid Id", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.Parameters.AddWithValue("@studentId", Textbox_StudentId.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
