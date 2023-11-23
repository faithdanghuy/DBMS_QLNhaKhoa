namespace QLNhaKhoa.General_form
{
    public partial class Appointment : Form
    {
        public static string CurrentUser { get; set; } = string.Empty;
        private static string appointment_query = "select * from LICHHEN where MAKHACHHANG='" + CurrentUser + "'";
        private static string dentist_query = "select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1";
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
            appointmentData.DataSource = Helper.getData(appointment_query).Tables[0];
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboDentists.DataSource = Helper.getData(dentist_query).Tables[0];
            cboDentists.DisplayMember = "HOTEN";
            cboDentists.ValueMember = "MANHANVIEN";
        }
    }
}
