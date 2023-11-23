using QLNhaKhoa.General_form;
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
    public partial class Admin_Main : Form
    {
        public string CurrentAdmin { get; set; } = string.Empty;
        public Admin_Main()
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
            loadform(new Account());
        }

        private void AccountMngrButton_Click(object sender, EventArgs e)
        {
            loadform(new Admin_AccManager());
        }

        private void MedicationButton_Click(object sender, EventArgs e)
        {
            loadform(new Admin_Medication());
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
