namespace PH1
{
    partial class fSuaNhanvien
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
            checkBox_Sodt = new CheckBox();
            checkBox_Diachi = new CheckBox();
            checkBox_Ngaysinh = new CheckBox();
            button1 = new Button();
            textBox_Sodt = new TextBox();
            textBox_Diachi = new TextBox();
            textBox_Ngaysinh = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // checkBox_Sodt
            // 
            checkBox_Sodt.AutoSize = true;
            checkBox_Sodt.Location = new Point(32, 239);
            checkBox_Sodt.Name = "checkBox_Sodt";
            checkBox_Sodt.Size = new Size(116, 19);
            checkBox_Sodt.TabIndex = 41;
            checkBox_Sodt.Text = "Sửa số điện thoại";
            checkBox_Sodt.UseVisualStyleBackColor = true;
            checkBox_Sodt.CheckStateChanged += checkBox_Sodt_CheckStateChanged;
            // 
            // checkBox_Diachi
            // 
            checkBox_Diachi.AutoSize = true;
            checkBox_Diachi.Location = new Point(32, 177);
            checkBox_Diachi.Name = "checkBox_Diachi";
            checkBox_Diachi.Size = new Size(83, 19);
            checkBox_Diachi.TabIndex = 40;
            checkBox_Diachi.Text = "Sửa địa chỉ";
            checkBox_Diachi.UseVisualStyleBackColor = true;
            checkBox_Diachi.CheckStateChanged += CheckBox_Diachi_CheckStateChanged;
            // 
            // checkBox_Ngaysinh
            // 
            checkBox_Ngaysinh.AutoSize = true;
            checkBox_Ngaysinh.Location = new Point(32, 115);
            checkBox_Ngaysinh.Name = "checkBox_Ngaysinh";
            checkBox_Ngaysinh.Size = new Size(99, 19);
            checkBox_Ngaysinh.TabIndex = 39;
            checkBox_Ngaysinh.Text = "Sửa ngày sinh";
            checkBox_Ngaysinh.UseVisualStyleBackColor = true;
            checkBox_Ngaysinh.CheckStateChanged += checkBox_Ngaysinh_CheckStateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(201, 291);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 38;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox_Sodt
            // 
            textBox_Sodt.Location = new Point(176, 239);
            textBox_Sodt.Name = "textBox_Sodt";
            textBox_Sodt.ReadOnly = true;
            textBox_Sodt.Size = new Size(257, 23);
            textBox_Sodt.TabIndex = 37;
            // 
            // textBox_Diachi
            // 
            textBox_Diachi.Location = new Point(176, 175);
            textBox_Diachi.Name = "textBox_Diachi";
            textBox_Diachi.ReadOnly = true;
            textBox_Diachi.Size = new Size(257, 23);
            textBox_Diachi.TabIndex = 36;
            // 
            // textBox_Ngaysinh
            // 
            textBox_Ngaysinh.Location = new Point(176, 113);
            textBox_Ngaysinh.Name = "textBox_Ngaysinh";
            textBox_Ngaysinh.PlaceholderText = "dd/mm/yyyy";
            textBox_Ngaysinh.ReadOnly = true;
            textBox_Ngaysinh.Size = new Size(257, 23);
            textBox_Ngaysinh.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 55);
            label2.Name = "label2";
            label2.Size = new Size(193, 21);
            label2.TabIndex = 34;
            label2.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // fSuaNhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 369);
            Controls.Add(checkBox_Sodt);
            Controls.Add(checkBox_Diachi);
            Controls.Add(checkBox_Ngaysinh);
            Controls.Add(button1);
            Controls.Add(textBox_Sodt);
            Controls.Add(textBox_Diachi);
            Controls.Add(textBox_Ngaysinh);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fSuaNhanvien";
            ShowIcon = false;
            Text = "Chỉnh sửa thông tin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox_Sodt;
        private CheckBox checkBox_Diachi;
        private CheckBox checkBox_Ngaysinh;
        private Button button1;
        private TextBox textBox_Sodt;
        private TextBox textBox_Diachi;
        private TextBox textBox_Ngaysinh;
        private Label label2;
    }
}