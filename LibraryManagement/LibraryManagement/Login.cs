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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
           
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void Textbox_Username_TextChanged(object sender, EventArgs e) {

        }

        private void Textbox_Password_TextChanged(object sender, EventArgs e) {

        }

        private void Button_Login_Click(object sender, EventArgs e) {
            SqlConnection conn = new SqlConnection(ConnectionString.connectionString);
            string username = Textbox_Username.Text;
            string password = Textbox_Password.Text;

            if (username.Length == 0 || password.Length == 0) {
                MessageBox.Show("Please enter username and password",
                    "Username or password is empty", MessageBoxButtons.OK);
                return;
            }
            try {
                conn.Open();
                string sql = "SELECT* FROM LibraryManager WHERE " +
                    "username='" + username + "' AND password='" + password + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read()) {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                } else {
                    MessageBox.Show("username or password is incorrect"
                        , "Login error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Can not login to the server"
                    , "Login error"
                    , MessageBoxButtons.OK);
            }
            finally {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
