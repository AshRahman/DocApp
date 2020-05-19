using Entity;
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
    public partial class ManagerForm : Form
    {
        
        
        public ManagerForm()
        {
            InitializeComponent();
            
            
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void ManageDocButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageDoctorForm f3 = new ManageDoctorForm();
            f3.ShowDialog();
        }

        private void ShowApButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowAppForm f2 = new ShowAppForm();
            f2.ShowDialog();
        }

        private void ManageAdButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAdminForm f2 = new ManageAdminForm();
            f2.ShowDialog();
        }
    }
}
