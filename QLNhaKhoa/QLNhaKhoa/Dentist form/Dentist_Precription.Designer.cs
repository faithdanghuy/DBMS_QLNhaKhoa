namespace QLNhaKhoa.Dentist_form
{
    partial class Dentist_Prescription
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
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            addRecordBtn = new Button();
            updateRecordBtn = new Button();
            label1 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            quantityBox = new TextBox();
            medicationIDBox = new TextBox();
            billIDBox = new TextBox();
            recordIDBox = new TextBox();
            recordData = new DataGridView();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 700);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 700);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(addRecordBtn);
            panel3.Controls.Add(updateRecordBtn);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(recordData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(900, 700);
            panel3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(420, 298);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 5;
            button1.Text = "Update prescription";
            button1.UseVisualStyleBackColor = false;
            // 
            // addRecordBtn
            // 
            addRecordBtn.BackColor = Color.SteelBlue;
            addRecordBtn.FlatAppearance.BorderSize = 0;
            addRecordBtn.FlatStyle = FlatStyle.Flat;
            addRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addRecordBtn.ForeColor = Color.White;
            addRecordBtn.Location = new Point(234, 298);
            addRecordBtn.Name = "addRecordBtn";
            addRecordBtn.Size = new Size(180, 40);
            addRecordBtn.TabIndex = 4;
            addRecordBtn.Text = "Delete prescription";
            addRecordBtn.UseVisualStyleBackColor = false;
            // 
            // updateRecordBtn
            // 
            updateRecordBtn.BackColor = Color.SteelBlue;
            updateRecordBtn.FlatAppearance.BorderSize = 0;
            updateRecordBtn.FlatStyle = FlatStyle.Flat;
            updateRecordBtn.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateRecordBtn.ForeColor = Color.White;
            updateRecordBtn.Location = new Point(50, 298);
            updateRecordBtn.Name = "updateRecordBtn";
            updateRecordBtn.Size = new Size(180, 40);
            updateRecordBtn.TabIndex = 3;
            updateRecordBtn.Text = "Add prescription";
            updateRecordBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(314, 20);
            label1.Name = "label1";
            label1.Size = new Size(271, 35);
            label1.TabIndex = 0;
            label1.Text = "Customer Prescription";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(quantityBox);
            panel4.Controls.Add(medicationIDBox);
            panel4.Controls.Add(billIDBox);
            panel4.Controls.Add(recordIDBox);
            panel4.Location = new Point(50, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 250);
            panel4.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(450, 154);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 7;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(100, 154);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 6;
            label4.Text = "Medication ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(450, 54);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 5;
            label3.Text = "Medical Bill ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(100, 54);
            label2.Name = "label2";
            label2.Size = new Size(167, 23);
            label2.TabIndex = 4;
            label2.Text = "Customer Record ID";
            // 
            // quantityBox
            // 
            quantityBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantityBox.Location = new Point(450, 180);
            quantityBox.Name = "quantityBox";
            quantityBox.PlaceholderText = "Quantity";
            quantityBox.Size = new Size(250, 27);
            quantityBox.TabIndex = 3;
            // 
            // medicationIDBox
            // 
            medicationIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            medicationIDBox.Location = new Point(100, 180);
            medicationIDBox.Name = "medicationIDBox";
            medicationIDBox.PlaceholderText = "Medication ID";
            medicationIDBox.Size = new Size(250, 27);
            medicationIDBox.TabIndex = 2;
            // 
            // billIDBox
            // 
            billIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billIDBox.Location = new Point(450, 80);
            billIDBox.Name = "billIDBox";
            billIDBox.PlaceholderText = "Medical Bill ID";
            billIDBox.Size = new Size(250, 27);
            billIDBox.TabIndex = 1;
            // 
            // recordIDBox
            // 
            recordIDBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recordIDBox.Location = new Point(100, 80);
            recordIDBox.Name = "recordIDBox";
            recordIDBox.PlaceholderText = "Customer Record ID";
            recordIDBox.Size = new Size(250, 27);
            recordIDBox.TabIndex = 0;
            // 
            // recordData
            // 
            recordData.BorderStyle = BorderStyle.None;
            recordData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordData.Dock = DockStyle.Bottom;
            recordData.Location = new Point(0, 350);
            recordData.Name = "recordData";
            recordData.RowHeadersWidth = 51;
            recordData.Size = new Size(900, 350);
            recordData.TabIndex = 2;
            // 
            // Dentist_Prescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dentist_Prescription";
            Text = "Dentist_Precription";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button addRecordBtn;
        private Button updateRecordBtn;
        private Label label1;
        private Panel panel4;
        private TextBox recordIDBox;
        private DataGridView recordData;
        private Button button1;
        private TextBox billIDBox;
        private TextBox medicationIDBox;
        private TextBox quantityBox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}