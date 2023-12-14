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

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_MedSearch : Form
    {
        public event EventHandler FormClosedEvent;
        public Admin_MedSearch()
        {
            InitializeComponent();
        }

        private void Admin_MedSearch_Load(object sender, EventArgs e)
        {
            cboEmp.DisplayMember = "HOTEN";
            cboEmp.ValueMember = "MANHANVIEN";
            cboEmp.DataSource = Helper.getData("select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 2").Tables[0];
        }

        private void instockBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void searchMedButton_Click(object sender, EventArgs e)
        {
            if (medNameBox.Text == "" &&
                cboUnit.Text == "" &&
                prescriptionBox.Text == "" &&
                instockBox.Text == "" &&
                priceBox.Text == "" &&
                medIDBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin thuốc để tìm kiếm!");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_THUOC_SEARCH", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    Admin_Medication f = new Admin_Medication();

                    var item = (DataRowView)cboEmp.SelectedItem;
                    cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@DONVITINH", cboUnit.Text));
                    cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescriptionBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", item["MANHANVIEN"].ToString()));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(f.searchData);
                        FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    }
                    this.Close();
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tìm dữ liệu thuốc thất bại! " + ex.Message);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có muốn thoát quá trình tỉm thuốc?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }
    }
}
