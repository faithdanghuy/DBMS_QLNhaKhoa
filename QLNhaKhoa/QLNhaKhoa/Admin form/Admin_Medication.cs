using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Medication : Form
    {
        public string CurrentAdmin { get; set; } = string.Empty;
        public Admin_Medication()
        {
            InitializeComponent();
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
        private void Admin_Medication_Load(object sender, EventArgs e)
        {
            string med_query = "select * from THUOC where MANVQUANLY='" + CurrentAdmin + "'";
            medData.DataSource = Helper.getData(med_query).Tables[0];
        }
        private void medData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = medData.Rows[e.RowIndex];
                medIDBox.Text = dgvr.Cells["MATHUOC"].Value.ToString();
                empIDBox.Text = dgvr.Cells["MANVQUANLY"].Value.ToString();
                cboUnit.Text = dgvr.Cells["DONVITINH"].Value.ToString();
                instockBox.Text = dgvr.Cells["SOLUONGTONKHO"].Value.ToString();
                medNameBox.Text = dgvr.Cells["TENTHUOC"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                expDateBox.Text = dgvr.Cells["NGAYHETHAN"].Value.ToString();
                prescribeBox.Text = dgvr.Cells["CHIDINH"].Value.ToString();
            }
        }
        private void addMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_THUOC_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", cboUnit.Text));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", empIDBox.Text));

                cmd.Parameters.Add("@MATHUOC", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu thuốc thất bại! " + ex);
            }

        }
        private void deleteMedButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc là muốn xóa loại thuốc này?", "Warning", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("delete from THUOC where MATHUOC='" + medIDBox.Text + "'", sqlCon);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thuốc thất bại!");
                }
                sqlCon.Close();
            }
            else { }
        }
        private void updateMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_THUOC_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", cboUnit.Text));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", empIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGUOIUPDATE", CurrentAdmin));

                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thuốc thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thuốc thất bại!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Cập nhật dữ liệu thuốc thất bại!");
            }
        }
        private void searchMedButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_THUOC_SEARCH", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MATHUOC", medIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@DONVITINH", cboUnit.Text));
                cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescribeBox.Text));
                cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", empIDBox.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Thuốc không tồn tại!");
            }
        }
    }
}
