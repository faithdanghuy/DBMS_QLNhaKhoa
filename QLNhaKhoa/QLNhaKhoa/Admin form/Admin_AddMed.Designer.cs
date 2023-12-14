namespace QLNhaKhoa.Admin_form
{
    partial class Admin_AddMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AddMed));
            cancelButton = new Button();
            addMedButton = new Button();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            priceBox = new TextBox();
            prescriptionBox = new TextBox();
            cboEmp = new ComboBox();
            medNameBox = new TextBox();
            expDateBox = new DateTimePicker();
            label2 = new Label();
            cboUnit = new ComboBox();
            instockBox = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(311, 440);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(180, 50);
            cancelButton.TabIndex = 47;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // addMedButton
            // 
            addMedButton.BackColor = Color.SteelBlue;
            addMedButton.FlatAppearance.BorderSize = 0;
            addMedButton.FlatStyle = FlatStyle.Flat;
            addMedButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMedButton.ForeColor = Color.White;
            addMedButton.Location = new Point(91, 440);
            addMedButton.Name = "addMedButton";
            addMedButton.Size = new Size(180, 50);
            addMedButton.TabIndex = 46;
            addMedButton.Text = "Add";
            addMedButton.UseVisualStyleBackColor = false;
            addMedButton.Click += addMedButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(175, 63);
            label1.Name = "label1";
            label1.Size = new Size(241, 39);
            label1.TabIndex = 45;
            label1.Text = "Add Medication";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(266, 194);
            label8.Name = "label8";
            label8.Size = new Size(62, 23);
            label8.TabIndex = 44;
            label8.Text = "Instock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(91, 269);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 43;
            label7.Text = "Employee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(91, 344);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 42;
            label6.Text = "Prescription";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(91, 119);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 41;
            label5.Text = "Med Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(91, 194);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 40;
            label4.Text = "Expiration Date";
            // 
            // priceBox
            // 
            priceBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceBox.Location = new Point(391, 220);
            priceBox.MaxLength = 11;
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Price";
            priceBox.Size = new Size(100, 27);
            priceBox.TabIndex = 39;
            priceBox.KeyPress += priceBox_KeyPress;
            // 
            // prescriptionBox
            // 
            prescriptionBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prescriptionBox.Location = new Point(91, 370);
            prescriptionBox.MaxLength = 100;
            prescriptionBox.Name = "prescriptionBox";
            prescriptionBox.PlaceholderText = "Prescription";
            prescriptionBox.Size = new Size(400, 27);
            prescriptionBox.TabIndex = 38;
            // 
            // cboEmp
            // 
            cboEmp.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmp.FormattingEnabled = true;
            cboEmp.Items.AddRange(new object[] { "Employee", "Dentist", "Admin" });
            cboEmp.Location = new Point(91, 295);
            cboEmp.Name = "cboEmp";
            cboEmp.Size = new Size(400, 27);
            cboEmp.TabIndex = 37;
            // 
            // medNameBox
            // 
            medNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medNameBox.Location = new Point(91, 145);
            medNameBox.MaxLength = 25;
            medNameBox.Name = "medNameBox";
            medNameBox.PlaceholderText = "Med Name";
            medNameBox.Size = new Size(300, 27);
            medNameBox.TabIndex = 36;
            // 
            // expDateBox
            // 
            expDateBox.CustomFormat = "yyyy-MM-dd";
            expDateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expDateBox.Format = DateTimePickerFormat.Custom;
            expDateBox.Location = new Point(91, 220);
            expDateBox.MaxDate = new DateTime(9000, 12, 2, 0, 0, 0, 0);
            expDateBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            expDateBox.Name = "expDateBox";
            expDateBox.Size = new Size(150, 27);
            expDateBox.TabIndex = 35;
            expDateBox.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(416, 119);
            label2.Name = "label2";
            label2.Size = new Size(40, 23);
            label2.TabIndex = 48;
            label2.Text = "Unit";
            // 
            // cboUnit
            // 
            cboUnit.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUnit.FormattingEnabled = true;
            cboUnit.Items.AddRange(new object[] { "Viên", "Hộp", "Gói" });
            cboUnit.Location = new Point(416, 145);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(75, 27);
            cboUnit.TabIndex = 49;
            // 
            // instockBox
            // 
            instockBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instockBox.Location = new Point(266, 220);
            instockBox.MaxLength = 11;
            instockBox.Name = "instockBox";
            instockBox.PlaceholderText = "Instock";
            instockBox.Size = new Size(100, 27);
            instockBox.TabIndex = 50;
            instockBox.KeyPress += instockBox_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SteelBlue;
            label9.Location = new Point(391, 194);
            label9.Name = "label9";
            label9.Size = new Size(49, 23);
            label9.TabIndex = 51;
            label9.Text = "Price";
            // 
            // Admin_AddMed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 553);
            Controls.Add(label9);
            Controls.Add(instockBox);
            Controls.Add(cboUnit);
            Controls.Add(label2);
            Controls.Add(cancelButton);
            Controls.Add(addMedButton);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(priceBox);
            Controls.Add(prescriptionBox);
            Controls.Add(cboEmp);
            Controls.Add(medNameBox);
            Controls.Add(expDateBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_AddMed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add medication";
            Load += Admin_AddMed_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button addMedButton;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox priceBox;
        private TextBox prescriptionBox;
        private ComboBox cboEmp;
        private TextBox medNameBox;
        private DateTimePicker expDateBox;
        private Label label2;
        private ComboBox cboUnit;
        private TextBox instockBox;
        private Label label9;
    }
}