using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Services : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Services()
        {
            InitializeComponent();
        }
        private void Dentist_Services_Load(object sender, EventArgs e)
        {
            string appointment_query = "select DVK.MADICHVU, DVK.TENDICHVU from DICHVUSUDUNG DVSD JOIN DICHVUKHAM DVK ON DVSD.MADICHVU = DVK.MADICHVU";
            string service_query = "select MADICHVU, TENDICHVU from DICHVUKHAM";

            serviceData.DataSource = Helper.getData(appointment_query).Tables[0];

            cboService.DisplayMember = "TENDICHVU";
            cboService.ValueMember = "MADICHVU";
            cboService.DataSource = Helper.getData(service_query).Tables[0];
        }
    }
}
