using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.General_form
{
    public partial class Account : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public Account()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(ConnectionString.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("USP_READ_KHACHHANG", sqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAKH", CurrentUser));
            using(SqlDataReader reader = cmd.ExecuteReader())
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
                    MessageBox.Show("No Data Found!");
                }
            }
        }
    }
}
