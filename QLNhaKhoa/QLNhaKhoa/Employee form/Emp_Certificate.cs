using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Certificate : Form
    {
        public Emp_Certificate()
        {
            InitializeComponent();
        }
        private void Emp_Certificate_Load(object sender, EventArgs e)
        {
            certificateData.DataSource = Helper.getData("select * from GIAYKHAMBENH").Tables[0];
        }
        private void certificateData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = certificateData.Rows[e.RowIndex];
                certificateIDBox.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
                recordIDBox.Text = dgvr.Cells["MAHSBA"].Value.ToString();
                examDateBox.Text = dgvr.Cells["NGAYKHAM"].Value.ToString();
                medTotalBox.Text = dgvr.Cells["TONGTIENTHUOC"].Value.ToString();
                serviceTotalBox.Text = dgvr.Cells["TONGTIENDICHVU"].Value.ToString();
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from GIAYKHAMBENH", certificateData);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            (certificateData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MAGIAYKHAMBENH like '%" + searchIDBox.Text + "%'");
        }
    }
}
