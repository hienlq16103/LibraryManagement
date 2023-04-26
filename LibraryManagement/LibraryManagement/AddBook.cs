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
    public partial class AddBook : Form {

        private DateTime yearOfPublication;

        public AddBook() {
            InitializeComponent();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LoanDate_ValueChanged(object sender, EventArgs e) {
            yearOfPublication = YearOfPublication.Value;
        }

        private void Button_Add_Click(object sender, EventArgs e) {
            string insertString = "INSERT INTO Book VALUES (@bookId,@title,@publisher,@yearOfPublication)";
            if (Textbox_BookId.Text == "") {
                MessageBox.Show("Book Id Id is empty", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_Title.Text == "") {
                MessageBox.Show("Title is empty", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_Publisher.Text == "") {
                MessageBox.Show("Publisher is empty", "Invalid information", MessageBoxButtons.OK);
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                try {
                    SqlCommand cmd = new SqlCommand(insertString, conn);
                    cmd.Parameters.AddWithValue("@bookId", Textbox_BookId.Text);
                    cmd.Parameters.AddWithValue("@title", Textbox_Title.Text);
                    cmd.Parameters.AddWithValue("@publisher", Textbox_Publisher.Text);
                    cmd.Parameters.AddWithValue("@yearOfPublication", yearOfPublication);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book information is recorded", "Information is added successfully", MessageBoxButtons.OK);
                }
                catch {
                    MessageBox.Show("Can not add information", "Error", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }
    }
}
