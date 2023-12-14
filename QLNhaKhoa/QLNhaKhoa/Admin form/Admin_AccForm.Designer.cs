namespace QLNhaKhoa.Admin_form
{
    partial class Admin_AccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AccForm));
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            phoneBox = new TextBox();
            addressBox = new TextBox();
            cboEmpType = new ComboBox();
            nameBox = new TextBox();
            bdayBox = new DateTimePicker();
            label3 = new Label();
            passwordBox = new TextBox();
            label1 = new Label();
            createAccButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(289, 185);
            label8.Name = "label8";
            label8.Size = new Size(123, 23);
            label8.TabIndex = 29;
            label8.Text = "Phone number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SteelBlue;
            label7.Location = new Point(89, 260);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 28;
            label7.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(389, 335);
            label6.Name = "label6";
            label6.Size = new Size(85, 23);
            label6.TabIndex = 27;
            label6.Text = "Emp type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(89, 110);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 26;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(89, 185);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 25;
            label4.Text = "Birthday";
            // 
            // phoneBox
            // 
            phoneBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneBox.Location = new Point(289, 211);
            phoneBox.MaxLength = 11;
            phoneBox.Name = "phoneBox";
            phoneBox.PlaceholderText = "Phone number";
            phoneBox.Size = new Size(200, 27);
            phoneBox.TabIndex = 24;
            // 
            // addressBox
            // 
            addressBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressBox.Location = new Point(89, 286);
            addressBox.MaxLength = 100;
            addressBox.Name = "addressBox";
            addressBox.PlaceholderText = "Address";
            addressBox.Size = new Size(400, 27);
            addressBox.TabIndex = 23;
            // 
            // cboEmpType
            // 
            cboEmpType.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEmpType.FormattingEnabled = true;
            cboEmpType.Items.AddRange(new object[] { "Employee", "Dentist", "Admin" });
            cboEmpType.Location = new Point(389, 361);
            cboEmpType.Name = "cboEmpType";
            cboEmpType.Size = new Size(100, 27);
            cboEmpType.TabIndex = 22;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(89, 136);
            nameBox.MaxLength = 25;
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(400, 27);
            nameBox.TabIndex = 21;
            // 
            // bdayBox
            // 
            bdayBox.CustomFormat = "yyyy-MM-dd";
            bdayBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdayBox.Format = DateTimePickerFormat.Custom;
            bdayBox.Location = new Point(89, 211);
            bdayBox.MaxDate = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            bdayBox.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            bdayBox.Name = "bdayBox";
            bdayBox.Size = new Size(150, 27);
            bdayBox.TabIndex = 20;
            bdayBox.Value = new DateTime(2023, 12, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(89, 335);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(89, 361);
            passwordBox.MaxLength = 20;
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(250, 27);
            passwordBox.TabIndex = 17;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(195, 54);
            label1.Name = "label1";
            label1.Size = new Size(194, 39);
            label1.TabIndex = 30;
            label1.Text = "Add account";
            // 
            // createAccButton
            // 
            createAccButton.BackColor = Color.SteelBlue;
            createAccButton.FlatAppearance.BorderSize = 0;
            createAccButton.FlatStyle = FlatStyle.Flat;
            createAccButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccButton.ForeColor = Color.White;
            createAccButton.Location = new Point(89, 431);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(180, 50);
            createAccButton.TabIndex = 31;
            createAccButton.Text = "Create";
            createAccButton.UseVisualStyleBackColor = false;
            createAccButton.Click += createAccButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(309, 431);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(180, 50);
            cancelButton.TabIndex = 32;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // Admin_AccForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 553);
            Controls.Add(cancelButton);
            Controls.Add(createAccButton);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(phoneBox);
            Controls.Add(addressBox);
            Controls.Add(cboEmpType);
            Controls.Add(nameBox);
            Controls.Add(bdayBox);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin_AccForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add an account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox phoneBox;
        private TextBox addressBox;
        private ComboBox cboEmpType;
        private TextBox nameBox;
        private DateTimePicker bdayBox;
        private Label label3;
        private TextBox passwordBox;
        private Label label1;
        private Button createAccButton;
        private Button cancelButton;
    }
}