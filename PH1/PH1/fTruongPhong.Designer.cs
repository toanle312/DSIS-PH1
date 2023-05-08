using System.Windows.Forms;

namespace PH1
{
    partial class fTruongPhong
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
            personalInfoBtn = new Button();
            employee_info_btn = new Button();
            phancongbtn = new Button();
            infoView = new DataGridView();
            UpdateBtn = new Button();
            AddBtn = new Button();
            DeleteBtn = new Button();
            manvTb = new TextBox();
            madaTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            thoigianTb = new TextBox();
            SubmitBtn = new Button();
            label4 = new Label();
            AddOkBtn = new Button();
            DeleteOkBtn = new Button();
            ngaysinh_textbox = new DateTimePicker();
            sdt_textbox = new TextBox();
            label5 = new Label();
            diachi_textbox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            editbtn = new Button();
            Noti_label = new Label();
            ((System.ComponentModel.ISupportInitialize)infoView).BeginInit();
            SuspendLayout();
            // 
            // personalInfoBtn
            // 
            personalInfoBtn.BackColor = SystemColors.ActiveCaption;
            personalInfoBtn.Cursor = Cursors.Hand;
            personalInfoBtn.Location = new Point(12, 21);
            personalInfoBtn.Name = "personalInfoBtn";
            personalInfoBtn.Size = new Size(121, 41);
            personalInfoBtn.TabIndex = 6;
            personalInfoBtn.Text = "Personal info";
            personalInfoBtn.UseVisualStyleBackColor = false;
            personalInfoBtn.Click += personalInfoBtn_Click;
            // 
            // employee_info_btn
            // 
            employee_info_btn.BackColor = SystemColors.ActiveCaption;
            employee_info_btn.Cursor = Cursors.Hand;
            employee_info_btn.Location = new Point(149, 21);
            employee_info_btn.Name = "employee_info_btn";
            employee_info_btn.Size = new Size(121, 41);
            employee_info_btn.TabIndex = 8;
            employee_info_btn.Text = "Employee info";
            employee_info_btn.UseVisualStyleBackColor = false;
            employee_info_btn.Click += button1_Click;
            // 
            // phancongbtn
            // 
            phancongbtn.BackColor = SystemColors.ActiveCaption;
            phancongbtn.Cursor = Cursors.Hand;
            phancongbtn.Location = new Point(295, 21);
            phancongbtn.Name = "phancongbtn";
            phancongbtn.Size = new Size(121, 41);
            phancongbtn.TabIndex = 9;
            phancongbtn.Text = "Phân công";
            phancongbtn.UseVisualStyleBackColor = false;
            phancongbtn.Click += button2_Click;
            // 
            // infoView
            // 
            infoView.ColumnHeadersHeight = 29;
            infoView.Location = new Point(12, 86);
            infoView.Name = "infoView";
            infoView.RowHeadersWidth = 51;
            infoView.RowTemplate.Height = 29;
            infoView.Size = new Size(960, 329);
            infoView.TabIndex = 10;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.LightSkyBlue;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.Location = new Point(459, 86);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 41);
            UpdateBtn.TabIndex = 11;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(192, 255, 192);
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.Location = new Point(586, 86);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(80, 41);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(255, 192, 128);
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.Location = new Point(696, 86);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 41);
            DeleteBtn.TabIndex = 13;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // manvTb
            // 
            manvTb.Location = new Point(462, 175);
            manvTb.Name = "manvTb";
            manvTb.Size = new Size(125, 27);
            manvTb.TabIndex = 14;
            // 
            // madaTb
            // 
            madaTb.Location = new Point(462, 244);
            madaTb.Name = "madaTb";
            madaTb.Size = new Size(125, 27);
            madaTb.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 152);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 221);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 17;
            label2.Text = "Mã đề án";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 288);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 19;
            label3.Text = "Thời gian";
            // 
            // thoigianTb
            // 
            thoigianTb.Location = new Point(462, 311);
            thoigianTb.Name = "thoigianTb";
            thoigianTb.Size = new Size(125, 27);
            thoigianTb.TabIndex = 18;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.LightSkyBlue;
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.Location = new Point(462, 387);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(55, 41);
            SubmitBtn.TabIndex = 20;
            SubmitBtn.Text = "Ok";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 364);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 21;
            label4.Text = "label4";
            // 
            // AddOkBtn
            // 
            AddOkBtn.BackColor = Color.LightSkyBlue;
            AddOkBtn.Cursor = Cursors.Hand;
            AddOkBtn.Location = new Point(518, 387);
            AddOkBtn.Name = "AddOkBtn";
            AddOkBtn.Size = new Size(55, 41);
            AddOkBtn.TabIndex = 22;
            AddOkBtn.Text = "Ok";
            AddOkBtn.UseVisualStyleBackColor = false;
            AddOkBtn.Click += AddOkBtn_Click;
            // 
            // DeleteOkBtn
            // 
            DeleteOkBtn.BackColor = Color.LightSkyBlue;
            DeleteOkBtn.Cursor = Cursors.Hand;
            DeleteOkBtn.Location = new Point(570, 387);
            DeleteOkBtn.Name = "DeleteOkBtn";
            DeleteOkBtn.Size = new Size(55, 41);
            DeleteOkBtn.TabIndex = 23;
            DeleteOkBtn.Text = "Ok";
            DeleteOkBtn.UseVisualStyleBackColor = false;
            DeleteOkBtn.Click += DeleteOkBtn_Click;
            // 
            // ngaysinh_textbox
            // 
            ngaysinh_textbox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ngaysinh_textbox.Location = new Point(22, 312);
            ngaysinh_textbox.Name = "ngaysinh_textbox";
            ngaysinh_textbox.Size = new Size(210, 32);
            ngaysinh_textbox.TabIndex = 24;
            // 
            // sdt_textbox
            // 
            sdt_textbox.Location = new Point(259, 317);
            sdt_textbox.Name = "sdt_textbox";
            sdt_textbox.Size = new Size(158, 27);
            sdt_textbox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 289);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 30;
            label5.Text = "Số điện thoại";
            // 
            // diachi_textbox
            // 
            diachi_textbox.Location = new Point(22, 383);
            diachi_textbox.Name = "diachi_textbox";
            diachi_textbox.Size = new Size(320, 27);
            diachi_textbox.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 360);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 28;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 289);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 27;
            label7.Text = "Ngày sinh";
            // 
            // label8
            // 
            label8.AutoEllipsis = true;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 240);
            label8.Name = "label8";
            label8.Size = new Size(330, 28);
            label8.TabIndex = 26;
            label8.Text = "Chỉnh sửa thông tin cá nhân";
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.FromArgb(128, 255, 255);
            editbtn.Cursor = Cursors.Hand;
            editbtn.Location = new Point(22, 451);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(121, 41);
            editbtn.TabIndex = 25;
            editbtn.Text = "Edit info";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += button3_Click;
            // 
            // Noti_label
            // 
            Noti_label.AutoSize = true;
            Noti_label.Location = new Point(22, 428);
            Noti_label.Name = "Noti_label";
            Noti_label.Size = new Size(38, 20);
            Noti_label.TabIndex = 32;
            Noti_label.Text = "Noti";
            // 
            // fTruongPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 516);
            Controls.Add(Noti_label);
            Controls.Add(ngaysinh_textbox);
            Controls.Add(sdt_textbox);
            Controls.Add(label5);
            Controls.Add(diachi_textbox);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(editbtn);
            Controls.Add(DeleteOkBtn);
            Controls.Add(AddOkBtn);
            Controls.Add(label4);
            Controls.Add(SubmitBtn);
            Controls.Add(label3);
            Controls.Add(thoigianTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(madaTb);
            Controls.Add(manvTb);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(infoView);
            Controls.Add(phancongbtn);
            Controls.Add(employee_info_btn);
            Controls.Add(personalInfoBtn);
            Name = "fTruongPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTruongPhong";
            ((System.ComponentModel.ISupportInitialize)infoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button personalInfoBtn;
        private Button employee_info_btn;
        private Button phancongbtn;
        private DataGridView infoView;
        private Button UpdateBtn;
        private Button AddBtn;
        private Button DeleteBtn;
        private TextBox manvTb;
        private TextBox madaTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox thoigianTb;
        private Button SubmitBtn;
        private Label label4;
        private Button AddOkBtn;
        private Button DeleteOkBtn;
        private DateTimePicker ngaysinh_textbox;
        private TextBox sdt_textbox;
        private Label label5;
        private TextBox diachi_textbox;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button editbtn;
        private Label Noti_label;
    }
}