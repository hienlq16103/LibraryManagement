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
    public partial class AddAuthor : Form {

        string bookId = "";

        public AddAuthor() {
            InitializeComponent();
            SetBookDropDown();
        }
        private void Button_Add_Click(object sender, EventArgs e) {
            string insertAuthor = "INSERT INTO Author VALUES (@authorName)";
            string insertWrittenBy = "INSERT INTO WrittenBy VALUES (@bookId,@authorName)";
            if (bookId == "" || Combobox_BookName.SelectedValue == null) {
                MessageBox.Show("Please choose a book", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (Textbox_AuthorName.Text == "") {
                MessageBox.Show("Author name is empty", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                try {
                    SqlCommand insertAuthorCommand = new SqlCommand(insertAuthor, conn);
                    SqlCommand insertWrittenByCommand = new SqlCommand(insertWrittenBy, conn);
                    insertAuthorCommand.Parameters.AddWithValue("@authorName", Textbox_AuthorName.Text);
                    insertAuthorCommand.ExecuteNonQuery();
                    insertWrittenByCommand.Parameters.AddWithValue("@bookId", bookId);
                    insertWrittenByCommand.Parameters.AddWithValue("@authorName", Textbox_AuthorName.Text);
                    insertWrittenByCommand.ExecuteNonQuery();
                    SetBookDropDown();
                    Textbox_AuthorName.Text = "";
                    MessageBox.Show("Author information is recorded", "Information is added successfully", MessageBoxButtons.OK);
                }
                catch {
                    MessageBox.Show("Can not add information", "Error", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }
        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
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
