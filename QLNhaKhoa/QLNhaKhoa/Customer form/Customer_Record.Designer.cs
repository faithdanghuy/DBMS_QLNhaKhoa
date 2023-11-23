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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Record));
            RightPanel = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            nameLabel = new Label();
            ExitButton = new Button();
            dentistIDBox = new TextBox();
            dentistNameBox = new TextBox();
            customerIDBox = new TextBox();
            customerNameBox = new TextBox();
            addressBox = new TextBox();
            phoneBox = new TextBox();
            bdayBox = new DateTimePicker();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.White;
            RightPanel.Controls.Add(bdayBox);
            RightPanel.Controls.Add(phoneBox);
            RightPanel.Controls.Add(addressBox);
            RightPanel.Controls.Add(customerNameBox);
            RightPanel.Controls.Add(customerIDBox);
            RightPanel.Controls.Add(dentistNameBox);
            RightPanel.Controls.Add(dentistIDBox);
            RightPanel.Controls.Add(pictureBox1);
            RightPanel.Controls.Add(label7);
            RightPanel.Controls.Add(label6);
            RightPanel.Controls.Add(label4);
            RightPanel.Controls.Add(label2);
            RightPanel.Controls.Add(label3);
            RightPanel.Controls.Add(label1);
            RightPanel.Controls.Add(nameLabel);
            RightPanel.Controls.Add(ExitButton);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(0, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(900, 700);
            RightPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.medical;
            pictureBox1.Location = new Point(375, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(209, 415);
            label7.Name = "label7";
            label7.Size = new Size(62, 23);
            label7.TabIndex = 20;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(209, 490);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 18;
            label6.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(359, 335);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 16;
            label4.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(209, 335);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 12;
            label2.Text = "Customer ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(509, 415);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 10;
            label3.Text = "Date of birth:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(359, 260);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 8;
            label1.Text = "Name:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.SteelBlue;
            nameLabel.Location = new Point(209, 260);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(88, 23);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Dentist ID:";
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(860, 0);
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
            dentistIDBox.Location = new Point(209, 286);
            dentistIDBox.Name = "dentistIDBox";
            dentistIDBox.PlaceholderText = "Dentist ID";
            dentistIDBox.Size = new Size(100, 27);
            dentistIDBox.TabIndex = 22;
            // 
            // dentistNameBox
            // 
            dentistNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistNameBox.Location = new Point(359, 286);
            dentistNameBox.Name = "dentistNameBox";
            dentistNameBox.PlaceholderText = "Dentist Name";
            dentistNameBox.Size = new Size(350, 27);
            dentistNameBox.TabIndex = 23;
            // 
            // customerIDBox
            // 
            customerIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerIDBox.Location = new Point(209, 361);
            customerIDBox.Name = "customerIDBox";
            customerIDBox.PlaceholderText = "Customer ID";
            customerIDBox.Size = new Size(100, 27);
            customerIDBox.TabIndex = 24;
            // 
            // customerNameBox
            // 
            customerNameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNameBox.Location = new Point(359, 361);
            customerNameBox.Name = "customerNameBox";
            customerNameBox.PlaceholderText = "Customer Name";
            customerNameBox.Size = new Size(350, 27);
            customerNameBox.TabIndex = 25;
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(209, 516);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(500, 27);
            addressBox.TabIndex = 26;
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(209, 441);
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Dentist ID";
            phoneBox.Size = new Size(250, 27);
            phoneBox.TabIndex = 27;
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "dd/MM/yyyy";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(509, 441);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(200, 27);
            bdayBox.TabIndex = 28;
            // 
            // Customer_Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(RightPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Customer_Record";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer_Record";
            Load += Customer_Record_Load;
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel RightPanel;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label nameLabel;
        private Button ExitButton;
        private Label label4;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox dentistNameBox;
        private TextBox dentistIDBox;
        private DateTimePicker bdayBox;
        private TextBox phoneBox;
        private TextBox addressBox;
        private TextBox customerNameBox;
        private TextBox customerIDBox;
    }
}