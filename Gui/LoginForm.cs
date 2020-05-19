using System;
using Entity;
using Repository;
using Interfaces;
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
    public partial class LoginForm : Form
    {
        internal LoginRepo lr;
        DatabaseConnectionClass dcc;
        public LoginForm()
        {
            InitializeComponent();
            lr = new LoginRepo();
            dcc = new DatabaseConnectionClass();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string id = UserIdTB.Text;
            string password = PasswordTB.Text;
            Login log = lr.GetUser(id, password);

            if (log != null)
            {
                if (log.IsAdmin.Equals(0))
                {
                    MessageBox.Show("UserName and Password is Correct");
                    this.Hide();
                    ManagerForm mf = new ManagerForm();
                    mf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("UserName and Password is Correct");
                    this.Hide();
                    AppForm af = new AppForm(log);
                    af.ShowDialog();

                }
            }
            else { MessageBox.Show("Invalid ID or Password,Try again"); }
        }

            private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm f2 = new SignUpForm();
            f2.ShowDialog();
        }
    }
}
