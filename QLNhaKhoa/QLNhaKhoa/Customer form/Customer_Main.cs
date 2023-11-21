using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    public partial class Customer_Main : Form
    {
        public Customer_Main()
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

        private void AccountButton_Click(object sender, EventArgs e)
        {
            loadform(new Customer_Account());
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            loadform(new Customer_Appointment());
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            loadform(new Customer_Record());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
