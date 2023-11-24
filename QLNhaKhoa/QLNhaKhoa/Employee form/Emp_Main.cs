using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Main : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_Main()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Account(), this.mainPanel);
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Bill(), this.mainPanel);
        }

        private void MedRecdButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Record(), this.mainPanel);
        }

        private void MedCertButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Certificate(), this.mainPanel);
        }

        private void CusSerButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Services(), this.mainPanel);
        }

        private void PrescriptionButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Prescription(), this.mainPanel);
        }

        private void MedicationButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Medication(), this.mainPanel);
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Emp_Appointment(), this.mainPanel);
        }
    }
}
