namespace QLNhaKhoa.Customer_form
{
    partial class Customer_AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_AppForm));
            cancelButton = new Button();
            makeAppButton = new Button();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            appointDate = new DateTimePicker();
            appointTime = new DateTimePicker();
            cboDentists = new ComboBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(316, 255);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(175, 50);
            cancelButton.TabIndex = 47;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // makeAppButton
            // 
            makeAppButton.BackColor = Color.SteelBlue;
            makeAppButton.FlatAppearance.BorderSize = 0;
            makeAppButton.FlatStyle = FlatStyle.Flat;
            makeAppButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeAppButton.ForeColor = Color.White;
            makeAppButton.Location = new Point(91, 255);
            makeAppButton.Name = "makeAppButton";
            makeAppButton.Size = new Size(175, 50);
            makeAppButton.TabIndex = 46;
            makeAppButton.Text = "Make";
            makeAppButton.UseVisualStyleBackColor = false;
            makeAppButton.Click += makeAppButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(134, 37);
            label1.Name = "label1";
            label1.Size = new Size(326, 39);
            label1.TabIndex = 45;
            label1.Text = "Make an appointment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(316, 168);
            label8.Name = "label8";
            label8.Size = new Size(132, 23);
            label8.TabIndex = 44;
            label8.Text = "Time (8h - 17h)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(91, 93);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 41;
            label5.Text = "Dentist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(91, 168);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 40;
            label4.Text = "Date";
            // 
            // appointDate
            // 
            appointDate.CustomFormat = "yyyy-MM-dd";
            appointDate.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointDate.Format = DateTimePickerFormat.Custom;
            appointDate.Location = new Point(91, 194);
            appointDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            appointDate.Name = "appointDate";
            appointDate.Size = new Size(175, 27);
            appointDate.TabIndex = 35;
            appointDate.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // appointTime
            // 
            appointTime.CustomFormat = "HH:mm";
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Format = DateTimePickerFormat.Custom;
            appointTime.Location = new Point(316, 194);
            appointTime.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            appointTime.Name = "appointTime";
            appointTime.ShowUpDown = true;
            appointTime.Size = new Size(175, 27);
            appointTime.TabIndex = 48;
            appointTime.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // cboDentists
            // 
            cboDentists.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDentists.FormattingEnabled = true;
            cboDentists.Location = new Point(91, 119);
            cboDentists.Name = "cboDentists";
            cboDentists.Size = new Size(400, 27);
            cboDentists.TabIndex = 49;
            // 
            // Customer_AppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 353);
            Controls.Add(cboDentists);
            Controls.Add(appointTime);
            Controls.Add(cancelButton);
            Controls.Add(makeAppButton);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(appointDate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Customer_AppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Make an appointment";
            Load += Customer_AppForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button makeAppButton;
        private Label label1;
        private Label label8;
        private Label label5;
        private Label label4;
        private DateTimePicker appointDate;
        private DateTimePicker appointTime;
        private ComboBox cboDentists;
    }
}