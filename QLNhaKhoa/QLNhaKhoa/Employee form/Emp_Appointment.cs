using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Appointment : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_Appointment()
        {
            InitializeComponent();
        }

        private void Emp_Appointment_Load(object sender, EventArgs e)
        {
            appointmentData.DataSource = Helper.getData("select * from LICHHEN").Tables[0];

            cboCustomer.DisplayMember = "HOTEN";
            cboCustomer.ValueMember = "MAKHACHHANG";
            cboCustomer.DataSource = Helper.getData("select HOTEN, MAKHACHHANG from KHACHHANG").Tables[0];

            cboDentist.DisplayMember = "HOTEN";
            cboDentist.ValueMember = "MANHANVIEN";
            cboDentist.DataSource = Helper.getData("select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1").Tables[0];
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from LICHHEN", appointmentData);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            (appointmentData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MALICHHEN like '%" + searchIDBox.Text + "%'");
        }

        private void makeAppButton_Click(object sender, EventArgs e)
        {
            try
            {
           
                string[] parts = timeBox.Text.Split(":");
                int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
                if (time < 480 || time > 1020)
                {
                    MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
                }
                var itemD = (DataRowView)cboDentist.SelectedItem;
                var itemC = (DataRowView)cboCustomer.SelectedItem;
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_LICHHEN_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NGAY", dateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIO", time));
                cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", itemC["MAKHACHHANG"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MANHASI", itemD["MANHANVIEN"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MANVDATLICH", CurrentEmp.Trim()));

                cmd.Parameters.Add("@MALICHHEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Lập hóa đơn thành công!");
                }
                else
                {
                    MessageBox.Show("Lập hóa đơn thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lập hóa đơn thất bại! " + ex.Message);
            }
        }
    }
}
