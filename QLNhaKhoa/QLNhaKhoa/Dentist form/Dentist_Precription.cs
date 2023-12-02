using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Prescription : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Prescription()
        {
            InitializeComponent();
        }
        private void Dentist_Prescription_Load(object sender, EventArgs e)
        {
            string prescription_query = "select * from TOATHUOC";
            prescriptionData.DataSource = Helper.getData(prescription_query).Tables[0];
        }
        private void prescriptionData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

            }
        }
    }
}
