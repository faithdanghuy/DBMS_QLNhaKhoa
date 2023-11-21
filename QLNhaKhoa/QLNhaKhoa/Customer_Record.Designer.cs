namespace QLNhaKhoa
{
    partial class Customer_Record
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
            credit = new Label();
            CustomerID = new Label();
            label5 = new Label();
            IDLabel = new Label();
            HomepageIcon = new PictureBox();
            button1 = new Button();
            AppointmentButton = new Button();
            AccountButton = new Button();
            RightPanel = new Panel();
            bdayBox = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            nameLabel = new Label();
            customerIDBox = new TextBox();
            dentistNameBox = new TextBox();
            ExitButton = new Button();
            dentistIDBox = new TextBox();
            customerNameBox = new TextBox();
            label4 = new Label();
            addressBox = new TextBox();
            label6 = new Label();
            phoneBox = new TextBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).BeginInit();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(credit);
            LeftPanel.Controls.Add(CustomerID);
            LeftPanel.Controls.Add(label5);
            LeftPanel.Controls.Add(IDLabel);
            LeftPanel.Controls.Add(HomepageIcon);
            LeftPanel.Controls.Add(button1);
            LeftPanel.Controls.Add(AppointmentButton);
            LeftPanel.Controls.Add(AccountButton);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(300, 550);
            LeftPanel.TabIndex = 2;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            credit.ForeColor = Color.White;
            credit.Location = new Point(101, 527);
            credit.Name = "credit";
            credit.Size = new Size(199, 23);
            credit.TabIndex = 7;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 220);
            label5.Name = "label5";
            label5.Size = new Size(188, 28);
            label5.TabIndex = 6;
            label5.Text = "<Customer Name>";
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
            HomepageIcon.Location = new Point(75, 50);
            HomepageIcon.Name = "HomepageIcon";
            HomepageIcon.Size = new Size(150, 150);
            HomepageIcon.SizeMode = PictureBoxSizeMode.Zoom;
            HomepageIcon.TabIndex = 4;
            HomepageIcon.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 425);
            button1.Name = "button1";
            button1.Size = new Size(250, 50);
            button1.TabIndex = 3;
            button1.Text = "Medical record";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.White;
            RightPanel.Controls.Add(pictureBox1);
            RightPanel.Controls.Add(label7);
            RightPanel.Controls.Add(phoneBox);
            RightPanel.Controls.Add(label6);
            RightPanel.Controls.Add(addressBox);
            RightPanel.Controls.Add(label4);
            RightPanel.Controls.Add(customerNameBox);
            RightPanel.Controls.Add(bdayBox);
            RightPanel.Controls.Add(label2);
            RightPanel.Controls.Add(label3);
            RightPanel.Controls.Add(label1);
            RightPanel.Controls.Add(nameLabel);
            RightPanel.Controls.Add(customerIDBox);
            RightPanel.Controls.Add(dentistNameBox);
            RightPanel.Controls.Add(ExitButton);
            RightPanel.Controls.Add(dentistIDBox);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(300, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(600, 550);
            RightPanel.TabIndex = 3;
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy/MM/dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(75, 360);
            bdayBox.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            bdayBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(200, 27);
            bdayBox.TabIndex = 14;
            bdayBox.Value = new DateTime(2023, 11, 21, 15, 13, 46, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(75, 260);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 12;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(75, 335);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 10;
            label3.Text = "Date of birth";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(225, 184);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 8;
            label1.Text = "Dentist Name";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.SteelBlue;
            nameLabel.Location = new Point(75, 184);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(84, 23);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Dentist ID";
            // 
            // customerIDBox
            // 
            customerIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerIDBox.Location = new Point(75, 285);
            customerIDBox.Name = "customerIDBox";
            customerIDBox.PlaceholderText = "ID";
            customerIDBox.Size = new Size(100, 27);
            customerIDBox.TabIndex = 6;
            // 
            // dentistNameBox
            // 
            dentistNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistNameBox.Location = new Point(225, 210);
            dentistNameBox.Name = "dentistNameBox";
            dentistNameBox.PlaceholderText = "Name";
            dentistNameBox.Size = new Size(300, 27);
            dentistNameBox.TabIndex = 3;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(560, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // dentistIDBox
            // 
            dentistIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistIDBox.Location = new Point(75, 210);
            dentistIDBox.Name = "dentistIDBox";
            dentistIDBox.PlaceholderText = "ID";
            dentistIDBox.Size = new Size(100, 27);
            dentistIDBox.TabIndex = 0;
            // 
            // customerNameBox
            // 
            customerNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNameBox.Location = new Point(225, 285);
            customerNameBox.Name = "customerNameBox";
            customerNameBox.PlaceholderText = "Name";
            customerNameBox.Size = new Size(300, 27);
            customerNameBox.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(225, 259);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 16;
            label4.Text = "Customer Name";
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(75, 435);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(450, 27);
            addressBox.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(75, 410);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 18;
            label6.Text = "Address";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(350, 360);
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone";
            phoneBox.Size = new Size(175, 27);
            phoneBox.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(350, 335);
            label7.Name = "label7";
            label7.Size = new Size(123, 23);
            label7.TabIndex = 20;
            label7.Text = "Phone number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medical;
            pictureBox1.Location = new Point(240, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Customer_Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            ControlBox = false;
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Record";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomepageIcon).EndInit();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Label credit;
        private Label CustomerID;
        private Label label5;
        private Label IDLabel;
        private PictureBox HomepageIcon;
        private Button button1;
        private Button AppointmentButton;
        private Button AccountButton;
        private Panel RightPanel;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label nameLabel;
        private TextBox customerIDBox;
        private TextBox dentistNameBox;
        private Button ExitButton;
        private TextBox dentistIDBox;
        private DateTimePicker bdayBox;
        private Label label4;
        private TextBox customerNameBox;
        private Label label6;
        private TextBox addressBox;
        private Label label7;
        private TextBox phoneBox;
        private PictureBox pictureBox1;
    }
}