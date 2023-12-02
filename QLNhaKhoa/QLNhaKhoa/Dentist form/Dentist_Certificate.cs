using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Certificate : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public Dentist_Certificate()
        {
            InitializeComponent();
        }
        private void Dentist_Certificate_Load(object sender, EventArgs e)
        {
            string certificate_query = "select * from GIAYKHAMBENH";
            certificateData.DataSource = Helper.getData(certificate_query).Tables[0];
        }
        private void certificateData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvr = certificateData.Rows[e.RowIndex];
                certificateIDBox.Text = dgvr.Cells["MAGIAYKHAMBENH"].Value.ToString();
                examDateBox.Text = dgvr.Cells["NGAYKHAM"].Value.ToString();
                recordIDBox.Text = dgvr.Cells["MAHSBA"].Value.ToString();
            }
        }
        private void addCertButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_GIAYKHAMBENH_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MAHSBA", recordIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAYKHAM", examDateBox.Text));

                cmd.Parameters.Add("@MAGIAYKHAMBENH", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Thêm giấy khám bệnh thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm giấy khám bệnh thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm giấy khám bệnh thất bại! " + ex.Message);
            }
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            int prev = certificateData.CurrentRow.Index - 1;
            if (prev > 0)
            {
                certificateData.CurrentCell = certificateData.Rows[prev].Cells[certificateData.CurrentCell.ColumnIndex];
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            int next = certificateData.CurrentRow.Index + 1;
            if (next < certificateData.Rows.Count)
            {
                certificateData.CurrentCell = certificateData.Rows[next].Cells[certificateData.CurrentCell.ColumnIndex];
            }
        }
    }
}
