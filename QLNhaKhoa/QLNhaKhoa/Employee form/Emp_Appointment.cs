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
    public partial class Emp_Appointment : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_Appointment()
        {
            InitializeComponent();
        }
        private void Emp_Appointment_Load(object sender, EventArgs e)
        {
            appointmentData.DataSource = Helper.getData("select * from LICHHEN").Tables[0];
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            Helper.refreshData("select * from LICHHEN", appointmentData);
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            (appointmentData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MALICHHEN like '%" + searchIDBox.Text + "%'");
        }
        private void makeAppButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_LICHHEN_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NGAY", dateBox.Text));
                //cmd.Parameters.Add(new SqlParameter("@GIO", recordIDBox.Text));
                //cmd.Parameters.Add(new SqlParameter("@MANHASI", certificateIDBox.Text));
                //cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", certificateIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@MANVDATLICH", CurrentEmp));

                cmd.Parameters.Add("@MALICHHEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                sqlCon.Close();
                if (i > 0)
                {
                    MessageBox.Show("Lập hóa đơn thành công!");
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
