namespace PH1
{
    partial class fAddDA
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
            comboBox_Phong = new ComboBox();
            textBox_Mada = new TextBox();
            label2 = new Label();
            button_Them = new Button();
            textBox_TenDA = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker_Ngaybd = new DateTimePicker();
            SuspendLayout();
            // 
            // comboBox_Phong
            // 
            comboBox_Phong.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Phong.FormattingEnabled = true;
            comboBox_Phong.Location = new Point(164, 252);
            comboBox_Phong.Name = "comboBox_Phong";
            comboBox_Phong.Size = new Size(315, 28);
            comboBox_Phong.TabIndex = 30;
            // 
            // textBox_Mada
            // 
            textBox_Mada.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Mada.Location = new Point(164, 74);
            textBox_Mada.Name = "textBox_Mada";
            textBox_Mada.Size = new Size(315, 27);
            textBox_Mada.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 28;
            label2.Text = "Project ID";
            // 
            // button_Them
            // 
            button_Them.BackColor = SystemColors.ActiveCaption;
            button_Them.Location = new Point(199, 309);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(115, 36);
            button_Them.TabIndex = 24;
            button_Them.Text = "ADD";
            button_Them.UseVisualStyleBackColor = false;
            button_Them.Click += button_Them_Click;
            // 
            // textBox_TenDA
            // 
            textBox_TenDA.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_TenDA.Location = new Point(164, 131);
            textBox_TenDA.Name = "textBox_TenDA";
            textBox_TenDA.Size = new Size(315, 27);
            textBox_TenDA.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(144, 22);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 21;
            label1.Text = "PROJECT INFORMATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 134);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 31;
            label3.Text = "Project name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(41, 196);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 32;
            label4.Text = "Start date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 255);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 33;
            label5.Text = "Department";
            // 
            // dateTimePicker_Ngaybd
            // 
            dateTimePicker_Ngaybd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Ngaybd.Location = new Point(164, 191);
            dateTimePicker_Ngaybd.Name = "dateTimePicker_Ngaybd";
            dateTimePicker_Ngaybd.Size = new Size(315, 27);
            dateTimePicker_Ngaybd.TabIndex = 34;
            // 
            // fAddDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 369);
            Controls.Add(dateTimePicker_Ngaybd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_Phong);
            Controls.Add(textBox_Mada);
            Controls.Add(label2);
            Controls.Add(button_Them);
            Controls.Add(textBox_TenDA);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fAddDA";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "fAddDA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_Phong;
        private TextBox textBox_Mada;
        private Label label2;
        private CheckBox checkBox_Phong;
        private CheckBox checkBox_NgayBD;
        private CheckBox checkBox_TenDA;
        private Button button_Them;
        private TextBox textBox_TenDA;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker_Ngaybd;
    }
}