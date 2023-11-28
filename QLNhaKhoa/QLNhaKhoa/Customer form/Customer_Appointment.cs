namespace QLNhaKhoa.General_form
{
    public partial class Customer_Appointment : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public Customer_Appointment()
        {
            InitializeComponent();
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from LICHHEN where MAKHACHHANG='" + CurrentUser + "'";
            string dentist_query = "select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1";
            appointmentData.DataSource = Helper.getData(appointment_query).Tables[0];
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboDentists.DataSource = Helper.getData(dentist_query).Tables[0];
            cboDentists.DisplayMember = "HOTEN";
            cboDentists.ValueMember = "MANHANVIEN";
        }

        private void appointmentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
