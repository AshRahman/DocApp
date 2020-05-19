using System;
using Entity;
using Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace Gui
{
    public partial class SignUpForm : Form
    {
        private SqlConnection myConnection;
        DatabaseConnectionClass dcc;
        SignUpRepo sr;

            

        public SignUpForm()
        {
            InitializeComponent();
            string conncectionString = @"Data Source=DESKTOP-R82RENG\SQLEXPRESS;Initial Catalog=DocApp;Integrated Security=True;Connect Timeout=30";
            myConnection = new SqlConnection(conncectionString);
            sr = new SignUpRepo();
        }
       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.UserPass = this.PasswordTB.Text;
                user.UserName = this.UserNameTB.Text;
                user.UserEmail = this.EmailTB.Text;
                user.PhnNumber = this.ContactTB.Text;
                if (sr.InsertUser(user))
                {
                    MessageBox.Show("Account created successfully");


                }
                else
                {
                    MessageBox.Show("Unsuccessfull");

                }


            }
            catch (Exception exp) {
                MessageBox.Show("Invalid data");
            
            }

            MessageBox.Show("Your account has been created successfully !Now you can Log into your account by using your Username and Password :) ");
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void UserIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load_1(object sender, EventArgs e)//Puts Auto generated id from SQL database to ID textbox
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(Aid as int)),0)+1 From Actors",myConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            UserIdTB.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = UserNameTB;   
        }
    }
}
