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
    public partial class ViewCurrentLoan : Form {
        public ViewCurrentLoan() {
            InitializeComponent();
            LoadDataGridView();
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            LoadDataGridView();
        }
        private void LoadDataGridView() {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetCurrentLoan();
        }
        private DataTable GetCurrentLoan() {
            DataTable data = new DataTable();
            string query = "SELECT L.bookId, copyNumber, title, L.studentId, S.studentName, loanDate, dueDate "
                + "FROM Loan AS L, Book AS B, Student AS S "
                + "WHERE L.bookId = B.bookId AND L.studentId = S.studentId";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
