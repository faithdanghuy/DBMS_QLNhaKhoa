namespace QLNhaKhoa.Dentist_form
{
    public partial class Dentist_Main : Form
    {
        public string CurrentDentist { get; set; } = string.Empty;
        public string CurrentPass { get; set; } = string.Empty;
        public Dentist_Main()
        {
            InitializeComponent();
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Account(), this.mainPanel);
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Services(), this.mainPanel);
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Appointment(), this.mainPanel);
        }

        private void PrecriptionButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Prescription(), this.mainPanel);
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Record(), this.mainPanel);
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Dentist_Certificate(), this.mainPanel);
        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
