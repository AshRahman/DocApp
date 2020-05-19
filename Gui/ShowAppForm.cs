using System;
using Entity;
using Repository;
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
    public partial class ShowAppForm : Form
    {
        PatientRepo pr;
        public ShowAppForm()
        {
            InitializeComponent();
            pr= new PatientRepo();
        }

        private void ManagePatientForm_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowApp_Click(object sender, EventArgs e)
        {
            List<Appointment> listOfApps = pr.GetAppointments();
            this.AppTable.DataSource = listOfApps;
        }
    }
}
