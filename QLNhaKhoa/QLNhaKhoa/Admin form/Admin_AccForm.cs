using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_AccForm : Form
    {
        public event EventHandler FormClosedEvent;
        public Admin_AccForm()
        {
            InitializeComponent();
        }

        private void createAccButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == "" ||
                addressBox.Text == "" ||
                phoneBox.Text == "" ||
                passwordBox.Text == "" ||
                cboEmpType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    int empType = 0;
                    if (cboEmpType.Text == "Dentist")
                    {
                        empType = 1;
                    }

                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_NHANVIEN_INS", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bdayBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@SODT", phoneBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@LOAINHANVIEN", empType));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", passwordBox.Text));
                    cmd.Parameters.Add("@MANHANVIEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                    int i = cmd.ExecuteNonQuery();
                    string user_id = (string)cmd.Parameters["@MANHANVIEN"].Value;
                    if (i > 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công! Mã của nhân viên đó là " + user_id);
                        FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thất bại!");
                    }
                    sqlCon.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tạo tài khoản thất bại! " + ex.Message);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình thêm tài khoản?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
