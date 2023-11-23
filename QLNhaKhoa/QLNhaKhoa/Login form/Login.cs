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
            this.ActiveControl = txtID;
            txtID.Focus();
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
            if (txtID.Text == "")
            {
                MessageBox.Show("Enter your ID");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Enter you password");
            }
            else
            {
                try
                {
                    /*int userType = 3;
                    SqlConnection sqlCon = new SqlConnection(ConnectionString.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_MISC_LOGIN", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAUSER", txtID.Text));
                    cmd.Parameters.Add(new SqlParameter("@MATKHAU", txtPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@LOAIUSER", userType));
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            if(r.GetInt16(0) == -1)
                            {
                                Customer_Main f = new Customer_Main();
                                f.CurrentUser = txtID.Text;
                                f.Show();
                                this.Hide();
                                sqlCon.Close();
                            }

                            else if (r.GetInt16(0) == 0)
                            {
                                Employee_form.Emp_Main f = new Employee_form.Emp_Main();
                                f.CurrentEmp = txtID.Text;
                                f.Show();
                                this.Hide();
                                sqlCon.Close();
                            }

                            else if (r.GetInt16(0) == 1)
                            {
                                Dentist_form.Dentist_Main f = new Dentist_form.Dentist_Main();
                                f.CurrentDentist = txtID.Text;
                                f.Show();
                                this.Hide();
                                sqlCon.Close();
                            }

                            else if (r.GetInt16(0) == 0)
                            {
                                Admin_form.Admin_Main f = new Admin_form.Admin_Main();
                                f.CurrentAdmin = txtID.Text;
                                f.Show();
                                this.Hide();
                                sqlCon.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username or password is invalid!");
                        }
                    }*/

                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("select MAKHACHHANG,MATKHAU from KHACHHANG where MAKHACHHANG = @username and MATKHAU = @password", sqlCon);
                    SqlCommand cmd2 = new SqlCommand("select MANHANVIEN,MATKHAU from NHANVIEN where MANHANVIEN = @username and MATKHAU = @password", sqlCon);
                    cmd.Parameters.AddWithValue("@username", txtID.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Customer_Main f = new Customer_Main();
                        f.CurrentUser = txtID.Text;
                        f.CurrentPass = txtPassword.Text;
                        f.Show();
                        this.Hide();
                        sqlCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is invalid!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                loginButton.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
            else if (e.KeyCode == Keys.Up)
            {
                txtID.Focus();
            }
        }
    }
}