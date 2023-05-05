namespace PH1
{
    partial class fNhanSu
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
            DeptGroupBox = new GroupBox();
            UpdateDeptButton = new Button();
            AddDeptButton = new Button();
            DeptLeaderTextBox = new TextBox();
            DeptLeaderLabel = new Label();
            DeptNameTextBox = new TextBox();
            DeptNameLabel = new Label();
            DeptIdTextBox = new TextBox();
            DeptIdLabel = new Label();
            DataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            BirthDatePicker = new DateTimePicker();
            UpdateEmpButton = new Button();
            ViewEmpButton = new Button();
            DeptTextBox = new TextBox();
            DeptLabel = new Label();
            ManagerIdTextBox = new TextBox();
            ManagerIdLabel = new Label();
            RoleTextBox = new TextBox();
            RoleLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            AddressLabel = new Label();
            BirthDateLabel = new Label();
            GenderLabel = new Label();
            EmpNameTextBox = new TextBox();
            EmpNameLabel = new Label();
            EmpIdTextBox = new TextBox();
            EmpIdLabel = new Label();
            comboBox1 = new ComboBox();
            richTextBox1 = new RichTextBox();
            DeptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DeptGroupBox
            // 
            DeptGroupBox.Controls.Add(UpdateDeptButton);
            DeptGroupBox.Controls.Add(AddDeptButton);
            DeptGroupBox.Controls.Add(DeptLeaderTextBox);
            DeptGroupBox.Controls.Add(DeptLeaderLabel);
            DeptGroupBox.Controls.Add(DeptNameTextBox);
            DeptGroupBox.Controls.Add(DeptNameLabel);
            DeptGroupBox.Controls.Add(DeptIdTextBox);
            DeptGroupBox.Controls.Add(DeptIdLabel);
            DeptGroupBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            DeptGroupBox.Location = new Point(12, 38);
            DeptGroupBox.Name = "DeptGroupBox";
            DeptGroupBox.Size = new Size(776, 90);
            DeptGroupBox.TabIndex = 0;
            DeptGroupBox.TabStop = false;
            DeptGroupBox.Text = "Trên quan hệ phòng ban";
            // 
            // UpdateDeptButton
            // 
            UpdateDeptButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateDeptButton.Location = new Point(614, 48);
            UpdateDeptButton.Name = "UpdateDeptButton";
            UpdateDeptButton.Size = new Size(146, 30);
            UpdateDeptButton.TabIndex = 14;
            UpdateDeptButton.Text = "Chỉnh sửa";
            UpdateDeptButton.UseVisualStyleBackColor = true;
            UpdateDeptButton.Click += UpdateDeptButton_Click;
            // 
            // AddDeptButton
            // 
            AddDeptButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddDeptButton.Location = new Point(462, 48);
            AddDeptButton.Name = "AddDeptButton";
            AddDeptButton.Size = new Size(146, 30);
            AddDeptButton.TabIndex = 13;
            AddDeptButton.Text = "Thêm";
            AddDeptButton.UseVisualStyleBackColor = true;
            AddDeptButton.Click += AddDeptButton_Click;
            // 
            // DeptLeaderTextBox
            // 
            DeptLeaderTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptLeaderTextBox.Location = new Point(310, 50);
            DeptLeaderTextBox.Name = "DeptLeaderTextBox";
            DeptLeaderTextBox.Size = new Size(146, 27);
            DeptLeaderTextBox.TabIndex = 11;
            // 
            // DeptLeaderLabel
            // 
            DeptLeaderLabel.AutoSize = true;
            DeptLeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptLeaderLabel.Location = new Point(310, 27);
            DeptLeaderLabel.Name = "DeptLeaderLabel";
            DeptLeaderLabel.Size = new Size(103, 20);
            DeptLeaderLabel.TabIndex = 12;
            DeptLeaderLabel.Text = "Trưởng phòng";
            // 
            // DeptNameTextBox
            // 
            DeptNameTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptNameTextBox.Location = new Point(158, 50);
            DeptNameTextBox.Name = "DeptNameTextBox";
            DeptNameTextBox.Size = new Size(146, 27);
            DeptNameTextBox.TabIndex = 9;
            // 
            // DeptNameLabel
            // 
            DeptNameLabel.AutoSize = true;
            DeptNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptNameLabel.Location = new Point(158, 27);
            DeptNameLabel.Name = "DeptNameLabel";
            DeptNameLabel.Size = new Size(108, 20);
            DeptNameLabel.TabIndex = 10;
            DeptNameLabel.Text = "Tên phòng ban";
            // 
            // DeptIdTextBox
            // 
            DeptIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptIdTextBox.Location = new Point(6, 50);
            DeptIdTextBox.Name = "DeptIdTextBox";
            DeptIdTextBox.Size = new Size(146, 27);
            DeptIdTextBox.TabIndex = 7;
            // 
            // DeptIdLabel
            // 
            DeptIdLabel.AutoSize = true;
            DeptIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptIdLabel.Location = new Point(6, 27);
            DeptIdLabel.Name = "DeptIdLabel";
            DeptIdLabel.Size = new Size(106, 20);
            DeptIdLabel.TabIndex = 8;
            DeptIdLabel.Text = "Mã phòng ban";
            // 
            // DataGridView
            // 
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 315);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(776, 240);
            DataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(BirthDatePicker);
            groupBox1.Controls.Add(UpdateEmpButton);
            groupBox1.Controls.Add(ViewEmpButton);
            groupBox1.Controls.Add(DeptTextBox);
            groupBox1.Controls.Add(DeptLabel);
            groupBox1.Controls.Add(ManagerIdTextBox);
            groupBox1.Controls.Add(ManagerIdLabel);
            groupBox1.Controls.Add(RoleTextBox);
            groupBox1.Controls.Add(RoleLabel);
            groupBox1.Controls.Add(PhoneTextBox);
            groupBox1.Controls.Add(PhoneLabel);
            groupBox1.Controls.Add(AddressLabel);
            groupBox1.Controls.Add(BirthDateLabel);
            groupBox1.Controls.Add(GenderLabel);
            groupBox1.Controls.Add(EmpNameTextBox);
            groupBox1.Controls.Add(EmpNameLabel);
            groupBox1.Controls.Add(EmpIdTextBox);
            groupBox1.Controls.Add(EmpIdLabel);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 175);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trên quan hệ nhân viên";
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDatePicker.CustomFormat = "dd/MM/yyyy";
            BirthDatePicker.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDatePicker.Format = DateTimePickerFormat.Custom;
            BirthDatePicker.Location = new Point(414, 51);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(130, 27);
            BirthDatePicker.TabIndex = 34;
            BirthDatePicker.Value = new DateTime(2023, 5, 5, 22, 41, 0, 0);
            // 
            // UpdateEmpButton
            // 
            UpdateEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateEmpButton.Location = new Point(6, 137);
            UpdateEmpButton.Name = "UpdateEmpButton";
            UpdateEmpButton.Size = new Size(130, 30);
            UpdateEmpButton.TabIndex = 33;
            UpdateEmpButton.Text = "Chỉnh sửa";
            UpdateEmpButton.UseVisualStyleBackColor = true;
            // 
            // ViewEmpButton
            // 
            ViewEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewEmpButton.Location = new Point(142, 137);
            ViewEmpButton.Name = "ViewEmpButton";
            ViewEmpButton.Size = new Size(130, 30);
            ViewEmpButton.TabIndex = 31;
            ViewEmpButton.Text = "Xem nhân viên";
            ViewEmpButton.UseVisualStyleBackColor = true;
            // 
            // DeptTextBox
            // 
            DeptTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptTextBox.Location = new Point(414, 104);
            DeptTextBox.Name = "DeptTextBox";
            DeptTextBox.Size = new Size(130, 27);
            DeptTextBox.TabIndex = 29;
            // 
            // DeptLabel
            // 
            DeptLabel.AutoSize = true;
            DeptLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptLabel.Location = new Point(414, 81);
            DeptLabel.Name = "DeptLabel";
            DeptLabel.Size = new Size(51, 20);
            DeptLabel.TabIndex = 30;
            DeptLabel.Text = "Phòng";
            // 
            // ManagerIdTextBox
            // 
            ManagerIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ManagerIdTextBox.Location = new Point(278, 104);
            ManagerIdTextBox.Name = "ManagerIdTextBox";
            ManagerIdTextBox.Size = new Size(130, 27);
            ManagerIdTextBox.TabIndex = 27;
            // 
            // ManagerIdLabel
            // 
            ManagerIdLabel.AutoSize = true;
            ManagerIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ManagerIdLabel.Location = new Point(278, 81);
            ManagerIdLabel.Name = "ManagerIdLabel";
            ManagerIdLabel.Size = new Size(125, 20);
            ManagerIdLabel.TabIndex = 28;
            ManagerIdLabel.Text = "Mã người quản lý";
            // 
            // RoleTextBox
            // 
            RoleTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RoleTextBox.Location = new Point(142, 104);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.Size = new Size(130, 27);
            RoleTextBox.TabIndex = 25;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RoleLabel.Location = new Point(142, 81);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(52, 20);
            RoleLabel.TabIndex = 26;
            RoleLabel.Text = "Vai trò";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTextBox.Location = new Point(6, 104);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(130, 27);
            PhoneTextBox.TabIndex = 23;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneLabel.Location = new Point(6, 81);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(97, 20);
            PhoneLabel.TabIndex = 24;
            PhoneLabel.Text = "Số điện thoại";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(550, 29);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(55, 20);
            AddressLabel.TabIndex = 22;
            AddressLabel.Text = "Địa chỉ";
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDateLabel.Location = new Point(414, 27);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(74, 20);
            BirthDateLabel.TabIndex = 20;
            BirthDateLabel.Text = "Ngày sinh";
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            GenderLabel.Location = new Point(278, 28);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(37, 20);
            GenderLabel.TabIndex = 18;
            GenderLabel.Text = "Phái";
            // 
            // EmpNameTextBox
            // 
            EmpNameTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTextBox.Location = new Point(142, 51);
            EmpNameTextBox.Name = "EmpNameTextBox";
            EmpNameTextBox.Size = new Size(130, 27);
            EmpNameTextBox.TabIndex = 15;
            // 
            // EmpNameLabel
            // 
            EmpNameLabel.AutoSize = true;
            EmpNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameLabel.Location = new Point(142, 28);
            EmpNameLabel.Name = "EmpNameLabel";
            EmpNameLabel.Size = new Size(99, 20);
            EmpNameLabel.TabIndex = 16;
            EmpNameLabel.Text = "Tên nhân viên";
            // 
            // EmpIdTextBox
            // 
            EmpIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdTextBox.Location = new Point(6, 51);
            EmpIdTextBox.Name = "EmpIdTextBox";
            EmpIdTextBox.Size = new Size(130, 27);
            EmpIdTextBox.TabIndex = 13;
            // 
            // EmpIdLabel
            // 
            EmpIdLabel.AutoSize = true;
            EmpIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdLabel.Location = new Point(6, 28);
            EmpIdLabel.Name = "EmpIdLabel";
            EmpIdLabel.Size = new Size(97, 20);
            EmpIdLabel.TabIndex = 14;
            EmpIdLabel.Text = "Mã nhân viên";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nam", "Nữ" });
            comboBox1.Location = new Point(278, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(130, 28);
            comboBox1.TabIndex = 35;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(550, 51);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(210, 80);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // fNhanSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(groupBox1);
            Controls.Add(DataGridView);
            Controls.Add(DeptGroupBox);
            Name = "fNhanSu";
            Text = "fNhanSu";
            DeptGroupBox.ResumeLayout(false);
            DeptGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DeptGroupBox;
        private TextBox DeptLeaderTextBox;
        private Label DeptLeaderLabel;
        private TextBox DeptNameTextBox;
        private Label DeptNameLabel;
        private TextBox DeptIdTextBox;
        private Label DeptIdLabel;
        private Button AddDeptButton;
        private Button UpdateDeptButton;
        private DataGridView DataGridView;
        private GroupBox groupBox1;
        private TextBox DeptTextBox;
        private Label DeptLabel;
        private TextBox ManagerIdTextBox;
        private Label ManagerIdLabel;
        private TextBox RoleTextBox;
        private Label RoleLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private Label AddressLabel;
        private Label BirthDateLabel;
        private Label GenderLabel;
        private TextBox EmpNameTextBox;
        private Label EmpNameLabel;
        private TextBox EmpIdTextBox;
        private Label EmpIdLabel;
        private Button ViewEmpButton;
        private Button UpdateEmpButton;
        private DateTimePicker BirthDatePicker;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
    }
}