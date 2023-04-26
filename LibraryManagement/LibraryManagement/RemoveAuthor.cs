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
    public partial class RemoveAuthor : Form {

        string bookId = "";
        string authorName = "";

        public RemoveAuthor() {
            InitializeComponent();
            SetBookDropDown();
            Combobox_AuthorName.DataSource = null;
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Button_RemoveStudent_Click(object sender, EventArgs e) {
            string deleteWrittenbyString = "DELETE FROM Writtenby" +
                " WHERE bookId = @bookId AND authorName = @authorName";
            string deleteAuthorString = "DELETE FROM Author" +
                " WHERE authorName = @authorName";
            if (bookId == "" || Combobox_BookName.SelectedValue == null) {
                MessageBox.Show("Please choose a book", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (authorName == "" || Combobox_AuthorName.SelectedValue == null) {
                MessageBox.Show("Please choose an author", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                SqlCommand deleteWrittenBy = new SqlCommand(deleteWrittenbyString, conn);
                SqlCommand deleteAuthor = new SqlCommand(deleteAuthorString, conn);
                deleteWrittenBy.Parameters.AddWithValue("@bookId", bookId);
                deleteWrittenBy.Parameters.AddWithValue("@authorName", authorName);
                deleteAuthor.Parameters.AddWithValue("@authorName", authorName);
                deleteWrittenBy.ExecuteNonQuery();
                deleteAuthor.ExecuteNonQuery();
                conn.Close();
                SetBookDropDown();
                Combobox_AuthorName.DataSource = null;
            }
            MessageBox.Show("Successfully remove an author", "Remove success", MessageBoxButtons.OK);
        }

        private void Combobox_BookName_SelectedIndexChanged(object sender, EventArgs e) {
            if (Combobox_BookName.SelectedIndex == -1) {
                return;
            }
            if (Combobox_BookName.SelectedValue == null) {
                return;
            }
            bookId = Combobox_BookName.SelectedValue.ToString();
            SetAuthorDropDown();
        }

        private void Combobox_AuthorName_SelectedIndexChanged(object sender, EventArgs e) {
            if (Combobox_AuthorName.SelectedIndex == -1) {
                return;
            }
            if (Combobox_AuthorName.SelectedValue == null) {
                return;
            }
            authorName = Combobox_AuthorName.SelectedValue.ToString();
        }
        private void SetBookDropDown() {
            Combobox_BookName.DisplayMember = "title";
            Combobox_BookName.ValueMember = "B.bookId";
            Combobox_BookName.DataSource = GetBookDataSet().Tables[0];
            Combobox_BookName.SelectedIndex = -1;
            Combobox_BookName.Refresh();
        }
        private DataSet GetBookDataSet() {
            DataSet data = new DataSet();
            string queryString = "SELECT DISTINCT B.bookId, title FROM Book AS B, WrittenBy AS W"
                + " WHERE B.bookId = W.bookId";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(queryString, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private void SetAuthorDropDown() {
            Combobox_AuthorName.DisplayMember = "authorName";
            Combobox_AuthorName.ValueMember = "authorName";
            Combobox_AuthorName.DataSource = GetAuthorDataSet().Tables[0];
            Combobox_AuthorName.SelectedIndex = -1;
            Combobox_AuthorName.Refresh();
        }
        private DataSet GetAuthorDataSet() {
            DataSet data = new DataSet();
            string queryString = "SELECT authorName FROM WrittenBy"
                + " WHERE bookId = '" + bookId + "'"; 
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
