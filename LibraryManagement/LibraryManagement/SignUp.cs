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
    public partial class SignUp : Form {
        public SignUp() {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e) {
            string insertString = "INSERT INTO LibraryManager VALUES (@username,@password,@managerName,@email,@phoneNumber)";
            if (Textbox_Username.Text == "" || Textbox_password.Text == "") {
                MessageBox.Show("Username or Password is empty", "Sign up failed", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_ManagerName.Text == "") {
                MessageBox.Show("Manager name is empty", "Sign up failed", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_Email.Text == "") {
                MessageBox.Show("Email is empty", "Sign up failed", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_PhoneNumber.Text == "") {
                MessageBox.Show("Phone number is empty", "Sign up failed", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                try {
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.Parameters.AddWithValue("@username", Textbox_Username.Text);
                    cmd.Parameters.AddWithValue("@password", Textbox_password.Text);
                    cmd.Parameters.AddWithValue("@managerName", Textbox_ManagerName.Text);
                    cmd.Parameters.AddWithValue("@email", Textbox_Email.Text);
                    cmd.Parameters.AddWithValue("@phoneNumber", Textbox_PhoneNumber.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign up successfully", "Please proceed to the Login page", MessageBoxButtons.OK);
                }
                catch {
                    MessageBox.Show("Can not create account", "Sign up error", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void Button_Cancel_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
    }
}
