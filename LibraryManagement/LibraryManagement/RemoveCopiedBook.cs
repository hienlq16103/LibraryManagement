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
    public partial class RemoveCopiedBook : Form {

        string bookId = "";
        string copyNumber = "";

        public RemoveCopiedBook() {
            InitializeComponent();
            SetBookDropDown();
            Combobox_CopyNumber.DataSource = null;
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
            SetCobyBookDropDown();
        }

        private void Combobox_AuthorName_SelectedIndexChanged(object sender, EventArgs e) {
            if (Combobox_CopyNumber.SelectedIndex == -1) {
                return;
            }
            if (Combobox_CopyNumber.SelectedValue == null) {
                return;
            }
            copyNumber = Combobox_CopyNumber.SelectedValue.ToString();
        }

        private void Button_RemoveCopiedBook_Click(object sender, EventArgs e) {
            string deleteString = "DELETE FROM CopiedBook WHERE bookId = @bookId AND copyNumber = @copyNumber";
            if (bookId == "" || Combobox_BookName.SelectedValue == null) {
                MessageBox.Show("Please choose a book", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (copyNumber == "" || Combobox_CopyNumber.SelectedValue == null) {
                MessageBox.Show("Please choose a copy number", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.Parameters.AddWithValue("@bookId", bookId);
                cmd.Parameters.AddWithValue("@copyNumber", copyNumber);
                cmd.ExecuteNonQuery();
                conn.Close();
                SetBookDropDown();
                Combobox_CopyNumber.DataSource = null;
            }
            MessageBox.Show("Successfully removed a copy book", "Remove success", MessageBoxButtons.OK);
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
            string queryString = "SELECT DISTINCT B.bookId, title FROM Book AS B, CopiedBook AS C"
                + " WHERE B.bookId = C.bookId";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(queryString, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        private void SetCobyBookDropDown() {
            Combobox_CopyNumber.DisplayMember = "copyNumber";
            Combobox_CopyNumber.ValueMember = "copyNumber";
            Combobox_CopyNumber.DataSource = GetCopyBookDataSet().Tables[0];
            Combobox_CopyNumber.SelectedIndex = -1;
            Combobox_CopyNumber.Refresh();
        }
        private DataSet GetCopyBookDataSet() {
            DataSet data = new DataSet();
            string queryString = "SELECT copyNumber FROM CopiedBook"
                + " WHERE bookId = '" + bookId + "'" + " AND availability = 1";
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
