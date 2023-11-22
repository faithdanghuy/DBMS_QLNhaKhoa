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

        private void Appointment_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=HUY;Initial Catalog=Nhom3_QLNhaKhoa;Integrated Security=True;TrustServerCertificate=True");
            sqlCon.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter ap = new SqlDataAdapter("select * from LICHHEN where MAKHACHHANG='" + CurrentUser + "'", sqlCon);
            ap.Fill(dt);
            sqlCon.Close();

            appointmentData.DataSource = dt;
        }
    }
}
