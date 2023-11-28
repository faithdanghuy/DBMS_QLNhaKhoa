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
    public partial class Dentist_Appointment : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Appointment()
        {
            InitializeComponent();
        }
        private void Dentist_Appointment_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from LICHHEN where MANHASI='" + CurrentDentist + "'";
            appointmentData.DataSource = Helper.getData(appointment_query).Tables[0];
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
