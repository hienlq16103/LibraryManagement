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
    public partial class BorrowBook : Form {

        string bookId = "";
        string copyNumber = "";
        string studentId = "";
        DateTime loanDate;
        DateTime dueDate;

        public BorrowBook() {
            InitializeComponent();
            SetStudentDropDown();
            SetBookDropDown();
            Combobox_CopyNumber.DataSource = null;
            loanDate = LoanDate.Value;
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
        private void Combobox_StudentName_SelectedIndexChanged(object sender, EventArgs e) {
            if (Combobox_StudentName.SelectedIndex == -1) {
                return;
            }
            if (Combobox_StudentName.SelectedValue == null) {
                return;
            }
            studentId = Combobox_StudentName.SelectedValue.ToString();

        }
        private void Combobox_CopyNumber_SelectedIndexChanged(object sender, EventArgs e) {
            if (Combobox_CopyNumber.SelectedIndex == -1) {
                return;
            }
            if (Combobox_CopyNumber.SelectedValue == null) {
                return;
            }
            copyNumber = Combobox_CopyNumber.SelectedValue.ToString();
        }
        private void LoanDate_ValueChanged(object sender, EventArgs e) {
            loanDate = LoanDate.Value;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
            dueDate = dateTimePicker1.Value;
        }
        private void Button_Add_Click(object sender, EventArgs e) {
            string insertString = 
                "INSERT INTO Loan VALUES (@bookId,@copyNumber,@studentId,@loanDate,@dueDate)";
            string updateString = "UPDATE CopiedBook SET availability = 0 WHERE bookId = @bookId " +
                "AND copyNumber = @copyNumber";
            if (bookId == "" || Combobox_BookName.SelectedValue == null) {
                MessageBox.Show("Please choose a book", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (copyNumber == "" || Combobox_CopyNumber.SelectedValue == null) {
                MessageBox.Show("Please choose a copy number", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (studentId == "" || Combobox_StudentName.SelectedValue == null) {
                MessageBox.Show("Please choose a student", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            if (loanDate == dueDate)  {
                MessageBox.Show("Please choose a valid due date", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                try {
                    SqlCommand insertCommand = new SqlCommand(insertString, conn);
                    insertCommand.Parameters.AddWithValue("@bookId", bookId);
                    insertCommand.Parameters.AddWithValue("@copyNumber", copyNumber);
                    insertCommand.Parameters.AddWithValue("@studentId", studentId);
                    insertCommand.Parameters.AddWithValue("@loanDate", loanDate);
                    insertCommand.Parameters.AddWithValue("@dueDate", dueDate);
                    insertCommand.ExecuteNonQuery();
                    SqlCommand updateCommand = new SqlCommand(updateString, conn);
                    updateCommand.Parameters.AddWithValue("@bookId", bookId);
                    updateCommand.Parameters.AddWithValue("@copyNumber", copyNumber);
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("A new loan is recorded", "Book borrowed successfully", MessageBoxButtons.OK);
                }
                catch {
                    MessageBox.Show("Can not add information", "Error", MessageBoxButtons.OK);
                }
                conn.Close();
            }
        }
        private void SetStudentDropDown() {
            Combobox_StudentName.DisplayMember = "studentName";
            Combobox_StudentName.ValueMember = "studentId";
            Combobox_StudentName.DataSource = GetStudentDataSet().Tables[0];
            Combobox_StudentName.SelectedIndex = -1;
            Combobox_StudentName.Refresh();
        }
        private DataSet GetStudentDataSet() {
            DataSet data = new DataSet();
            string queryString = "SELECT studentId, studentName FROM Student";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString)) {
                connection.Open();
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(queryString, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
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
            string queryString = "SELECT DISTINCT B.bookId, B.title FROM Book AS B, CopiedBook AS C"
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
