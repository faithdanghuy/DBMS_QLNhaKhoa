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
    public partial class Dentist_Appointment : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Appointment()
        {
            InitializeComponent();
        }
        private void Dentist_Appointment_Load(object sender, EventArgs e)
        {
            string appointment_query = "select * from LICHHEN where MANHASI='" + CurrentDentist + "'";
            appointmentData.DataSource = Helper.getData(appointment_query).Tables[0];
        }
        private void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = appointmentData.Rows[e.RowIndex];
                string time_str = dgvr.Cells["GIO"].Value.ToString();
                if (time_str.All(char.IsDigit))
                {
                    int time = int.Parse(time_str);
                    int hour = time / 60;
                    int minutes = time - hour * 60;
                    timeBox.Text = hour + ":" + minutes;
                    dateBox.Text = dgvr.Cells["NGAY"].Value.ToString();
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = timeBox.Text.Split(":");
                int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
                if (time < 480 || time > 1020)
                {
                    MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
                }

                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_LICHHEN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add(new SqlParameter("@MALICHHEN", appointDate.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAY", dateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIO", time));
                //cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", CurrentUser));
                cmd.Parameters.Add(new SqlParameter("@MANHASI", CurrentDentist));
                cmd.Parameters.Add(new SqlParameter("@NGUOIUPDATE", CurrentDentist));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Đặt lịch hẹn thành công");
                }
                else
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại!");
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật lịch hẹn thất bại! " + ex.Message);
            }
        }
    }
}
