namespace Register
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
            panel1 = new Panel();
            label1 = new Label();
            DevelopBy = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            loginButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DevelopBy);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 575);
            panel1.TabIndex = 0;
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
            // DevelopBy
            // 
            DevelopBy.AutoSize = true;
            DevelopBy.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DevelopBy.ForeColor = Color.White;
            DevelopBy.Location = new Point(166, 543);
            DevelopBy.Name = "DevelopBy";
            DevelopBy.Size = new Size(178, 23);
            DevelopBy.TabIndex = 3;
            DevelopBy.Text = "Develop by Group 3";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(115, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // panel2
            // 
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(350, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 575);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tw Cen MT", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.SteelBlue;
            textBox1.Location = new Point(134, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 54);
            textBox1.TabIndex = 10;
            textBox1.Text = "REGISTER";
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
            loginButton.Text = "Submit";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label DevelopBy;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private TextBox textBox1;
        private Button loginButton;
    }
}
