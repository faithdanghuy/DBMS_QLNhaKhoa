namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Prescription
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
            panel2 = new Panel();
            serviceTitle = new Label();
            ExitButton = new Button();
            button2 = new Button();
            makeAppointBtn = new Button();
            panel3 = new Panel();
            sNameBox = new TextBox();
            costBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            appointTime = new TextBox();
            appointmentData = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 550);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(serviceTitle);
            panel2.Controls.Add(ExitButton);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(makeAppointBtn);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(appointmentData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 550);
            panel2.TabIndex = 6;
            // 
            // serviceTitle
            // 
            serviceTitle.AutoSize = true;
            serviceTitle.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            serviceTitle.ForeColor = Color.SteelBlue;
            serviceTitle.Location = new Point(223, 20);
            serviceTitle.Name = "serviceTitle";
            serviceTitle.Size = new Size(154, 35);
            serviceTitle.TabIndex = 5;
            serviceTitle.Text = "Prescription";
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(560, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(76, 252);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 4;
            button2.Text = "Update prescription";
            button2.UseVisualStyleBackColor = false;
            // 
            // makeAppointBtn
            // 
            makeAppointBtn.BackColor = Color.SteelBlue;
            makeAppointBtn.FlatAppearance.BorderSize = 0;
            makeAppointBtn.FlatStyle = FlatStyle.Flat;
            makeAppointBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            makeAppointBtn.ForeColor = Color.White;
            makeAppointBtn.Location = new Point(326, 252);
            makeAppointBtn.Name = "makeAppointBtn";
            makeAppointBtn.Size = new Size(200, 40);
            makeAppointBtn.TabIndex = 1;
            makeAppointBtn.Text = "Add new prescription";
            makeAppointBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(sNameBox);
            panel3.Controls.Add(costBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(appointTime);
            panel3.Location = new Point(25, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 200);
            panel3.TabIndex = 3;
            // 
            // sNameBox
            // 
            sNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sNameBox.Location = new Point(50, 128);
            sNameBox.Name = "sNameBox";
            sNameBox.Size = new Size(450, 27);
            sNameBox.TabIndex = 8;
            // 
            // costBox
            // 
            costBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costBox.Location = new Point(257, 52);
            costBox.Name = "costBox";
            costBox.Size = new Size(243, 27);
            costBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(257, 26);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 6;
            label3.Text = "Quanity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(50, 102);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 4;
            label2.Text = "Medication Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(50, 26);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 2;
            label1.Text = "Medication ID";
            // 
            // appointTime
            // 
            appointTime.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appointTime.Location = new Point(50, 52);
            appointTime.Name = "appointTime";
            appointTime.Size = new Size(150, 27);
            appointTime.TabIndex = 0;
            // 
            // appointmentData
            // 
            appointmentData.BorderStyle = BorderStyle.None;
            appointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentData.Location = new Point(0, 300);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(600, 250);
            appointmentData.TabIndex = 0;
            // 
            // Dentist_Prescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 550);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Prescription";
            Text = "Dentist_Precription";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label serviceTitle;
        private Button ExitButton;
        private Button button2;
        private Button makeAppointBtn;
        private Panel panel3;
        private TextBox sNameBox;
        private TextBox costBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox appointTime;
        private DataGridView appointmentData;
    }
}