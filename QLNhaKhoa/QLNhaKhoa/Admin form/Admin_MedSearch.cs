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
        private Admin_Medication f;
        public Admin_MedSearch(Admin_Medication f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void Admin_MedSearch_Load(object sender, EventArgs e)
        {
            DataTable dt = Helper.getData("select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 2").Tables[0];
            DataRow row = dt.NewRow();
            row[0] = "-- Tất cả --";
            row[1] = "";
            dt.Rows.InsertAt(row, 0);
            cboEmp.DisplayMember = "HOTEN";
            cboEmp.ValueMember = "MANHANVIEN";
            cboEmp.DataSource = dt;
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

                    string? medID = medIDBox.Text;
                    if (medIDBox.Text == "") medID = null;
                    cmd.Parameters.Add(new SqlParameter("@MATHUOC", medID));

                    string? medName = medNameBox.Text;
                    if (medNameBox.Text == "") medName = null;
                    cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medName));

                    string? unit = cboUnit.Text;
                    if (cboUnit.Text == "") unit = null;
                    cmd.Parameters.Add(new SqlParameter("@DONVITINH", unit));

                    string? prescr = prescriptionBox.Text;
                    if (prescriptionBox.Text == "") prescr = null;
                    cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescr));

                    string? instock = instockBox.Text;
                    if (instockBox.Text == "") instock = null;
                    cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instock));

                    string? dateVal = expDateBox.Text;
                    if (expDateBox.Value.Date <= DateTime.Today) dateVal = null;
                    cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", dateVal));

                    string? price = priceBox.Text;
                    if (priceBox.Text == "") price = null;
                    cmd.Parameters.Add(new SqlParameter("@GIATIEN", price));

                    var item = (DataRowView)cboEmp.SelectedItem;
                    string? nvID = item != null ? item["MANHANVIEN"].ToString() : null;
                    cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", nvID));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        f.searchData = new DataTable();
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
