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
    public partial class ViewCopiedBook : Form {
        public ViewCopiedBook() {
            InitializeComponent();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetCopiedBookData();
        }
        DataTable GetCopiedBookData() {
            DataTable data = new DataTable();
            string id = Textbox_BookId.Text;
            string query = "SELECT B.bookId, B.title, C.copyNumber, C.availability"
                + " FROM Book AS B, CopiedBook AS C"
                + " WHERE B.bookId = C.bookId";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) {
                connection.Open();
                SqlDataAdapter adapter;
                if (id.Length != 0) {
                    query += " AND B.bookId = '" + id + "'";
                }
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
