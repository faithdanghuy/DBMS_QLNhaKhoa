using System.Data.SqlClient;

namespace QLNhaKhoa
{
    public partial class Customer_Record : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public Customer_Record()
        {
            InitializeComponent();
        }
        private void Customer_Record_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(Helper.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT KH.HOTEN, KH.NGAYSINH, KH.DIACHI, KH.SODT, NV.MANHANVIEN, NV.HOTEN AS TENNHASI " +
                                            "FROM KHACHHANG KH JOIN HOSOBENHAN HSBA ON KH.MAKHACHHANG = HSBA.MAKHACHHANG JOIN NHANVIEN NV ON HSBA.MANHASI = NV.MANHANVIEN " +
                                            "WHERE NV.LOAINHANVIEN = 1 AND KH.MAKHACHHANG = '" + CurrentUser + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    customerIDBox.Text = CurrentUser;
                    customerNameBox.Text = reader["HOTEN"].ToString();
                    bdayBox.Text = reader["NGAYSINH"].ToString();
                    addressBox.Text = reader["DIACHI"].ToString();
                    phoneBox.Text = reader["SODT"].ToString();
                    dentistIDBox.Text = reader["MANHANVIEN"].ToString();
                    dentistNameBox.Text = reader["TENNHASI"].ToString();
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
