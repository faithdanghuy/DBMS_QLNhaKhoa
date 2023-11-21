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
    public partial class Customer_Record : Form
    {
        public Customer_Record()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            new Customer_Account().Show();
            this.Hide();
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            new Customer_Appointment().Show();
            this.Hide();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
