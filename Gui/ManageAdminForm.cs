using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class ManageAdminForm : Form
    {
        UserRepo ur;

        public ManageAdminForm()
        {
            InitializeComponent();
            ur = new UserRepo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void ManageAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            List<User> listofUsers = ur.GetUsers();
            this.AdminTable.DataSource = listofUsers;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.UserName = NameTB.Text;
                user.UserPass = PasswordTB.Text;
                user.UserEmail = EmailTB.Text;
                user.PhnNumber = ContactTB.Text;
                if (ur.InsertUser(user))
                {
                    MessageBox.Show("Admin added successfully");
                    this.NameTB.Text="";
                    this.PasswordTB.Text="";
                    this.EmailTB.Text="";
                    this.ContactTB.Text="";

                }
                else
                {
                    MessageBox.Show("Failed to add Admin");
                }



            }
            catch (Exception exp) { MessageBox.Show("Invalid Data"); }
        }

        private void BackButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm f2 = new ManagerForm();
            f2.ShowDialog();
        }
    }
}
