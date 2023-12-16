using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_AddMed : Form
    {
        public event EventHandler FormClosedEvent;
        public Admin_AddMed()
        {
            InitializeComponent();
        }

        private void Admin_AddMed_Load(object sender, EventArgs e)
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

        private void addMedButton_Click(object sender, EventArgs e)
        {
            if (medNameBox.Text == "" ||
                cboUnit.Text == "" ||
                prescriptionBox.Text == "" ||
                instockBox.Text == "" ||
                priceBox.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("USP_THUOC_INS", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@TENTHUOC", medNameBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@DONVITINH", cboUnit.Text));
                    cmd.Parameters.Add(new SqlParameter("@CHIDINH", prescriptionBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONGTONKHO", instockBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@NGAYHETHAN", expDateBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@GIATIEN", priceBox.Text));

                    var item = (DataRowView)cboEmp.SelectedItem;
                    string? nvID = item != null ? item["MANHANVIEN"].ToString() : "NV001";
                    cmd.Parameters.Add(new SqlParameter("@MANVQUANLY", nvID));

                    cmd.Parameters.Add("@MATHUOC", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thuốc thành công!");
                        FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thuốc thất bại!");
                    }
                    this.Close();
                    sqlCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm dữ liệu thuốc thất bại! " + ex.Message);
                }
            }
        }
    }
}
