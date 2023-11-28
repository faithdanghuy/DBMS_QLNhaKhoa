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
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_KHACHHANG_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@HOTEN", txtName.Text));
                cmd.Parameters.AddWithValue("@NGAYSINH", txtBday.Text);
                cmd.Parameters.Add(new SqlParameter("@DIACHI", txtAddress.Text));
                cmd.Parameters.Add(new SqlParameter("@SODT", txtPhone.Text));
                cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPassword.Text));

                cmd.Parameters.Add("@MAKHACHHANG", SqlDbType.Int).Direction = ParameterDirection.Output;
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
            catch (Exception ex)
            {
                MessageBox.Show("Tạo tài khoản thất bại!" + ex);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}