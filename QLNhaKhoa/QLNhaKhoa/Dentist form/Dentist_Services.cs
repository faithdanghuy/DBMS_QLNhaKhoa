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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet getData(string query)
        {
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter ap = new SqlDataAdapter(query, sqlCon);
            ap.Fill(dt);
            sqlCon.Close();
            return dt;
        }
        private void Dentist_Services_Load(object sender, EventArgs e)
        {
            string appointment_query = "select DVK.MADICHVU, DVK.TENDICHVU from DICHVUSUDUNG DVSD JOIN DICHVUKHAM DVK ON DVSD.MADICHVU = DVK.MADICHVU";
            string service_query = "select MADICHVU, TENDICHVU from DICHVUKHAM";

            serviceData.DataSource = getData(appointment_query).Tables[0];
            serviceData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboService.DataSource = getData(service_query).Tables[0];
            cboService.DisplayMember = "TENDICHVU";
            cboService.ValueMember = "MADICHVU";
        }
    }
}
