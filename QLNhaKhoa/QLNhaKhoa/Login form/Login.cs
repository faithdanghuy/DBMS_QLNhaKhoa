using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerSwap_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Enter your ID");
            }
            else if(txtPassword.Text == "")
            {
                MessageBox.Show("Enter you password");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection("Data Source=HUY;Initial Catalog=Nhom3_QLNhaKhoa;Integrated Security=True;TrustServerCertificate=True");
                    SqlCommand cmd = new SqlCommand("select * from KHACHHANG where MAKHACHHANG = @username and MATKHAU = @password", sqlCon);
                    cmd.Parameters.AddWithValue("@username", txtID.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if(dt.Rows.Count > 0) 
                    {
                        this.Hide();
                        new Customer_Main().Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is invalid!");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}