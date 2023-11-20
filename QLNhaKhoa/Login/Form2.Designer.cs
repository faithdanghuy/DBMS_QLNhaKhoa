namespace Login
{
    partial class Form2
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
            DevelopBy = new Label();
            label1 = new Label();
            logo = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            usernameIcon = new PictureBox();
            loginButton = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(DevelopBy);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 575);
            panel1.TabIndex = 0;
            // 
            // DevelopBy
            // 
            DevelopBy.AutoSize = true;
            DevelopBy.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DevelopBy.ForeColor = Color.White;
            DevelopBy.Location = new Point(166, 543);
            DevelopBy.Name = "DevelopBy";
            DevelopBy.Size = new Size(178, 23);
            DevelopBy.TabIndex = 5;
            DevelopBy.Text = "Develop by Group 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 292);
            label1.Name = "label1";
            label1.Size = new Size(186, 63);
            label1.TabIndex = 4;
            label1.Text = "AZURE";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Logo;
            logo.Location = new Point(115, 169);
            logo.Name = "logo";
            logo.Size = new Size(120, 120);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(usernameIcon);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(350, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 575);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._lock;
            pictureBox1.Location = new Point(50, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // usernameIcon
            // 
            usernameIcon.Image = Properties.Resources.person;
            usernameIcon.Location = new Point(50, 213);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(30, 30);
            usernameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            usernameIcon.TabIndex = 12;
            usernameIcon.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SteelBlue;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(50, 400);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(350, 48);
            loginButton.TabIndex = 11;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Tw Cen MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.SteelBlue;
            textBox1.Location = new Point(162, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 47);
            textBox1.TabIndex = 10;
            textBox1.Text = "LOGIN";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("VNI-Lithos", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(410, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(50, 249);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(50, 341);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 1);
            panel4.TabIndex = 7;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(162, 454);
            button2.Name = "button2";
            button2.Size = new Size(133, 29);
            button2.TabIndex = 15;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox logo;
        private Label label1;
        private Label DevelopBy;
        private Button button1;
        private TextBox textBox1;
        private Button loginButton;
        private PictureBox usernameIcon;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Button button2;
    }
}