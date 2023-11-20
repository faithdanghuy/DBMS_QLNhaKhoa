namespace QLNhaKhoa
{
    partial class Regiser
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
            LeftPanel = new Panel();
            Title = new Label();
            Logo = new PictureBox();
            RightPanel = new Panel();
            label1 = new Label();
            ExitButton = new Button();
            RegisterButton = new Button();
            button2 = new Button();
            nameIcon = new PictureBox();
            birthdayIcon = new PictureBox();
            addressIcon = new PictureBox();
            phoneIcon = new PictureBox();
            passIcon = new PictureBox();
            div1 = new Panel();
            div2 = new Panel();
            div3 = new Panel();
            div4 = new Panel();
            div5 = new Panel();
            txtName = new TextBox();
            txtBirthday = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            nameLabel = new Label();
            birthdayLabel = new Label();
            addressLabel = new Label();
            phoneLabel = new Label();
            passLabel = new Label();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nameIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)birthdayIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)addressIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passIcon).BeginInit();
            SuspendLayout();
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.SteelBlue;
            LeftPanel.Controls.Add(Title);
            LeftPanel.Controls.Add(Logo);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(350, 550);
            LeftPanel.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Tw Cen MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(94, 275);
            Title.Name = "Title";
            Title.Size = new Size(162, 54);
            Title.TabIndex = 1;
            Title.Text = "AZURE";
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Logo;
            Logo.Location = new Point(115, 150);
            Logo.Name = "Logo";
            Logo.Size = new Size(120, 120);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.White;
            RightPanel.Controls.Add(passLabel);
            RightPanel.Controls.Add(phoneLabel);
            RightPanel.Controls.Add(addressLabel);
            RightPanel.Controls.Add(birthdayLabel);
            RightPanel.Controls.Add(nameLabel);
            RightPanel.Controls.Add(txtPassword);
            RightPanel.Controls.Add(txtPhone);
            RightPanel.Controls.Add(txtAddress);
            RightPanel.Controls.Add(txtBirthday);
            RightPanel.Controls.Add(txtName);
            RightPanel.Controls.Add(div5);
            RightPanel.Controls.Add(div4);
            RightPanel.Controls.Add(div3);
            RightPanel.Controls.Add(div2);
            RightPanel.Controls.Add(div1);
            RightPanel.Controls.Add(passIcon);
            RightPanel.Controls.Add(phoneIcon);
            RightPanel.Controls.Add(addressIcon);
            RightPanel.Controls.Add(birthdayIcon);
            RightPanel.Controls.Add(nameIcon);
            RightPanel.Controls.Add(button2);
            RightPanel.Controls.Add(RegisterButton);
            RightPanel.Controls.Add(label1);
            RightPanel.Controls.Add(ExitButton);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(350, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(450, 550);
            RightPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(140, 20);
            label1.Name = "label1";
            label1.Size = new Size(170, 43);
            label1.TabIndex = 1;
            label1.Text = "REGISTER";
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(410, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.SteelBlue;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(50, 450);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(350, 50);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(178, 500);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = false;
            // 
            // nameIcon
            // 
            nameIcon.Image = Properties.Resources.person;
            nameIcon.Location = new Point(50, 90);
            nameIcon.Name = "nameIcon";
            nameIcon.Size = new Size(30, 30);
            nameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            nameIcon.TabIndex = 4;
            nameIcon.TabStop = false;
            // 
            // birthdayIcon
            // 
            birthdayIcon.Image = Properties.Resources.date;
            birthdayIcon.Location = new Point(50, 165);
            birthdayIcon.Name = "birthdayIcon";
            birthdayIcon.Size = new Size(30, 30);
            birthdayIcon.SizeMode = PictureBoxSizeMode.Zoom;
            birthdayIcon.TabIndex = 5;
            birthdayIcon.TabStop = false;
            // 
            // addressIcon
            // 
            addressIcon.Image = Properties.Resources.address;
            addressIcon.Location = new Point(50, 240);
            addressIcon.Name = "addressIcon";
            addressIcon.Size = new Size(30, 30);
            addressIcon.SizeMode = PictureBoxSizeMode.Zoom;
            addressIcon.TabIndex = 6;
            addressIcon.TabStop = false;
            // 
            // phoneIcon
            // 
            phoneIcon.Image = Properties.Resources.phone;
            phoneIcon.Location = new Point(50, 315);
            phoneIcon.Name = "phoneIcon";
            phoneIcon.Size = new Size(30, 30);
            phoneIcon.SizeMode = PictureBoxSizeMode.Zoom;
            phoneIcon.TabIndex = 7;
            phoneIcon.TabStop = false;
            // 
            // passIcon
            // 
            passIcon.Image = Properties.Resources._lock;
            passIcon.Location = new Point(50, 390);
            passIcon.Name = "passIcon";
            passIcon.Size = new Size(30, 30);
            passIcon.SizeMode = PictureBoxSizeMode.Zoom;
            passIcon.TabIndex = 8;
            passIcon.TabStop = false;
            // 
            // div1
            // 
            div1.BackColor = Color.Black;
            div1.Location = new Point(50, 126);
            div1.Name = "div1";
            div1.Size = new Size(350, 1);
            div1.TabIndex = 9;
            // 
            // div2
            // 
            div2.BackColor = Color.Black;
            div2.Location = new Point(50, 201);
            div2.Name = "div2";
            div2.Size = new Size(350, 1);
            div2.TabIndex = 10;
            // 
            // div3
            // 
            div3.BackColor = Color.Black;
            div3.Location = new Point(50, 276);
            div3.Name = "div3";
            div3.Size = new Size(350, 1);
            div3.TabIndex = 11;
            // 
            // div4
            // 
            div4.BackColor = Color.Black;
            div4.Location = new Point(50, 351);
            div4.Name = "div4";
            div4.Size = new Size(350, 1);
            div4.TabIndex = 12;
            // 
            // div5
            // 
            div5.BackColor = Color.Black;
            div5.Location = new Point(50, 426);
            div5.Name = "div5";
            div5.Size = new Size(350, 1);
            div5.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(86, 90);
            txtName.MinimumSize = new Size(314, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 30);
            txtName.TabIndex = 14;
            // 
            // txtBirthday
            // 
            txtBirthday.BorderStyle = BorderStyle.None;
            txtBirthday.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBirthday.Location = new Point(86, 165);
            txtBirthday.MinimumSize = new Size(314, 30);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(314, 30);
            txtBirthday.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(86, 240);
            txtAddress.MinimumSize = new Size(314, 30);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(314, 30);
            txtAddress.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(86, 315);
            txtPhone.MinimumSize = new Size(314, 30);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(314, 30);
            txtPhone.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(86, 390);
            txtPassword.MinimumSize = new Size(314, 30);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 30);
            txtPassword.TabIndex = 18;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.SteelBlue;
            nameLabel.Location = new Point(50, 67);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Name";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdayLabel.ForeColor = Color.SteelBlue;
            birthdayLabel.Location = new Point(50, 142);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(66, 20);
            birthdayLabel.TabIndex = 20;
            birthdayLabel.Text = "Birthday";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressLabel.ForeColor = Color.SteelBlue;
            addressLabel.Location = new Point(50, 217);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(64, 20);
            addressLabel.TabIndex = 21;
            addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLabel.ForeColor = Color.SteelBlue;
            phoneLabel.Location = new Point(50, 292);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(104, 20);
            phoneLabel.TabIndex = 22;
            phoneLabel.Text = "Phone number";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passLabel.ForeColor = Color.SteelBlue;
            passLabel.Location = new Point(50, 367);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(74, 20);
            passLabel.TabIndex = 23;
            passLabel.Text = "Password";
            // 
            // Regiser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            ControlBox = false;
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Regiser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Regiser";
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nameIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)birthdayIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)addressIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)phoneIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)passIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LeftPanel;
        private Panel RightPanel;
        private Button ExitButton;
        private PictureBox Logo;
        private Label Title;
        private Label label1;
        private Button RegisterButton;
        private Button button2;
        private PictureBox nameIcon;
        private PictureBox addressIcon;
        private PictureBox birthdayIcon;
        private PictureBox passIcon;
        private PictureBox phoneIcon;
        private Panel div3;
        private Panel div2;
        private Panel div1;
        private Panel div5;
        private Panel div4;
        private TextBox txtName;
        private TextBox txtBirthday;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private Label nameLabel;
        private Label passLabel;
        private Label phoneLabel;
        private Label addressLabel;
        private Label birthdayLabel;
    }
}