using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.General_form
{
    public partial class Appointment : Form
    {
        public string CurrentUser { get; set; } = string.Empty;

        public Appointment()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet getData(string query)
        {
            SqlConnection sqlCon = new SqlConnection(ConnectionString.strCon);
            sqlCon.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter ap = new SqlDataAdapter(query, sqlCon);
            ap.Fill(dt);
            sqlCon.Close();
            return dt;
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from LICHHEN where MAKHACHHANG='" + CurrentUser + "'";
            string dentist_query = "select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1";

            appointmentData.DataSource = getData(appointment_query).Tables[0];
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            cboDentists.DataSource = getData(dentist_query).Tables[0];
            cboDentists.DisplayMember = "HOTEN";
            cboDentists.ValueMember = "MANHANVIEN";
        }
    }
}
