using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_AccManager : Form
    {
        public string CurrentAdmin { get; set; } = string.Empty;
        public Admin_AccManager()
        {
            InitializeComponent();
        }
        private void Admin_AccManager_Load(object sender, EventArgs e)
        {
            accountData.DataSource = Helper.getData("select * from NHANVIEN").Tables[0];
        }
        private void accountData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = accountData.Rows[e.RowIndex];
                IDBox.Text = dgvr.Cells["MANHANVIEN"].Value.ToString();
                passwordBox.Text = dgvr.Cells["MATKHAU"].Value.ToString();
            }
        }
    }
}
