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
            string acc_query = "select * from NHANVIEN";
            accountData.DataSource = Helper.getData(acc_query).Tables[0];
        }
    }
}
