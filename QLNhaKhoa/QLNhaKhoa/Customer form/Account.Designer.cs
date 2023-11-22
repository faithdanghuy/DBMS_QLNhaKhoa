namespace QLNhaKhoa.General_form
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            RightPanel = new Panel();
            bdayBox = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            updateButton = new Button();
            label3 = new Label();
            label1 = new Label();
            nameLabel = new Label();
            phoneBox = new TextBox();
            addressBox = new TextBox();
            ExitButton = new Button();
            nameBox = new TextBox();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.White;
            RightPanel.CausesValidation = false;
            RightPanel.Controls.Add(bdayBox);
            RightPanel.Controls.Add(pictureBox1);
            RightPanel.Controls.Add(label2);
            RightPanel.Controls.Add(updateButton);
            RightPanel.Controls.Add(label3);
            RightPanel.Controls.Add(label1);
            RightPanel.Controls.Add(nameLabel);
            RightPanel.Controls.Add(phoneBox);
            RightPanel.Controls.Add(addressBox);
            RightPanel.Controls.Add(ExitButton);
            RightPanel.Controls.Add(nameBox);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(0, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(600, 550);
            RightPanel.TabIndex = 2;
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy/MM/dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(350, 301);
            bdayBox.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            bdayBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(200, 27);
            bdayBox.TabIndex = 14;
            bdayBox.Value = new DateTime(2023, 11, 21, 15, 13, 46, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.setting;
            pictureBox1.Location = new Point(240, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(50, 275);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 12;
            label2.Text = "Phone number";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.SteelBlue;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(250, 450);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 40);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(50, 365);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 10;
            label3.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(350, 275);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 8;
            label1.Text = "Date of birth";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.SteelBlue;
            nameLabel.Location = new Point(50, 185);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 23);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(50, 301);
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone";
            phoneBox.Size = new Size(200, 27);
            phoneBox.TabIndex = 6;
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(50, 391);
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(500, 27);
            addressBox.TabIndex = 3;
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
            // nameBox
            // 
            nameBox.Enabled = false;
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(50, 211);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(500, 27);
            nameBox.TabIndex = 0;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 550);
            ControlBox = false;
            Controls.Add(RightPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Account";
            Text = "Account";
            Load += Account_Load;
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel RightPanel;
        private DateTimePicker bdayBox;
        private PictureBox pictureBox1;
        private Label label2;
        private Button updateButton;
        private Label label3;
        private Label label1;
        private Label nameLabel;
        private TextBox phoneBox;
        private TextBox addressBox;
        private Button ExitButton;
        private TextBox nameBox;
    }
}