using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Customer_form
{
    public partial class Customer_AppForm : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public event EventHandler FormClosedEvent;
        public Customer_AppForm()
        {
            InitializeComponent();
        }

        private void Customer_AppForm_Load(object sender, EventArgs e)
        {
            cboDentists.DisplayMember = "HOTEN";
            cboDentists.ValueMember = "MANHANVIEN";
            cboDentists.DataSource = Helper.getData("select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1").Tables[0];
        }

        private void makeAppButton_Click(object sender, EventArgs e)
        {
            string[] parts = appointTime.Text.Split(":");
            int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
            if (time < 480 || time > 1020)
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

                    var item = (DataRowView)cboDentists.SelectedItem;
                    cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIO", time));
                    cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", CurrentUser));
                    cmd.Parameters.Add(new SqlParameter("@MANHASI", item["MANHANVIEN"].ToString()));
                    cmd.Parameters.Add("@MALICHHEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Đặt lịch hẹn thành công");
                        FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Đặt lịch hẹn thất bại!");
                    }
                    sqlCon.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại! " + ex.Message);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình đặt lịch hẹn?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
