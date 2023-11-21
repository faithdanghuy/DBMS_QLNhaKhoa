namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LeftPanel = new Panel();
            ServiceButton = new Button();
            PrecriptionButton = new Button();
            BillButton = new Button();
            credit = new Label();
            CustomerID = new Label();
            label5 = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            RecordButton = new Button();
            AppointmentButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            ExitButton = new Button();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(ServiceButton);
            LeftPanel.Controls.Add(PrecriptionButton);
            LeftPanel.Controls.Add(BillButton);
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(CustomerID);
            LeftPanel.Controls.Add(label5);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(RecordButton);
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 550);
            LeftPanel.TabIndex = 2;
            // 
            // ServiceButton
            // 
            ServiceButton.FlatAppearance.BorderSize = 0;
            ServiceButton.FlatStyle = FlatStyle.Flat;
            ServiceButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServiceButton.ForeColor = Color.White;
            ServiceButton.Location = new Point(25, 425);
            ServiceButton.Name = "ServiceButton";
            ServiceButton.Size = new Size(250, 40);
            ServiceButton.TabIndex = 11;
            ServiceButton.Text = "Services";
            ServiceButton.UseVisualStyleBackColor = true;
            ServiceButton.Click += ServiceButton_Click;
            // 
            // PrecriptionButton
            // 
            PrecriptionButton.FlatAppearance.BorderSize = 0;
            PrecriptionButton.FlatStyle = FlatStyle.Flat;
            PrecriptionButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecriptionButton.ForeColor = Color.White;
            PrecriptionButton.Location = new Point(25, 380);
            PrecriptionButton.Name = "PrecriptionButton";
            PrecriptionButton.Size = new Size(250, 40);
            PrecriptionButton.TabIndex = 10;
            PrecriptionButton.Text = "Prescription";
            PrecriptionButton.UseVisualStyleBackColor = true;
            PrecriptionButton.Click += PrecriptionButton_Click;
            // 
            // BillButton
            // 
            BillButton.FlatAppearance.BorderSize = 0;
            BillButton.FlatStyle = FlatStyle.Flat;
            BillButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillButton.ForeColor = Color.White;
            BillButton.Location = new Point(25, 335);
            BillButton.Name = "BillButton";
            BillButton.Size = new Size(250, 40);
            BillButton.TabIndex = 9;
            BillButton.Text = "Medical bill";
            BillButton.UseVisualStyleBackColor = true;
            BillButton.Click += BillButton_Click;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            credit.ForeColor = Color.White;
            credit.Location = new Point(101, 527);
            credit.Name = "credit";
            credit.Size = new Size(199, 23);
            credit.TabIndex = 8;
            credit.Text = "Developed by Group 3";
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerID.ForeColor = Color.White;
            CustomerID.Location = new Point(84, 0);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(65, 23);
            CustomerID.TabIndex = 7;
            CustomerID.Text = "AB123";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(67, 155);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 6;
            label5.Text = "<Dentist Name>";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(0, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(88, 23);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "Dentist ID:";
            // 
            // HomepageIcon
            // 
            HomepageIcon.Image = Properties.Resources.account1;
            HomepageIcon.Location = new Point(100, 45);
            HomepageIcon.Name = "HomepageIcon";
            HomepageIcon.Size = new Size(100, 100);
            HomepageIcon.SizeMode = PictureBoxSizeMode.Zoom;
            HomepageIcon.TabIndex = 4;
            HomepageIcon.TabStop = false;
            // 
            // RecordButton
            // 
            RecordButton.FlatAppearance.BorderSize = 0;
            RecordButton.FlatStyle = FlatStyle.Flat;
            RecordButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordButton.ForeColor = Color.White;
            RecordButton.Location = new Point(25, 290);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(250, 40);
            RecordButton.TabIndex = 3;
            RecordButton.Text = "Patient record";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += RecordButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.White;
            AppointmentButton.Location = new Point(25, 245);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(250, 40);
            AppointmentButton.TabIndex = 2;
            AppointmentButton.Text = "Appointment";
            AppointmentButton.UseVisualStyleBackColor = true;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // AccountButton
            // 
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountButton.ForeColor = Color.White;
            AccountButton.Location = new Point(25, 200);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(250, 40);
            AccountButton.TabIndex = 1;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(ExitButton);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(600, 550);
            mainPanel.TabIndex = 3;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(560, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Dentist_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 550);
            ControlBox = false;
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dentist_Main";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).EndInit();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label credit;
        private Label CustomerID;
        private Label label5;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button RecordButton;
        private Button AppointmentButton;
        private Button AccountButton;
        private Panel mainPanel;
        private Button ExitButton;
        private Button ServiceButton;
        private Button PrecriptionButton;
        private Button BillButton;
    }
}