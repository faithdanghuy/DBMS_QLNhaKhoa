namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dentist_Appointment));
            panel3 = new Panel();
            updateButton = new Button();
            deleteButton = new Button();
            updateRecordBtn = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            cboEmployee = new ComboBox();
            timeBox = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dateBox = new DateTimePicker();
            appointmentData = new DataGridView();
            appIDBox = new TextBox();
            label5 = new Label();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(updateButton);
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(updateRecordBtn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(appointmentData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 9;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(256, 300);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 40);
            updateButton.TabIndex = 5;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.SteelBlue;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(362, 300);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(100, 40);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateRecordBtn
            // 
            updateRecordBtn.BackColor = Color.SteelBlue;
            updateRecordBtn.FlatAppearance.BorderSize = 0;
            updateRecordBtn.FlatStyle = FlatStyle.Flat;
            updateRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateRecordBtn.ForeColor = Color.White;
            updateRecordBtn.Location = new Point(50, 300);
            updateRecordBtn.Name = "updateRecordBtn";
            updateRecordBtn.Size = new Size(200, 40);
            updateRecordBtn.TabIndex = 3;
            updateRecordBtn.Text = "Make an appointment";
            updateRecordBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(367, 25);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 0;
            label1.Text = "Appointment";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(appIDBox);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(cboEmployee);
            panel4.Controls.Add(timeBox);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dateBox);
            panel4.Location = new Point(50, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(300, 145);
            label4.Name = "label4";
            label4.Size = new Size(83, 23);
            label4.TabIndex = 7;
            label4.Text = "Customer";
            // 
            // cboEmployee
            // 
            cboEmployee.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(300, 171);
            cboEmployee.MinimumSize = new Size(350, 0);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(350, 27);
            cboEmployee.TabIndex = 6;
            // 
            // timeBox
            // 
            timeBox.CustomFormat = "HH:mm ";
            timeBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeBox.Format = DateTimePickerFormat.Custom;
            timeBox.Location = new Point(150, 62);
            timeBox.Name = "timeBox";
            timeBox.ShowUpDown = true;
            timeBox.Size = new Size(200, 27);
            timeBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(400, 36);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 4;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(150, 36);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 3;
            label2.Text = "Time (8h - 17h)";
            // 
            // dateBox
            // 
            dateBox.CustomFormat = "yyyy-MM-dd";
            dateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBox.Format = DateTimePickerFormat.Custom;
            dateBox.Location = new Point(400, 62);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(250, 27);
            dateBox.TabIndex = 2;
            // 
            // appointmentData
            // 
            appointmentData.AllowUserToAddRows = false;
            appointmentData.AllowUserToDeleteRows = false;
            appointmentData.AllowUserToResizeColumns = false;
            appointmentData.AllowUserToResizeRows = false;
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            appointmentData.BorderStyle = BorderStyle.None;
            appointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentData.Dock = DockStyle.Bottom;
            appointmentData.Location = new Point(0, 350);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(900, 350);
            appointmentData.TabIndex = 2;
            appointmentData.CellClick += appointmentData_CellClick;
            // 
            // appIDBox
            // 
            appIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appIDBox.Location = new Point(150, 170);
            appIDBox.Name = "appIDBox";
            appIDBox.PlaceholderText = "Appointment ID";
            appIDBox.Size = new Size(125, 27);
            appIDBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(150, 145);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 9;
            label5.Text = "Appointment ID";
            // 
            // Dentist_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dentist_Appointment";
            Text = "Dentist_Appointment";
            Load += Dentist_Appointment_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button updateButton;
        private Button deleteButton;
        private Button updateRecordBtn;
        private Label label1;
        private Panel panel4;
        private DateTimePicker timeBox;
        private Label label3;
        private Label label2;
        private DateTimePicker dateBox;
        private DataGridView appointmentData;
        private ComboBox cboEmployee;
        private Label label4;
        private Label label5;
        private TextBox appIDBox;
    }
}