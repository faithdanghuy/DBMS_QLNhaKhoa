namespace QLNhaKhoa
{
    partial class Customer_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Main));
            LeftPanel = new Panel();
            credit = new Label();
            CustomerID = new Label();
            CustomerName = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            RecordButton = new Button();
            AppointmentButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            signOutButton = new Button();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(signOutButton);
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(CustomerID);
            LeftPanel.Controls.Add(CustomerName);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(RecordButton);
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 700);
            LeftPanel.TabIndex = 1;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            credit.ForeColor = Color.White;
            credit.Location = new Point(101, 677);
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
            CustomerID.Location = new Point(106, 0);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(65, 23);
            CustomerID.TabIndex = 7;
            CustomerID.Text = "AB123";
            // 
            // CustomerName
            // 
            CustomerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerName.ForeColor = Color.White;
            CustomerName.Location = new Point(56, 210);
            CustomerName.Name = "CustomerName";
            CustomerName.Size = new Size(188, 28);
            CustomerName.TabIndex = 6;
            CustomerName.Text = "<Customer Name>";
            CustomerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(0, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(109, 23);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "Customer ID:";
            // 
            // HomepageIcon
            // 
            HomepageIcon.Image = Properties.Resources.account1;
            HomepageIcon.Location = new Point(100, 100);
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
            RecordButton.Location = new Point(25, 425);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(250, 50);
            RecordButton.TabIndex = 3;
            RecordButton.Text = "Medical record";
            RecordButton.UseVisualStyleBackColor = true;
            RecordButton.Click += RecordButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.FlatAppearance.BorderSize = 0;
            AppointmentButton.FlatStyle = FlatStyle.Flat;
            AppointmentButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.White;
            AppointmentButton.Location = new Point(25, 350);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(250, 50);
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
            AccountButton.Location = new Point(25, 275);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(250, 50);
            AccountButton.TabIndex = 1;
            AccountButton.Text = "Account";
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(900, 700);
            mainPanel.TabIndex = 3;
            // 
            // signOutButton
            // 
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.FlatStyle = FlatStyle.Flat;
            signOutButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signOutButton.ForeColor = Color.White;
            signOutButton.Location = new Point(25, 500);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new Size(250, 50);
            signOutButton.TabIndex = 9;
            signOutButton.Text = "Sign out";
            signOutButton.UseVisualStyleBackColor = true;
            signOutButton.Click += signOutButton_Click;
            // 
            // Customer_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(LeftPanel);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Customer_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard";
            Load += Customer_Main_Load;
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label credit;
        private Label CustomerID;
        private Label CustomerName;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button RecordButton;
        private Button AppointmentButton;
        private Button AccountButton;
        private Panel mainPanel;
        private Button signOutButton;
    }
}