using System;
using Entity;
using Repository;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class ManageDoctorForm : Form
    {
        private SqlConnection myConnection;
        UserRepo ur;
        public ManageDoctorForm()
        {
            InitializeComponent();
            string conncectionString = @"Data Source=DESKTOP-R82RENG\SQLEXPRESS;Initial Catalog=DocApp;Integrated Security=True;Connect Timeout=30";
            myConnection = new SqlConnection(conncectionString);
            ur = new UserRepo();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            ManagerForm f2 = new ManagerForm();
            f2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void ManageDoctorForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(Did as int)),0)+1 From Doctor", myConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DocIdTB.Text = dt.Rows[0][0].ToString();
            this.ActiveControl = DocIdTB;

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            List<Doctor> listOfDocs = ur.GetDoctors();
            this.DoctorTable.DataSource = listOfDocs;

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            try
            {
                doc.DocName = this.DocName.Text;
                doc.DocEmail = this.DocEmail.Text;
                doc.Specialist = this.SpecialistTB.Text;
                doc.Time = this.TimeTB.Text;

                if (ur.InsertDoctor(doc))
                {
                    MessageBox.Show("Doctor Added");
                    this.ShowButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Can not add Doctor");
                }
            }
            catch (Exception exp) {
                MessageBox.Show("Invalid Data");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Doctor doc = new Doctor();
            doc.DocId = this.DocIdTB.Text;
            if (ur.DeleteDoctor(doc))
            {
                MessageBox.Show("Deleted");
                this.ShowButton_Click(sender, e);

            }
            else {
                MessageBox.Show("Can not Delete");
                
            }

        }
    }
}
