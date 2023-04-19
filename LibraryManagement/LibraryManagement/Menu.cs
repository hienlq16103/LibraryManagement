using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign() {
            Panel_Book.Visible = false;
            Panel_Student.Visible = false;
            Panel_Loan.Visible = false;
        }
        private void HideSubMenus() {
            if (Panel_Book.Visible== true) {
                Panel_Book.Visible = false;
            }
            if (Panel_Student.Visible == true) {
                Panel_Student.Visible = false;
            }
            if (Panel_Loan.Visible == true) {
                Panel_Loan.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                HideSubMenus();
                subMenu.Visible = true;
            } else {
                subMenu.Visible = false;    
            }
        }

        private void Button_Book_Click(object sender, EventArgs e) {
            //ShowSubMenu(Panel_Book);
        }

        private void Button_ViewBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_ViewCopiedBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_AddBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_AddCopiedBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_RemoveBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_RemoveCopiedBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_ViewStudent_Click(object sender, EventArgs e) {
            OpenChildForm(new ViewStudent());
            HideSubMenus();
        }

        private void Button_AddStudent_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_RemoveStudent_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_BorrowBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_ReturnBook_Click(object sender, EventArgs e) {
            //Code to implement ...
            HideSubMenus();
        }

        private void Button_Student_Click(object sender, EventArgs e) {
            //ShowSubMenu(Panel_Student);
        }

        private void Button_Loan_Click(object sender, EventArgs e) {
            //ShowSubMenu(Panel_Loan);
        }

        private void Button_Loan_Click_1(object sender, EventArgs e) {
            ShowSubMenu(Panel_Loan);
        }

        private void Button_Book_Click_1(object sender, EventArgs e) {
            ShowSubMenu(Panel_Book);
        }

        private void Button_Student_Click_1(object sender, EventArgs e) {
            ShowSubMenu(Panel_Student);
        }
        private Form activeForm = null;
        private void OpenChildForm(Form childForm) {
            if (activeForm != null) {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_Container.Controls.Add(childForm);
            Panel_Container.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
