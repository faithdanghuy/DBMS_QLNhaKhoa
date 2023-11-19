namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BackPanel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            DevelopBy = new Label();
            logo = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            usernameIcon = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            loginButton = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            BackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackPanel1
            // 
            BackPanel1.BackColor = Color.SteelBlue;
            BackPanel1.Controls.Add(label1);
            BackPanel1.Controls.Add(DevelopBy);
            BackPanel1.Controls.Add(logo);
            BackPanel1.Dock = DockStyle.Left;
            BackPanel1.Location = new Point(0, 0);
            BackPanel1.Name = "BackPanel1";
            BackPanel1.Size = new Size(350, 575);
            BackPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(50, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 1);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 292);
            label1.Name = "label1";
            label1.Size = new Size(186, 63);
            label1.TabIndex = 3;
            label1.Text = "AZURE";
            // 
            // DevelopBy
            // 
            DevelopBy.AutoSize = true;
            DevelopBy.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DevelopBy.ForeColor = Color.White;
            DevelopBy.Location = new Point(166, 543);
            DevelopBy.Name = "DevelopBy";
            DevelopBy.Size = new Size(178, 23);
            DevelopBy.TabIndex = 2;
            DevelopBy.Text = "Develop by Group 3";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.Logo;
            logo.Location = new Point(115, 169);
            logo.Name = "logo";
            logo.Size = new Size(120, 120);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._lock;
            pictureBox1.Location = new Point(50, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(84, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 27);
            textBox3.TabIndex = 7;
            // 
            // usernameIcon
            // 
            usernameIcon.Image = Properties.Resources.person;
            usernameIcon.Location = new Point(50, 213);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(30, 30);
            usernameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            usernameIcon.TabIndex = 1;
            usernameIcon.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("VNI-Lithos", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(410, 0);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tw Cen MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.SteelBlue;
            textBox1.Location = new Point(162, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 54);
            textBox1.TabIndex = 3;
            textBox1.Text = "LOGIN";
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
            loginButton.TabIndex = 0;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(usernameIcon);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(loginButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(350, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 575);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(50, 341);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 1);
            panel3.TabIndex = 6;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SteelBlue;
            button2.Location = new Point(279, 270);
            button2.Name = "button2";
            button2.Size = new Size(133, 29);
            button2.TabIndex = 9;
            button2.Text = "Forgot password";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 575);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(BackPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            BackPanel1.ResumeLayout(false);
            BackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel BackPanel1;
        private PictureBox logo;
        private Label DevelopBy;
        private Label label1;
        private Button loginButton;
        private PictureBox usernameIcon;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel2;
        private TextBox textBox1;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private Panel panel3;
    }
}
