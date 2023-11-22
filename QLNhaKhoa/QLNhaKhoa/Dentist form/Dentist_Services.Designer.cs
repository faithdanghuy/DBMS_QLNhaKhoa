namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Services
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
            panel3 = new Panel();
            addRecordBtn = new Button();
            updateRecordBtn = new Button();
            label1 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            recordData = new DataGridView();
            ExitButton = new Button();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(addRecordBtn);
            panel3.Controls.Add(updateRecordBtn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(recordData);
            panel3.Controls.Add(ExitButton);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 8;
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = Color.SteelBlue;
            addRecordBtn.FlatAppearance.BorderSize = 0;
            addRecordBtn.FlatStyle = FlatStyle.Flat;
            addRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Location = new Point(238, 398);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(176, 40);
            addRecordBtn.TabIndex = 4;
            addRecordBtn.Text = "Add prescription";
            addRecordBtn.UseVisualStyleBackColor = false;
            // 
            // updateRecordBtn
            // 
            updateRecordBtn.BackColor = Color.SteelBlue;
            updateRecordBtn.FlatAppearance.BorderSize = 0;
            updateRecordBtn.FlatStyle = FlatStyle.Flat;
            updateRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateRecordBtn.ForeColor = Color.White;
            updateRecordBtn.Location = new Point(50, 398);
            updateRecordBtn.Name = "updateRecordBtn";
            updateRecordBtn.Size = new Size(182, 40);
            updateRecordBtn.TabIndex = 3;
            updateRecordBtn.Text = "Update prescription";
            updateRecordBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(351, 20);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 0;
            label1.Text = "Dental Services";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(50, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 350);
            panel4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // recordData
            // 
            recordData.BorderStyle = BorderStyle.None;
            recordData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordData.Dock = DockStyle.Bottom;
            recordData.Location = new Point(0, 450);
            recordData.Name = "recordData";
            recordData.RowHeadersWidth = 51;
            recordData.Size = new Size(900, 250);
            recordData.TabIndex = 2;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(860, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Dentist_Services
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Services";
            Text = "Dentist_Services";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button addRecordBtn;
        private Button updateRecordBtn;
        private Label label1;
        private Panel panel4;
        private TextBox textBox1;
        private DataGridView recordData;
        private Button ExitButton;
    }
}