namespace PH1
{
    partial class fThemDA
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
            textBox_NgayBD = new TextBox();
            textBox_TenDA = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // comboBox_Phong
            // 
            comboBox_Phong.FormattingEnabled = true;
            comboBox_Phong.Location = new Point(164, 252);
            comboBox_Phong.Name = "comboBox_Phong";
            comboBox_Phong.Size = new Size(257, 23);
            comboBox_Phong.TabIndex = 30;
            // 
            // textBox_Mada
            // 
            textBox_Mada.Location = new Point(164, 74);
            textBox_Mada.Name = "textBox_Mada";
            textBox_Mada.Size = new Size(257, 23);
            textBox_Mada.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 28;
            label2.Text = "Mã đề án";
            // 
            // button_Them
            // 
            button_Them.Location = new Point(189, 306);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(75, 23);
            button_Them.TabIndex = 24;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = true;
            button_Them.Click += button_Them_Click;
            // 
            // textBox_NgayBD
            // 
            textBox_NgayBD.Location = new Point(164, 190);
            textBox_NgayBD.Name = "textBox_NgayBD";
            textBox_NgayBD.PlaceholderText = "dd/mm/yyyy";
            textBox_NgayBD.Size = new Size(257, 23);
            textBox_NgayBD.TabIndex = 23;
            // 
            // textBox_TenDA
            // 
            textBox_TenDA.Location = new Point(164, 128);
            textBox_TenDA.Name = "textBox_TenDA";
            textBox_TenDA.Size = new Size(257, 23);
            textBox_TenDA.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 36);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 21;
            label1.Text = "THÔNG TIN ĐỀ ÁN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 131);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 31;
            label3.Text = "Tên đề án";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 193);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 32;
            label4.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 255);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 33;
            label5.Text = "Phòng";
            // 
            // fThemDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 365);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_Phong);
            Controls.Add(textBox_Mada);
            Controls.Add(label2);
            Controls.Add(button_Them);
            Controls.Add(textBox_NgayBD);
            Controls.Add(textBox_TenDA);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fThemDA";
            ShowIcon = false;
            Text = "Thêm đề án";
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
        private TextBox textBox_NgayBD;
        private TextBox textBox_TenDA;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}