using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace QLNhaKhoa.General_form
{
    public partial class Customer_Appointment : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public Customer_Appointment()
        {
            InitializeComponent();
        }
        private void appointTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'h' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            if (appointTime.Text.Length == 0 && e.KeyChar == 'h')
            {
                e.Handled = true;
            }
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from LICHHEN where MAKHACHHANG='" + CurrentUser + "'";
            string dentist_query = "select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1";
            appointmentData.DataSource = Helper.getData(appointment_query).Tables[0];

            cboDentists.DataSource = Helper.getData(dentist_query).Tables[0];
            cboDentists.DisplayMember = "HOTEN";
            cboDentists.ValueMember = "MANHANVIEN";
        }
        private void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != appointmentData.Rows.Count + 1)
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                DataGridViewRow dgvr = appointmentData.Rows[e.RowIndex];

                int time = int.Parse(dgvr.Cells["GIO"].Value.ToString());
                int hour = time / 60;
                int minutes = time - hour * 60;
                appointTime.Text = hour + "h" + minutes;

                appointDate.Text = dgvr.Cells["NGAY"].Value.ToString();

                SqlCommand cmd = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN='" + dgvr.Cells["MANHASI"].Value.ToString() + "'", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();
                cboDentists.Text = reader["HOTEN"].ToString();
                sqlCon.Close();
            }
        }
        private void makeAppointBtn_Click(object sender, EventArgs e)
        {
            appointmentData.Rows.Add();
            string[] parts = appointTime.Text.Split("h");
            int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
            if(time < 480 || time > 1020)
            {
                MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_LICHHEN_INS", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIO", time));
                    cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", CurrentUser));
                    cmd.Parameters.Add(new SqlParameter("@MANHASI", cboDentists.ValueMember));
                    cmd.Parameters.Add(new SqlParameter("@MANHANVIENDATLICH", String.Empty));

                    cmd.Parameters.Add("@MALICHHEN", SqlDbType.VarChar, 5).Direction = ParameterDirection.Output;
                    sqlCon.Close();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Đặt lịch hẹn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đặt lịch hẹn thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại!" + ex.Message);
                }
            }
        }
    }
}
