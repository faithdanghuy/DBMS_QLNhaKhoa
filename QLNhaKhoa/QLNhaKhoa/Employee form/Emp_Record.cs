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
    public partial class Emp_Record : Form
    {
        public Emp_Record()
        {
            InitializeComponent();
        }
        private void Emp_Record_Load(object sender, EventArgs e)
        {
            recordData.DataSource = Helper.getData("select * from HOSOBENHAN").Tables[0];
        }
        private void recordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = recordData.Rows[e.RowIndex];
                recordIDBox.Text = dgvr.Cells["MAHSBA"].Value.ToString();
                customerIDBox.Text = dgvr.Cells["MAKHACHHANG"].Value.ToString();
                dentistIDBox.Text = dgvr.Cells["MANHASI"].Value.ToString();
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {

        }
        private void prevButton_Click(object sender, EventArgs e)
        {

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            (recordData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MAHSBA like '%" + searchIDBox.Text + "%'");
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from HOSOBENHAN", recordData);
        }
    }
}
