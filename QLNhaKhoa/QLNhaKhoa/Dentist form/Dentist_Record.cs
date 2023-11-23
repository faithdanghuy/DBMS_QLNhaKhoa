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
    public partial class Dentist_Record : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Record()
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
        private void Dentist_Record_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from HOSOBENHAN where MANHASI='" + CurrentDentist + "'";

            recordData.DataSource = getData(appointment_query).Tables[0];
            recordData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
