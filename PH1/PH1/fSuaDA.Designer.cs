namespace PH1
{
    partial class fSuaDA
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
            checkBox_Phong = new CheckBox();
            checkBox_NgayBD = new CheckBox();
            checkBox_TenDA = new CheckBox();
            button_Capnhat = new Button();
            textBox_NgayBD = new TextBox();
            textBox_TenDA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_Mada = new TextBox();
            comboBox_Phong = new ComboBox();
            SuspendLayout();
            // 
            // checkBox_Phong
            // 
            checkBox_Phong.AutoSize = true;
            checkBox_Phong.Location = new Point(31, 236);
            checkBox_Phong.Name = "checkBox_Phong";
            checkBox_Phong.Size = new Size(83, 19);
            checkBox_Phong.TabIndex = 17;
            checkBox_Phong.Text = "Sửa phòng";
            checkBox_Phong.UseVisualStyleBackColor = true;
            checkBox_Phong.CheckStateChanged += checkBox_Phong_CheckStateChanged;
            // 
            // checkBox_NgayBD
            // 
            checkBox_NgayBD.AutoSize = true;
            checkBox_NgayBD.Location = new Point(31, 174);
            checkBox_NgayBD.Name = "checkBox_NgayBD";
            checkBox_NgayBD.Size = new Size(117, 19);
            checkBox_NgayBD.TabIndex = 16;
            checkBox_NgayBD.Text = "Sửa ngày bắt đầu";
            checkBox_NgayBD.UseVisualStyleBackColor = true;
            checkBox_NgayBD.CheckStateChanged += checkBox_NgayBD_CheckStateChanged;
            // 
            // checkBox_TenDA
            // 
            checkBox_TenDA.AutoSize = true;
            checkBox_TenDA.Location = new Point(31, 112);
            checkBox_TenDA.Name = "checkBox_TenDA";
            checkBox_TenDA.Size = new Size(97, 19);
            checkBox_TenDA.TabIndex = 15;
            checkBox_TenDA.Text = "Sửa tên đề án";
            checkBox_TenDA.UseVisualStyleBackColor = true;
            checkBox_TenDA.CheckStateChanged += checkBox_TenDA_CheckStateChanged;
            // 
            // button_Capnhat
            // 
            button_Capnhat.Location = new Point(200, 288);
            button_Capnhat.Name = "button_Capnhat";
            button_Capnhat.Size = new Size(75, 23);
            button_Capnhat.TabIndex = 14;
            button_Capnhat.Text = "Cập nhật";
            button_Capnhat.UseVisualStyleBackColor = true;
            button_Capnhat.Click += button_Capnhat_Click;
            // 
            // textBox_NgayBD
            // 
            textBox_NgayBD.Location = new Point(175, 172);
            textBox_NgayBD.Name = "textBox_NgayBD";
            textBox_NgayBD.PlaceholderText = "dd/mm/yyyy";
            textBox_NgayBD.ReadOnly = true;
            textBox_NgayBD.Size = new Size(257, 23);
            textBox_NgayBD.TabIndex = 12;
            // 
            // textBox_TenDA
            // 
            textBox_TenDA.Location = new Point(175, 110);
            textBox_TenDA.Name = "textBox_TenDA";
            textBox_TenDA.ReadOnly = true;
            textBox_TenDA.Size = new Size(257, 23);
            textBox_TenDA.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(150, 18);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 10;
            label1.Text = "THÔNG TIN ĐỀ ÁN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 64);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 18;
            label2.Text = "Mã đề án";
            // 
            // textBox_Mada
            // 
            textBox_Mada.Location = new Point(175, 56);
            textBox_Mada.Name = "textBox_Mada";
            textBox_Mada.ReadOnly = true;
            textBox_Mada.Size = new Size(257, 23);
            textBox_Mada.TabIndex = 19;
            // 
            // comboBox_Phong
            // 
            comboBox_Phong.Enabled = false;
            comboBox_Phong.FormattingEnabled = true;
            comboBox_Phong.Location = new Point(175, 234);
            comboBox_Phong.Name = "comboBox_Phong";
            comboBox_Phong.Size = new Size(257, 23);
            comboBox_Phong.TabIndex = 20;
            // 
            // fSuaDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 362);
            Controls.Add(comboBox_Phong);
            Controls.Add(textBox_Mada);
            Controls.Add(label2);
            Controls.Add(checkBox_Phong);
            Controls.Add(checkBox_NgayBD);
            Controls.Add(checkBox_TenDA);
            Controls.Add(button_Capnhat);
            Controls.Add(textBox_NgayBD);
            Controls.Add(textBox_TenDA);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fSuaDA";
            ShowIcon = false;
            Text = "Chỉnh sửa thông tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox_Phong;
        private CheckBox checkBox_NgayBD;
        private CheckBox checkBox_TenDA;
        private Button button_Capnhat;
        private TextBox textBox_Phong;
        private TextBox textBox_NgayBD;
        private TextBox textBox_TenDA;
        private Label label1;
        private Label label2;
        private TextBox textBox_Mada;
        private ComboBox comboBox_Phong;
    }
}