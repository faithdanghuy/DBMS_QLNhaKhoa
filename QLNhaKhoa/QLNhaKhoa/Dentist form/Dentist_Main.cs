using QLNhaKhoa.General_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Main : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Main()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            loadform(new Account());
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            loadform(new Dentist_Services());
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            loadform(new Appointment());
        }

        private void PrecriptionButton_Click(object sender, EventArgs e)
        {
            loadform(new Dentist_Prescription());
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            loadform(new Dentist_Record());
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            loadform(new Dentist_Bill());
        }
    }
}
