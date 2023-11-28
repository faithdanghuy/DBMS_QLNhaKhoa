namespace QLNhaKhoa.General_form
{
    partial class Customer_Appointment
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
            panel1 = new Panel();
            button2 = new Button();
            makeAppointBtn = new Button();
            panel2 = new Panel();
            label3 = new Label();
            appointDate = new DateTimePicker();
            label2 = new Label();
            cboDentists = new ComboBox();
            label1 = new Label();
            appointTime = new TextBox();
            appointmentData = new DataGridView();
            serviceTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(makeAppointBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(appointmentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(50, 300);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 4;
            button2.Text = "Update appointment";
            button2.UseVisualStyleBackColor = false;
            // 
            // makeAppointBtn
            // 
            makeAppointBtn.BackColor = Color.SteelBlue;
            makeAppointBtn.FlatAppearance.BorderSize = 0;
            makeAppointBtn.FlatStyle = FlatStyle.Flat;
            makeAppointBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeAppointBtn.ForeColor = Color.White;
            makeAppointBtn.Location = new Point(256, 300);
            makeAppointBtn.Name = "makeAppointBtn";
            makeAppointBtn.Size = new Size(200, 40);
            makeAppointBtn.TabIndex = 1;
            makeAppointBtn.Text = "Make an appointment";
            makeAppointBtn.UseVisualStyleBackColor = false;
            makeAppointBtn.Click += makeAppointBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(appointDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cboDentists);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(appointTime);
            panel2.Location = new Point(50, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(400, 36);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // appointDate
            // 
            appointDate.CustomFormat = "yyyy-MM-dd";
            appointDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointDate.Format = DateTimePickerFormat.Custom;
            appointDate.Location = new Point(400, 62);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(250, 27);
            appointDate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(150, 142);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 4;
            label2.Text = "Dentist";
            // 
            // cboDentists
            // 
            cboDentists.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentists.FormattingEnabled = true;
            cboDentists.Location = new Point(150, 168);
            cboDentists.MinimumSize = new Size(450, 0);
            cboDentists.Name = "cboDentists";
            cboDentists.Size = new Size(500, 27);
            cboDentists.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(150, 36);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 2;
            label1.Text = "Time (8h - 17h)";
            // 
            // appointTime
            // 
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Location = new Point(150, 62);
            appointTime.MaxLength = 5;
            appointTime.Name = "appointTime";
            appointTime.PlaceholderText = "example: 8h30";
            appointTime.Size = new Size(200, 27);
            appointTime.TabIndex = 0;
            appointTime.KeyPress += appointTime_KeyPress;
            // 
            // appointmentData
            // 
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
            appointmentData.TabIndex = 0;
            appointmentData.CellClick += appointmentData_CellClick;
            // 
            // serviceTitle
            // 
            serviceTitle.AutoSize = true;
            serviceTitle.BackColor = Color.White;
            serviceTitle.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceTitle.ForeColor = Color.SteelBlue;
            serviceTitle.Location = new Point(367, 20);
            serviceTitle.Name = "serviceTitle";
            serviceTitle.Size = new Size(166, 35);
            serviceTitle.TabIndex = 6;
            serviceTitle.Text = "Appointment";
            // 
            // Customer_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(serviceTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer_Appointment";
            Text = "Appointment";
            Load += Appointment_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button makeAppointBtn;
        private Panel panel2;
        private Label label3;
        private DateTimePicker appointDate;
        private Label label2;
        private ComboBox cboDentists;
        private Label label1;
        private TextBox appointTime;
        private Label serviceTitle;
        public DataGridView appointmentData;
    }
}