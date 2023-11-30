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

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Record : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Record()
        {
            InitializeComponent();
        }
        private void Dentist_Record_Load(object sender, EventArgs e)
        {
            string record_query = "select * from HOSOBENHAN where MANHASI='" + CurrentDentist + "'";
            recordData.DataSource = Helper.getData(record_query).Tables[0];
        }
    }
}
