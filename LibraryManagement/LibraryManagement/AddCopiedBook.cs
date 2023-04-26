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
    public partial class AddCopiedBook : Form {

        string bookId = "";

        public AddCopiedBook() {
            InitializeComponent();
            SetBookDropDown();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button_Add_Click(object sender, EventArgs e) {
            string insertString =
                "INSERT INTO CopiedBook VALUES (@bookId,@copyNumber,@availability)";
            if (bookId == "" || Combobox_BookName.SelectedValue == null) {
                MessageBox.Show("Please choose a book", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_CopyNumber.Text == "") {
                MessageBox.Show("Copy number is empty", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                try {
                    SqlCommand insertCommand = new SqlCommand(insertString, conn);
                    insertCommand.Parameters.AddWithValue("@bookId", bookId);
                    insertCommand.Parameters.AddWithValue("@copyNumber", Textbox_CopyNumber.Text);
                    insertCommand.Parameters.AddWithValue("@availability", true);
                    insertCommand.ExecuteNonQuery();
                    SetBookDropDown();
                    Textbox_CopyNumber.Text = "";
                    MessageBox.Show("A new copy version is recorded", "Added Copied book successfully", MessageBoxButtons.OK);
                }
                catch {
                    MessageBox.Show("Can not add information", "Error", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }

        private void Combobox_BookName_SelectedIndexChanged(object sender, EventArgs e) {
            if (Combobox_BookName.SelectedIndex == -1) {
                return;
            }
            if (Combobox_BookName.SelectedValue == null) {
                return;
            }
            bookId = Combobox_BookName.SelectedValue.ToString();
        }
        private void SetBookDropDown() {
            Combobox_BookName.DisplayMember = "title";
            Combobox_BookName.ValueMember = "bookId";
            Combobox_BookName.DataSource = GetBookDataSet().Tables[0];
            Combobox_BookName.SelectedIndex = -1;
            Combobox_BookName.Refresh();
        }
        private DataSet GetBookDataSet() {
            DataSet data = new DataSet();
            string queryString = "SELECT bookId, title FROM Book";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(queryString, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
