using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Main : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Dentist_Main()
        {
            InitializeComponent();
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Services(), this.mainPanel);
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Dentist_Appointment f = new Dentist_Appointment();
            f.CurrentDentist = CurrentDentist;
            Helper.loadform(f, this.mainPanel);
        }

        private void PrecriptionButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Prescription(), this.mainPanel);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Record(), this.mainPanel);
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Certificate(), this.mainPanel);
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Dentist_Main_Load(object sender, EventArgs e)
        {
            DentistID.Text = CurrentDentist;
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN = '" + CurrentDentist + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dentistName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }
    }
}
