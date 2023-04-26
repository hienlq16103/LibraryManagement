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
    public partial class RemoveBook : Form {

        string bookId = "";

        public RemoveBook() {
            InitializeComponent();
            SetBookDropDown();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == -1) {
                return;
            }
            if (comboBox1.SelectedValue == null) {
                return;
            }
            bookId = comboBox1.SelectedValue.ToString();
        }

        private void Button_RemoveStudent_Click(object sender, EventArgs e) {
            string deleteLoanQuery = "DELETE FROM Loan WHERE bookId = @bookId";
            string deleteWrittenByQuery = "DELETE FROM WrittenBy WHERE bookId = @bookId";
            string deleteCopiedBookQuery = "DELETE FROM CopiedBook WHERE bookId = @bookId";
            string deleteBookQuery = "DELETE FROM Book WHERE bookId = @bookId";
            if (bookId == "" || comboBox1.SelectedValue == null) {
                MessageBox.Show("Please choose a book", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                SqlCommand deleteLoanCommand = new SqlCommand(deleteLoanQuery, conn);
                SqlCommand deleteWrittenByCommand = new SqlCommand(deleteWrittenByQuery, conn);
                SqlCommand deleteCopiedBookCommand = new SqlCommand(deleteCopiedBookQuery, conn);
                SqlCommand deleteBookCommand = new SqlCommand(deleteBookQuery, conn);

                deleteLoanCommand.Parameters.AddWithValue("@bookId", bookId);
                deleteWrittenByCommand.Parameters.AddWithValue("@bookId", bookId);
                deleteCopiedBookCommand.Parameters.AddWithValue("@bookId", bookId);
                deleteBookCommand.Parameters.AddWithValue("@bookId", bookId);

                deleteLoanCommand.ExecuteNonQuery();
                deleteWrittenByCommand.ExecuteNonQuery();
                deleteCopiedBookCommand.ExecuteNonQuery();
                deleteBookCommand.ExecuteNonQuery();
                conn.Close();
                SetBookDropDown();
            }
            MessageBox.Show("Successfully removed a member", "Remove success", MessageBoxButtons.OK);
        }
        private void SetBookDropDown() {
            comboBox1.DisplayMember = "title";
            comboBox1.ValueMember = "bookId";
            comboBox1.DataSource = GetBookDataSet().Tables[0];
            comboBox1.SelectedIndex = -1;
            comboBox1.Refresh();
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
