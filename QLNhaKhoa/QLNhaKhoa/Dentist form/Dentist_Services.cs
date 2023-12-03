using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Services : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        private string query = "select DVK.*, DVSD.MAHSBA, DVSD.MAGIAYKHAMBENH, DVSD.GHICHU " +
                                           "from DICHVUSUDUNG DVSD JOIN DICHVUKHAM DVK ON DVSD.MADICHVU = DVK.MADICHVU";
        public Dentist_Services()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            Helper.refreshData(query, serviceData);
        }

        private void Dentist_Services_Load(object sender, EventArgs e)
        {
            serviceData.DataSource = Helper.getData(query).Tables[0];

            cboService.DisplayMember = "TENDICHVU";
            cboService.ValueMember = "MADICHVU";
            cboService.DataSource = Helper.getData("select MADICHVU, TENDICHVU from DICHVUKHAM").Tables[0];

            cboRecord.DisplayMember = "MAHSBA";
            cboRecord.ValueMember = "MAHSBA";
            cboService.DataSource = Helper.getData("select MAHSBA from HOSOBENHAN").Tables[0];

            cboCertificate.DisplayMember = "MAGIAYKHAMBENH";
            cboCertificate.ValueMember = "MAGIAYKHAMBENH";
            cboCertificate.DataSource = Helper.getData("select DISTINCT MAGIAYKHAMBENH from GIAYKHAMBENH").Tables[0];
        }

        private void serviceData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = serviceData.Rows[e.RowIndex];
                servicesIDBox.Text = dgvr.Cells["MADICHVU"].Value.ToString();
                cboRecord.Text = dgvr.Cells["MAHSBA"].Value.ToString();
                cboCertificate.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
                priceBox.Text = dgvr.Cells["GIATIEN"].Value.ToString();
                cboService.Text = dgvr.Cells["TENDICHVU"].Value.ToString();
                noteBox.Text = dgvr.Cells["GHICHU"].Value.ToString();
            }
        }

        private void addServicesButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_DICHVUSUDUNG_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAHSBA", cboRecord.Text));
                cmd.Parameters.Add(new SqlParameter("@MAGIAYKHAMBENH", cboCertificate.Text));
                cmd.Parameters.Add(new SqlParameter("@MADICHVU", cboRecord.Text));
                cmd.Parameters.Add(new SqlParameter("@GHICHU", noteBox.Text));

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dịch vụ thất bại! " + ex.Message);
            }
        }
    }
}
