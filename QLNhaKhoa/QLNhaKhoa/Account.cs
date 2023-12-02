using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNhaKhoa
{
    public partial class Account : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Account()
        {
            InitializeComponent();
        }
        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Account_Load(object sender, EventArgs e)
        {
            string query = "select HOTEN,NGAYSINH,DIACHI,SODT from NHANVIEN where MANHANVIEN='" + CurrentUser + "'";
            if (CurrentUser.StartsWith("KH"))
            {
                query = "select HOTEN,NGAYSINH,DIACHI,SODT from KHACHHANG where MAKHACHHANG='" + CurrentUser + "'";
            }
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand(query, sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    bdayBox.Text = reader["NGAYSINH"].ToString();
                    nameBox.Text = reader["HOTEN"].ToString();
                    addressBox.Text = reader["DIACHI"].ToString();
                    phoneBox.Text = reader["SODT"].ToString();
                    passwordBox.Text = CurrentPass;
                    sqlCon.Close();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu!");
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            string procedure = "USP_NHANVIEN_UPD";
            string parameter = "@MANHANVIEN";

            if (CurrentUser.Trim().StartsWith("KH"))
            {
                procedure = "USP_KHACHHANG_UPD";
                parameter = "@MAKHACHHANG";
            }
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(procedure, sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter(parameter, CurrentUser));
                cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SODT", phoneBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MATKHAU", passwordBox.Text));

                if (CurrentUser.Trim().StartsWith("NV"))
                {
                    cmd.Parameters.Add(new SqlParameter("@LOAINHANVIEN", 0));
                }
                else if (CurrentUser.Trim().StartsWith("NS"))
                {
                    cmd.Parameters.Add(new SqlParameter("@LOAINHANVIEN", 1));
                }
                else if (CurrentUser.Trim().StartsWith("AD"))
                {
                    cmd.Parameters.Add(new SqlParameter("@LOAINHANVIEN", 2));
                }
                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại! " + ex.Message);
            }
        }
    }
}
