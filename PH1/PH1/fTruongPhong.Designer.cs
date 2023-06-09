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
            log_out_btn = new Button();
            rolename_label = new Label();
            role = new Label();
            username_label = new Label();
            label9 = new Label();
            EmployeeInterfaceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)infoView).BeginInit();
            SuspendLayout();
            // 
            // employee_info_btn
            // 
            employee_info_btn.BackColor = Color.Aquamarine;
            employee_info_btn.Cursor = Cursors.Hand;
            employee_info_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            employee_info_btn.Location = new Point(405, 76);
            employee_info_btn.Name = "employee_info_btn";
            employee_info_btn.Size = new Size(259, 52);
            employee_info_btn.TabIndex = 8;
            employee_info_btn.Text = "Thông tin các nhân viên";
            employee_info_btn.UseVisualStyleBackColor = false;
            employee_info_btn.Click += employeeInfoBtn_Click;
            // 
            // phancongbtn
            // 
            phancongbtn.BackColor = Color.Aquamarine;
            phancongbtn.Cursor = Cursors.Hand;
            phancongbtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            phancongbtn.Location = new Point(223, 76);
            phancongbtn.Name = "phancongbtn";
            phancongbtn.Size = new Size(176, 52);
            phancongbtn.TabIndex = 9;
            phancongbtn.Text = "Bảng phân công";
            phancongbtn.UseVisualStyleBackColor = false;
            phancongbtn.Click += phancongbtn_Click;
            // 
            // infoView
            // 
            infoView.BackgroundColor = Color.WhiteSmoke;
            infoView.ColumnHeadersHeight = 29;
            infoView.Location = new Point(12, 145);
            infoView.Name = "infoView";
            infoView.RowHeadersWidth = 51;
            infoView.RowTemplate.Height = 29;
            infoView.Size = new Size(997, 456);
            infoView.TabIndex = 10;
            infoView.CellContentClick += infoView_CellContentClick;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.LightSkyBlue;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.Location = new Point(484, 176);
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
            AddBtn.Location = new Point(611, 176);
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
            DeleteBtn.Location = new Point(721, 176);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 41);
            DeleteBtn.TabIndex = 13;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // manvTb
            // 
            manvTb.Location = new Point(487, 265);
            manvTb.Name = "manvTb";
            manvTb.Size = new Size(125, 27);
            manvTb.TabIndex = 14;
            manvTb.TextChanged += manvTb_TextChanged;
            // 
            // madaTb
            // 
            madaTb.Location = new Point(487, 334);
            madaTb.Name = "madaTb";
            madaTb.Size = new Size(125, 27);
            madaTb.TabIndex = 15;
            madaTb.TextChanged += madaTb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 242);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã nhân viên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 311);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 17;
            label2.Text = "Mã đề án";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 378);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 19;
            label3.Text = "Thời gian";
            label3.Click += label3_Click;
            // 
            // thoigianTb
            // 
            thoigianTb.Location = new Point(487, 401);
            thoigianTb.Name = "thoigianTb";
            thoigianTb.Size = new Size(125, 27);
            thoigianTb.TabIndex = 18;
            thoigianTb.TextChanged += thoigianTb_TextChanged;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.LightSkyBlue;
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.Location = new Point(487, 477);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(55, 41);
            SubmitBtn.TabIndex = 20;
            SubmitBtn.Text = "Ok";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += UpdateOKBtn;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(487, 454);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 21;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // AddOkBtn
            // 
            AddOkBtn.BackColor = Color.LightSkyBlue;
            AddOkBtn.Cursor = Cursors.Hand;
            AddOkBtn.Location = new Point(548, 477);
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
            DeleteOkBtn.Location = new Point(609, 477);
            DeleteOkBtn.Name = "DeleteOkBtn";
            DeleteOkBtn.Size = new Size(55, 41);
            DeleteOkBtn.TabIndex = 23;
            DeleteOkBtn.Text = "Ok";
            DeleteOkBtn.UseVisualStyleBackColor = false;
            DeleteOkBtn.Click += DeleteOkBtn_Click;
            // 
            // log_out_btn
            // 
            log_out_btn.BackColor = Color.Salmon;
            log_out_btn.Cursor = Cursors.Hand;
            log_out_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            log_out_btn.Location = new Point(844, 12);
            log_out_btn.Name = "log_out_btn";
            log_out_btn.Size = new Size(165, 50);
            log_out_btn.TabIndex = 37;
            log_out_btn.Text = "Đăng xuất";
            log_out_btn.UseVisualStyleBackColor = false;
            log_out_btn.Click += log_out_btn_Click;
            // 
            // rolename_label
            // 
            rolename_label.AutoSize = true;
            rolename_label.BorderStyle = BorderStyle.Fixed3D;
            rolename_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rolename_label.Location = new Point(291, 29);
            rolename_label.Name = "rolename_label";
            rolename_label.Size = new Size(171, 33);
            rolename_label.TabIndex = 44;
            rolename_label.Text = "Trưởng phòng";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            role.Location = new Point(230, 31);
            role.Name = "role";
            role.Size = new Size(73, 31);
            role.TabIndex = 43;
            role.Text = "Role: ";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BorderStyle = BorderStyle.Fixed3D;
            username_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(74, 31);
            username_label.Name = "username_label";
            username_label.Size = new Size(122, 33);
            username_label.TabIndex = 42;
            username_label.Text = "username";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 31);
            label9.Name = "label9";
            label9.Size = new Size(75, 31);
            label9.TabIndex = 41;
            label9.Text = "User: ";
            // 
            // EmployeeInterfaceButton
            // 
            EmployeeInterfaceButton.BackColor = SystemColors.GradientActiveCaption;
            EmployeeInterfaceButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInterfaceButton.Location = new Point(14, 76);
            EmployeeInterfaceButton.Margin = new Padding(3, 4, 3, 4);
            EmployeeInterfaceButton.Name = "EmployeeInterfaceButton";
            EmployeeInterfaceButton.Size = new Size(202, 51);
            EmployeeInterfaceButton.TabIndex = 45;
            EmployeeInterfaceButton.Text = "Giao diện nhân viên";
            EmployeeInterfaceButton.UseVisualStyleBackColor = false;
            EmployeeInterfaceButton.Click += EmployeeInterfaceButton_Click;
            // 
            // fTruongPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 613);
            Controls.Add(EmployeeInterfaceButton);
            Controls.Add(rolename_label);
            Controls.Add(role);
            Controls.Add(username_label);
            Controls.Add(label9);
            Controls.Add(log_out_btn);
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
            Cursor = Cursors.Hand;
            Name = "fTruongPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTruongPhong";
            ((System.ComponentModel.ISupportInitialize)infoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button log_out_btn;
        private Label rolename_label;
        private Label role;
        private Label username_label;
        private Label label9;
        private Button EmployeeInterfaceButton;
    }
}