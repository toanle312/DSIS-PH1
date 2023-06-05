namespace PH1
{
    partial class fUpdateDA
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
            button_Capnhat = new Button();
            textBox_TenDA = new TextBox();
            label2 = new Label();
            textBox_Mada = new TextBox();
            comboBox_Phong = new ComboBox();
            label1 = new Label();
            dateTimePicker_Ngaybd = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_Capnhat
            // 
            button_Capnhat.BackColor = SystemColors.ActiveCaption;
            button_Capnhat.Location = new Point(200, 320);
            button_Capnhat.Name = "button_Capnhat";
            button_Capnhat.Size = new Size(115, 36);
            button_Capnhat.TabIndex = 14;
            button_Capnhat.Text = "UPDATE";
            button_Capnhat.UseVisualStyleBackColor = false;
            button_Capnhat.Click += button_Capnhat_Click;
            // 
            // textBox_TenDA
            // 
            textBox_TenDA.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_TenDA.Location = new Point(179, 134);
            textBox_TenDA.Name = "textBox_TenDA";
            textBox_TenDA.Size = new Size(315, 27);
            textBox_TenDA.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 18;
            label2.Text = "Project ID";
            // 
            // textBox_Mada
            // 
            textBox_Mada.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Mada.Location = new Point(179, 80);
            textBox_Mada.Name = "textBox_Mada";
            textBox_Mada.ReadOnly = true;
            textBox_Mada.Size = new Size(315, 27);
            textBox_Mada.TabIndex = 19;
            // 
            // comboBox_Phong
            // 
            comboBox_Phong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Phong.FormattingEnabled = true;
            comboBox_Phong.Location = new Point(179, 258);
            comboBox_Phong.Name = "comboBox_Phong";
            comboBox_Phong.Size = new Size(315, 28);
            comboBox_Phong.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(148, 26);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 22;
            label1.Text = "PROJECT INFORMATION";
            // 
            // dateTimePicker_Ngaybd
            // 
            dateTimePicker_Ngaybd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Ngaybd.Location = new Point(179, 198);
            dateTimePicker_Ngaybd.Name = "dateTimePicker_Ngaybd";
            dateTimePicker_Ngaybd.Size = new Size(315, 27);
            dateTimePicker_Ngaybd.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 261);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 36;
            label5.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 203);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 35;
            label4.Text = "Start date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 137);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 34;
            label3.Text = "Project name";
            // 
            // fUpdateDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 378);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker_Ngaybd);
            Controls.Add(label1);
            Controls.Add(comboBox_Phong);
            Controls.Add(textBox_Mada);
            Controls.Add(label2);
            Controls.Add(button_Capnhat);
            Controls.Add(textBox_TenDA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fUpdateDA";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "fUpdateDA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Capnhat;
        private TextBox textBox_Phong;
        private TextBox textBox_TenDA;
        private Label label2;
        private TextBox textBox_Mada;
        private ComboBox comboBox_Phong;
        private Label label1;
        private DateTimePicker dateTimePicker_Ngaybd;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}