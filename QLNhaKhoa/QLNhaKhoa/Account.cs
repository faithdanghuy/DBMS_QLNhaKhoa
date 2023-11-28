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
        public void updateProfile()
        {
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("USP_KHACHHANG_UPD", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;

            DateTime bday = DateTime.ParseExact(bdayBox.Text, "yyyy-MM-dd", null);

            cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", CurrentUser));
            cmd.Parameters.Add(new SqlParameter("@HOTEN", nameBox.Text));
            cmd.Parameters.Add(new SqlParameter("@NGAYSINH", bday));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", addressBox.Text));
            cmd.Parameters.Add(new SqlParameter("@SODT", phoneBox.Text));
            cmd.Parameters.Add(new SqlParameter("@MATKHAU", passwordBox.Text));
            int i = cmd.ExecuteNonQuery();
            sqlCon.Close();
            if (i > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            updateProfile();
        }
        private void Account_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN,NGAYSINH,DIACHI,SODT from KHACHHANG where MAKHACHHANG='" + CurrentUser + "'", sqlCon);
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
    }
}
