using QLNhaKhoa.General_form;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    public partial class Customer_Main : Form
    {
        public string CurrentUser { get; set; } = string.Empty;
        public Customer_Main()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.CurrentUser = CurrentUser;
            loadform(f);
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Appointment f = new Appointment();
            f.CurrentUser = CurrentUser;
            loadform(f);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Customer_Record f = new Customer_Record();
            f.CurrentUser = CurrentUser;
            loadform(f);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_Main_Load(object sender, EventArgs e)
        {
            CustomerID.Text = CurrentUser;
            SqlConnection sqlCon = new SqlConnection(ConnectionString.strCon);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("select HOTEN from KHACHHANG where MAKHACHHANG = '" + CurrentUser + "'", sqlCon);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    CustomerName.Text = reader.GetString(0);
                    sqlCon.Close();
                }
            }
        }
    }
}
