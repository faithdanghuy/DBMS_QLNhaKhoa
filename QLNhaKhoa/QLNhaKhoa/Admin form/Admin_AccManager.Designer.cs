namespace QLNhaKhoa.Admin_form
{
    partial class Admin_AccManager
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            deleteAccButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            passwordBox = new TextBox();
            IDBox = new TextBox();
            createAccButton = new Button();
            accountData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(deleteAccButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(createAccButton);
            panel1.Controls.Add(accountData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(690, 298);
            button4.Name = "button4";
            button4.Size = new Size(160, 40);
            button4.TabIndex = 15;
            button4.Text = "Unlock account";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(518, 298);
            button3.Name = "button3";
            button3.Size = new Size(165, 40);
            button3.TabIndex = 14;
            button3.Text = "Suspend account";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(362, 298);
            button2.Name = "button2";
            button2.Size = new Size(150, 40);
            button2.TabIndex = 13;
            button2.Text = "Update account";
            button2.UseVisualStyleBackColor = false;
            // 
            // deleteAccButton
            // 
            deleteAccButton.BackColor = Color.SteelBlue;
            deleteAccButton.FlatAppearance.BorderSize = 0;
            deleteAccButton.FlatStyle = FlatStyle.Flat;
            deleteAccButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteAccButton.ForeColor = Color.White;
            deleteAccButton.Location = new Point(206, 298);
            deleteAccButton.Name = "deleteAccButton";
            deleteAccButton.Size = new Size(150, 40);
            deleteAccButton.TabIndex = 12;
            deleteAccButton.Text = "Delete account";
            deleteAccButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(337, 15);
            label1.Name = "label1";
            label1.Size = new Size(226, 35);
            label1.TabIndex = 7;
            label1.Text = "Account Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(passwordBox);
            panel2.Controls.Add(IDBox);
            panel2.Location = new Point(50, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 250);
            panel2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 94);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 94);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 3;
            label2.Text = "Account ID";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.Location = new Point(450, 120);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(250, 27);
            passwordBox.TabIndex = 1;
            // 
            // IDBox
            // 
            IDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDBox.Location = new Point(100, 120);
            IDBox.Name = "IDBox";
            IDBox.PlaceholderText = "Account ID";
            IDBox.Size = new Size(250, 27);
            IDBox.TabIndex = 0;
            // 
            // createAccButton
            // 
            createAccButton.BackColor = Color.SteelBlue;
            createAccButton.FlatAppearance.BorderSize = 0;
            createAccButton.FlatStyle = FlatStyle.Flat;
            createAccButton.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createAccButton.ForeColor = Color.White;
            createAccButton.Location = new Point(50, 298);
            createAccButton.Name = "createAccButton";
            createAccButton.Size = new Size(150, 40);
            createAccButton.TabIndex = 9;
            createAccButton.Text = "Create account";
            createAccButton.UseVisualStyleBackColor = false;
            // 
            // accountData
            // 
            accountData.BorderStyle = BorderStyle.None;
            accountData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountData.Dock = DockStyle.Bottom;
            accountData.Location = new Point(0, 350);
            accountData.Name = "accountData";
            accountData.RowHeadersWidth = 51;
            accountData.Size = new Size(900, 350);
            accountData.TabIndex = 0;
            accountData.CellClick += accountData_CellClick;
            // 
            // Admin_AccManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_AccManager";
            Text = "Admin_AccManager";
            Load += Admin_AccManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button createAccButton;
        private DataGridView accountData;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox passwordBox;
        private TextBox IDBox;
        private Label label1;
        private Button deleteAccButton;
        private Button button2;
        private Button button4;
        private Button button3;
    }
}