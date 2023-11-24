namespace QLNhaKhoa.Admin_form
{
    public partial class Admin_Main : Form
    {
        public string CurrentAdmin { get; set; } = string.Empty;
        public Admin_Main()
        {
            InitializeComponent();
        }
        private void AccountButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Account(), this.mainPanel);
        }

        private void AccountMngrButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_AccManager(), this.mainPanel);
        }

        private void MedicationButton_Click(object sender, EventArgs e)
        {
            Helper.loadform(new Admin_Medication(), this.mainPanel);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
