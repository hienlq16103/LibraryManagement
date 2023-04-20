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
    public partial class RemoveStudent1 : Form {
        public RemoveStudent1() {
            InitializeComponent();
            SetDropDownList();
        }
        string selectedValue = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBox1.SelectedIndex == -1) {
                return;
            }
            selectedValue = comboBox1.SelectedValue.ToString();
        }

        private void RemoveStudent1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'libraryManagementDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.libraryManagementDataSet.Student);

        }

        private void Button_RemoveStudent_Click(object sender, EventArgs e) {
            string deleteString = "DELETE FROM Student WHERE studentId = @studentId";   
            if (selectedValue == "") {
                MessageBox.Show("Please choose a student", "Invalid information", MessageBoxButtons.OK);
                return;
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString)) {
                conn.Open();
                SqlCommand cmd = new SqlCommand(deleteString, conn);
                cmd.Parameters.AddWithValue("@studentId", selectedValue);
                cmd.ExecuteNonQuery();
                conn.Close();
                SetDropDownList();
            }
        }

        private void Button_ExitButton_Click(object sender, EventArgs e) {
            this.Close();
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
        private void SetDropDownList() {
            comboBox1.DisplayMember = "studentName";
            comboBox1.ValueMember = "studentId";
            comboBox1.DataSource = GetStudentDataSet().Tables[0];
            comboBox1.SelectedIndex = -1;
            comboBox1.Refresh();
        }
    }
}
