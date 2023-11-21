namespace QLNhaKhoa.Admin_form
{
    partial class Admin_Main
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
            BillButton = new Button();
            credit = new Label();
            CustomerID = new Label();
            label5 = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            MedicationButton = new Button();
            AccountMngrButton = new Button();
            AccountButton = new Button();
            mainPanel = new Panel();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(BillButton);
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(CustomerID);
            LeftPanel.Controls.Add(label5);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(MedicationButton);
            LeftPanel.Controls.Add(AccountMngrButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 550);
            LeftPanel.TabIndex = 3;
            // 
            // BillButton
            // 
            BillButton.FlatAppearance.BorderSize = 0;
            BillButton.FlatStyle = FlatStyle.Flat;
            BillButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BillButton.ForeColor = Color.White;
            BillButton.Location = new Point(25, 425);
            BillButton.Name = "BillButton";
            BillButton.Size = new Size(250, 40);
            BillButton.TabIndex = 9;
            BillButton.Text = "Permissions";
            BillButton.UseVisualStyleBackColor = true;
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
            label5.Location = new Point(70, 155);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 6;
            label5.Text = "<Admin Name>";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDLabel.ForeColor = Color.White;
            IDLabel.Location = new Point(0, 0);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(85, 23);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "Admin ID:";
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
            // MedicationButton
            // 
            MedicationButton.FlatAppearance.BorderSize = 0;
            MedicationButton.FlatStyle = FlatStyle.Flat;
            MedicationButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedicationButton.ForeColor = Color.White;
            MedicationButton.Location = new Point(25, 350);
            MedicationButton.Name = "MedicationButton";
            MedicationButton.Size = new Size(250, 40);
            MedicationButton.TabIndex = 3;
            MedicationButton.Text = "Medication";
            MedicationButton.UseVisualStyleBackColor = true;
            // 
            // AccountMngrButton
            // 
            AccountMngrButton.FlatAppearance.BorderSize = 0;
            AccountMngrButton.FlatStyle = FlatStyle.Flat;
            AccountMngrButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountMngrButton.ForeColor = Color.White;
            AccountMngrButton.Location = new Point(25, 275);
            AccountMngrButton.Name = "AccountMngrButton";
            AccountMngrButton.Size = new Size(250, 40);
            AccountMngrButton.TabIndex = 2;
            AccountMngrButton.Text = "Account Manager";
            AccountMngrButton.UseVisualStyleBackColor = true;
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
            mainPanel.BackColor = Color.White;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(300, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(600, 550);
            mainPanel.TabIndex = 4;
            // 
            // Admin_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            ControlBox = false;
            Controls.Add(mainPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Main";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Button BillButton;
        private Label credit;
        private Label CustomerID;
        private Label label5;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button MedicationButton;
        private Button AccountMngrButton;
        private Button AccountButton;
        private Panel mainPanel;
    }
}