using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.ActiveControl = txtName;
            txtName.Focus();
        }
        private void loginSwap_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
                txtBday.Text == "" ||
                txtAddress.Text == "" ||
                txtPhone.Text == "" ||
                txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_KHACHHANG_INS", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@HOTEN", txtName.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYSINH", txtBday.Text));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", txtAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("@SODT", txtPhone.Text));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPassword.Text));

                    cmd.Parameters.Add("@MAKHACHHANG", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                    int i = cmd.ExecuteNonQuery();
                    string userID = (string)cmd.Parameters["@MAKHACHHANG"].Value;
                    sqlCon.Close();
                    if (i > 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công! Mã khách hàng của bạn là " + userID);
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản thất bại!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Tạo tài khoản thất bại!");
                }
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtBday.Focus();
            }
        }
        private void txtBday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtAddress.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtName.Focus();
            }
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtPhone.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtBday.Focus();
            }
        }
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtAddress.Focus();
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                registerButton.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                registerButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtPhone.Focus();
            }
        }
    }
}