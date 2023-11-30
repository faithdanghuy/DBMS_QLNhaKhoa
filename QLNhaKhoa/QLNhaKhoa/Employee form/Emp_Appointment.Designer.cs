namespace QLNhaKhoa.Employee_form
{
    partial class Emp_Appointment
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
            searchIDBox = new TextBox();
            searchButton = new Button();
            refreshButton = new Button();
            updateAppButton = new Button();
            makeAppButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            timeBox = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dateBox = new DateTimePicker();
            appointmentData = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(searchIDBox);
            panel3.Controls.Add(searchButton);
            panel3.Controls.Add(refreshButton);
            panel3.Controls.Add(updateAppButton);
            panel3.Controls.Add(makeAppButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(appointmentData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 10;
            // 
            // searchIDBox
            // 
            searchIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchIDBox.Location = new Point(569, 311);
            searchIDBox.MaxLength = 10;
            searchIDBox.Name = "searchIDBox";
            searchIDBox.PlaceholderText = "Enter appointment ID to search";
            searchIDBox.Size = new Size(200, 27);
            searchIDBox.TabIndex = 18;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.SteelBlue;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Tw Cen MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(775, 311);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 27);
            searchButton.TabIndex = 19;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SteelBlue;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(362, 298);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 40);
            refreshButton.TabIndex = 15;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // updateAppButton
            // 
            updateAppButton.BackColor = Color.SteelBlue;
            updateAppButton.FlatAppearance.BorderSize = 0;
            updateAppButton.FlatStyle = FlatStyle.Flat;
            updateAppButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateAppButton.ForeColor = Color.White;
            updateAppButton.Location = new Point(256, 298);
            updateAppButton.Name = "updateAppButton";
            updateAppButton.Size = new Size(100, 40);
            updateAppButton.TabIndex = 5;
            updateAppButton.Text = "Update";
            updateAppButton.UseVisualStyleBackColor = false;
            // 
            // makeAppButton
            // 
            makeAppButton.BackColor = Color.SteelBlue;
            makeAppButton.FlatAppearance.BorderSize = 0;
            makeAppButton.FlatStyle = FlatStyle.Flat;
            makeAppButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeAppButton.ForeColor = Color.White;
            makeAppButton.Location = new Point(50, 298);
            makeAppButton.Name = "makeAppButton";
            makeAppButton.Size = new Size(200, 40);
            makeAppButton.TabIndex = 3;
            makeAppButton.Text = "Make an appointment";
            makeAppButton.UseVisualStyleBackColor = false;
            makeAppButton.Click += makeAppButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(367, 20);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 0;
            label1.Text = "Appointment";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(timeBox);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(dateBox);
            panel4.Location = new Point(50, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // timeBox
            // 
            timeBox.CustomFormat = "hh:mm";
            timeBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeBox.Format = DateTimePickerFormat.Custom;
            timeBox.Location = new Point(100, 112);
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(250, 27);
            timeBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 86);
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
            label2.Location = new Point(100, 86);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // dateBox
            // 
            dateBox.CustomFormat = "yyyy-MM-dd";
            dateBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBox.Format = DateTimePickerFormat.Custom;
            dateBox.Location = new Point(450, 112);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(250, 27);
            dateBox.TabIndex = 2;
            // 
            // appointmentData
            // 
            appointmentData.AllowUserToDeleteRows = false;
            appointmentData.AllowUserToResizeColumns = false;
            appointmentData.AllowUserToResizeRows = false;
            appointmentData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentData.BorderStyle = BorderStyle.None;
            appointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentData.Dock = DockStyle.Bottom;
            appointmentData.Location = new Point(0, 350);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(900, 350);
            appointmentData.TabIndex = 2;
            // 
            // Emp_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp_Appointment";
            Text = "Emp_Appointment";
            Load += Emp_Appointment_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button updateAppButton;
        private Button makeAppButton;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateBox;
        private DataGridView appointmentData;
        private Button refreshButton;
        private TextBox searchIDBox;
        private Button searchButton;
        private DateTimePicker timeBox;
    }
}