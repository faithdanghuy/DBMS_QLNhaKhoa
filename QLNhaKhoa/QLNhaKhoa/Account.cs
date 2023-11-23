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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void updateProfile()
        {
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("USP_KHACHHANG_UPD", sqlCon);
            cmd.Parameters.AddWithValue("@MAKHACHHANG", CurrentUser);
            cmd.Parameters.AddWithValue("@NGAYSINH", bdayBox.Text);
            cmd.Parameters.AddWithValue("@DIACHI", addressBox.Text);
            cmd.Parameters.AddWithValue("@SODT", phoneBox.Text);
            cmd.Parameters.AddWithValue("@MATKHAU", CurrentPass);
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
                    nameBox.Text = reader["HOTEN"].ToString();
                    bdayBox.Text = reader["NGAYSINH"].ToString();
                    addressBox.Text = reader["DIACHI"].ToString();
                    phoneBox.Text = reader["SODT"].ToString();
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
