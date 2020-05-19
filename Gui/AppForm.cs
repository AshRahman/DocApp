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
    public partial class AppForm : Form
    {
        Login log;
        UserRepo ur;
        PatientRepo pr;
        public AppForm(Login log)
        {
            InitializeComponent();
            this.log = log;
            ur = new UserRepo();
            pr = new PatientRepo();
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

       

        private void button6_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            PidTB.Text = log.Id;
        }

        private void ConfirmAppButton_Click(object sender, EventArgs e)
        {
            Appointment app = new Appointment();
            try
            {
                app.UserId = log.Id;
                app.DocId = this.DocIdTB.Text;
                app.DocName = this.DocNameTB.Text;
                app.Time = this.TimeTB.Text;

                if (pr.MakeAppointment(app))
                {
                    MessageBox.Show("Appointment made successfully");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull,Try again");
                }
            }
            catch(Exception exp) { MessageBox.Show("Invalid Data"); }

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            List<Doctor> listOfDocs = ur.GetDoctors();
            this.DoctorTable.DataSource = listOfDocs;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.DocNameTB.Text = "";
            this.DocIdTB.Text = "";
            
            this.TimeTB.Text = "";
            this.RefreshButton.Enabled = false;

        }

        private void DoctorTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DocIdTB.Text = DoctorTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DocNameTB.Text = DoctorTable.Rows[e.RowIndex].Cells[1].Value.ToString();
        
            this.TimeTB.Text = DoctorTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.RefreshButton.Enabled = true;

        }

        private void ShowAppButton_Click(object sender, EventArgs e)
        {
            List<Appointment> listOfApps = pr.GetAppointments();
            this.AppTable.DataSource = listOfApps;

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            string message = "To make an Appointment,\n \n 1.Click on the Show All button under the Doctor table.\n \n 2.Choose your desired Doctor by clicking on their name in the Doctor table. \n \n 3. Click on Confirm Appointment to make the appointment. \n \n [To see your serial click on Show Appointments under Appointments table]  ";
            string title = "Help";
            MessageBoxButtons butt = MessageBoxButtons.OK;

            MessageBox.Show(message,title, butt, MessageBoxIcon.Question);
        }
    }
}
