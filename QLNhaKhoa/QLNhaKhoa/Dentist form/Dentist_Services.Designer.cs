namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Services
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
            panel3 = new Panel();
            button1 = new Button();
            addRecordBtn = new Button();
            addServicesButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            cboCertificate = new ComboBox();
            cboRecord = new ComboBox();
            label7 = new Label();
            noteBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cboService = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            priceBox = new TextBox();
            servicesIDBox = new TextBox();
            serviceData = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(addRecordBtn);
            panel3.Controls.Add(addServicesButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(serviceData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(156, 300);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 5;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = Color.SteelBlue;
            addRecordBtn.FlatAppearance.BorderSize = 0;
            addRecordBtn.FlatStyle = FlatStyle.Flat;
            addRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Location = new Point(262, 300);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(100, 40);
            addRecordBtn.TabIndex = 4;
            addRecordBtn.Text = "Delete";
            addRecordBtn.UseVisualStyleBackColor = false;
            // 
            // addServicesButton
            // 
            addServicesButton.BackColor = Color.SteelBlue;
            addServicesButton.FlatAppearance.BorderSize = 0;
            addServicesButton.FlatStyle = FlatStyle.Flat;
            addServicesButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addServicesButton.ForeColor = Color.White;
            addServicesButton.Location = new Point(50, 300);
            addServicesButton.Name = "addServicesButton";
            addServicesButton.Size = new Size(100, 40);
            addServicesButton.TabIndex = 3;
            addServicesButton.Text = "Add";
            addServicesButton.UseVisualStyleBackColor = false;
            addServicesButton.Click += addServicesButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(351, 25);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 0;
            label1.Text = "Dental Services";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cboCertificate);
            panel4.Controls.Add(cboRecord);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(noteBox);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(cboService);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(priceBox);
            panel4.Controls.Add(servicesIDBox);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // cboCertificate
            // 
            cboCertificate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCertificate.FormattingEnabled = true;
            cboCertificate.Location = new Point(550, 40);
            cboCertificate.Name = "cboCertificate";
            cboCertificate.Size = new Size(150, 27);
            cboCertificate.TabIndex = 14;
            // 
            // cboRecord
            // 
            cboRecord.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRecord.FormattingEnabled = true;
            cboRecord.Location = new Point(350, 40);
            cboRecord.Name = "cboRecord";
            cboRecord.Size = new Size(150, 27);
            cboRecord.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(100, 174);
            label7.Name = "label7";
            label7.Size = new Size(48, 23);
            label7.TabIndex = 12;
            label7.Text = "Note";
            // 
            // noteBox
            // 
            noteBox.Enabled = false;
            noteBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            noteBox.Location = new Point(100, 200);
            noteBox.MaxLength = 5;
            noteBox.Name = "noteBox";
            noteBox.PlaceholderText = "Note";
            noteBox.Size = new Size(600, 27);
            noteBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(550, 14);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 10;
            label6.Text = "Certificate ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(350, 14);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 8;
            label5.Text = "Record ID";
            // 
            // cboService
            // 
            cboService.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(100, 120);
            cboService.Name = "cboService";
            cboService.Size = new Size(400, 27);
            cboService.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 94);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 5;
            label4.Text = "Service Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(550, 94);
            label3.Name = "label3";
            label3.Size = new Size(49, 23);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 14);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Service ID";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(550, 120);
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.ReadOnly = true;
            priceBox.Size = new Size(150, 27);
            priceBox.TabIndex = 1;
            // 
            // servicesIDBox
            // 
            servicesIDBox.Enabled = false;
            servicesIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            servicesIDBox.Location = new Point(100, 40);
            servicesIDBox.MaxLength = 5;
            servicesIDBox.Name = "servicesIDBox";
            servicesIDBox.PlaceholderText = "Service ID";
            servicesIDBox.Size = new Size(200, 27);
            servicesIDBox.TabIndex = 0;
            // 
            // serviceData
            // 
            serviceData.AllowUserToDeleteRows = false;
            serviceData.AllowUserToResizeColumns = false;
            serviceData.AllowUserToResizeRows = false;
            serviceData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            serviceData.BorderStyle = BorderStyle.None;
            serviceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceData.Dock = DockStyle.Bottom;
            serviceData.Location = new Point(0, 350);
            serviceData.Name = "serviceData";
            serviceData.RowHeadersWidth = 51;
            serviceData.Size = new Size(900, 350);
            serviceData.TabIndex = 2;
            serviceData.CellClick += serviceData_CellClick;
            // 
            // Dentist_Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Services";
            Text = "Dentist_Services";
            Load += Dentist_Services_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button addRecordBtn;
        private Button addServicesButton;
        private Label label1;
        private Panel panel4;
        private TextBox servicesIDBox;
        private DataGridView serviceData;
        private TextBox priceBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private ComboBox cboService;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox noteBox;
        private ComboBox cboRecord;
        private ComboBox cboCertificate;
    }
}