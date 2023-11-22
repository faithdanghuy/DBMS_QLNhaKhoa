namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Bill
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
            addRecordBtn = new Button();
            ExitButton = new Button();
            updateRecordBtn = new Button();
            appointmentData = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(addRecordBtn);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(updateRecordBtn);
            panel1.Controls.Add(appointmentData);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 5;
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = Color.SteelBlue;
            addRecordBtn.FlatAppearance.BorderSize = 0;
            addRecordBtn.FlatStyle = FlatStyle.Flat;
            addRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Location = new Point(206, 398);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(150, 40);
            addRecordBtn.TabIndex = 10;
            addRecordBtn.Text = "Add record";
            addRecordBtn.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("VNI-Lithos", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(860, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 40);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
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
            updateRecordBtn.Size = new Size(150, 40);
            updateRecordBtn.TabIndex = 9;
            updateRecordBtn.Text = "Update record";
            updateRecordBtn.UseVisualStyleBackColor = false;
            // 
            // appointmentData
            // 
            appointmentData.BorderStyle = BorderStyle.None;
            appointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentData.Dock = DockStyle.Bottom;
            appointmentData.Location = new Point(0, 450);
            appointmentData.Name = "appointmentData";
            appointmentData.RowHeadersWidth = 51;
            appointmentData.Size = new Size(900, 250);
            appointmentData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(366, 20);
            label1.Name = "label1";
            label1.Size = new Size(168, 35);
            label1.TabIndex = 6;
            label1.Text = "Customer Bill";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(50, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 350);
            panel2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(216, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // Dentist_Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Bill";
            Text = "Dentist_Bill";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button ExitButton;
        private DataGridView appointmentData;
        private Button addRecordBtn;
        private Button updateRecordBtn;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
    }
}