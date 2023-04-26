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
    public partial class ViewBook : Form {
        public ViewBook() {
            InitializeComponent();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.DataSource = GetBookData();
        }

        string id = "";
        DataTable GetBookData() {
            DataTable data = new DataTable();
            string id = Textbox_BookId.Text;
            string query = "SELECT B.bookId, title, authorName, publisher, yearOfPublication"
                + " FROM Book AS B" +
                " LEFT JOIN WrittenBy AS W" +
                " ON B.bookId = W.bookId";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) {
                connection.Open();
                SqlDataAdapter adapter;
                if (id.Length != 0) {
                    query += " WHERE B.bookId = '" + id + "'";
                }
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
