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

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Bill : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_Bill()
        {
            InitializeComponent();
        }
        private void Emp_Bill_Load(object sender, EventArgs e)
        {
            billData.DataSource = Helper.getData("select * from HOADON").Tables[0];
        }
        private void billData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = billData.Rows[e.RowIndex];
                certificateIDBox.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
                recordIDBox.Text = dgvr.Cells["MAHSBA"].Value.ToString();
                totalBox.Text = dgvr.Cells["TONGTIEN"].Value.ToString();
                billIDBox.Text = dgvr.Cells["MAHOADON"].Value.ToString();
                dateBox.Text = dgvr.Cells["NGAYLAP"].Value.ToString();
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from HOADON", billData);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            (billData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MAHOADON like '%" + searchIDBox.Text + "%'");
        }
        private void addBillButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_HOADON_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NGAYLAP", dateBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MAHSBA", recordIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", certificateIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MANVLAP", CurrentEmp));

                cmd.Parameters.Add("@MAHOADON", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Lập hóa đơn thành công!");
                    Helper.refreshData("select * from HOADON", billData);
                }
                else
                {
                    MessageBox.Show("Lập hóa đơn thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lập hóa đơn thất bại! " + ex.Message);
            }
        }
    }
}
