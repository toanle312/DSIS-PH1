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
            ViewDeptButton = new Button();
            UpdateDeptButton = new Button();
            AddDeptButton = new Button();
            DeptLeaderTextBox = new TextBox();
            DeptLeaderLabel = new Label();
            DeptNameTextBox = new TextBox();
            DeptNameLabel = new Label();
            DeptIdTextBox = new TextBox();
            DeptIdLabel = new Label();
            DataGridView = new DataGridView();
            EmpGroupBox = new GroupBox();
            EmpAddressRichTextBox = new RichTextBox();
            EmpGenderComboBox = new ComboBox();
            EmpBirthDatePicker = new DateTimePicker();
            UpdateEmpButton = new Button();
            ViewEmpButton = new Button();
            EmpDeptTextBox = new TextBox();
            EmpDeptLabel = new Label();
            EmpManagerIdTextBox = new TextBox();
            EmpManagerIdLabel = new Label();
            EmpRoleTextBox = new TextBox();
            EmpRoleLabel = new Label();
            EmpPhoneTextBox = new TextBox();
            EmpPhoneLabel = new Label();
            AddressLabel = new Label();
            EmpBirthDateLabel = new Label();
            EmpGenderLabel = new Label();
            EmpNameTextBox = new TextBox();
            EmpNameLabel = new Label();
            EmpIdTextBox = new TextBox();
            EmpIdLabel = new Label();
            RoleLabel = new Label();
            IDLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            EmployeeInterfaceButton = new Button();
            LogOutButton = new Button();
            DeptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            EmpGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DeptGroupBox
            // 
            DeptGroupBox.Controls.Add(ViewDeptButton);
            DeptGroupBox.Controls.Add(UpdateDeptButton);
            DeptGroupBox.Controls.Add(AddDeptButton);
            DeptGroupBox.Controls.Add(DeptLeaderTextBox);
            DeptGroupBox.Controls.Add(DeptLeaderLabel);
            DeptGroupBox.Controls.Add(DeptNameTextBox);
            DeptGroupBox.Controls.Add(DeptNameLabel);
            DeptGroupBox.Controls.Add(DeptIdTextBox);
            DeptGroupBox.Controls.Add(DeptIdLabel);
            DeptGroupBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            DeptGroupBox.Location = new Point(14, 47);
            DeptGroupBox.Margin = new Padding(3, 4, 3, 4);
            DeptGroupBox.Name = "DeptGroupBox";
            DeptGroupBox.Padding = new Padding(3, 4, 3, 4);
            DeptGroupBox.Size = new Size(887, 124);
            DeptGroupBox.TabIndex = 0;
            DeptGroupBox.TabStop = false;
            DeptGroupBox.Text = "Trên quan hệ phòng ban";
            // 
            // ViewDeptButton
            // 
            ViewDeptButton.BackColor = Color.Aquamarine;
            ViewDeptButton.Cursor = Cursors.Hand;
            ViewDeptButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewDeptButton.Location = new Point(528, 23);
            ViewDeptButton.Margin = new Padding(3, 4, 3, 4);
            ViewDeptButton.Name = "ViewDeptButton";
            ViewDeptButton.Size = new Size(341, 40);
            ViewDeptButton.TabIndex = 15;
            ViewDeptButton.Text = "Xem danh sách phòng ban";
            ViewDeptButton.UseVisualStyleBackColor = false;
            ViewDeptButton.Click += ViewDeptButton_Click;
            // 
            // UpdateDeptButton
            // 
            UpdateDeptButton.BackColor = Color.Aquamarine;
            UpdateDeptButton.Cursor = Cursors.Hand;
            UpdateDeptButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateDeptButton.Location = new Point(702, 63);
            UpdateDeptButton.Margin = new Padding(3, 4, 3, 4);
            UpdateDeptButton.Name = "UpdateDeptButton";
            UpdateDeptButton.Size = new Size(167, 40);
            UpdateDeptButton.TabIndex = 14;
            UpdateDeptButton.Text = "Chỉnh sửa";
            UpdateDeptButton.UseVisualStyleBackColor = false;
            UpdateDeptButton.Click += UpdateDeptButton_Click;
            // 
            // AddDeptButton
            // 
            AddDeptButton.BackColor = Color.Aquamarine;
            AddDeptButton.Cursor = Cursors.Hand;
            AddDeptButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddDeptButton.Location = new Point(528, 64);
            AddDeptButton.Margin = new Padding(3, 4, 3, 4);
            AddDeptButton.Name = "AddDeptButton";
            AddDeptButton.Size = new Size(167, 40);
            AddDeptButton.TabIndex = 13;
            AddDeptButton.Text = "Thêm";
            AddDeptButton.UseVisualStyleBackColor = false;
            AddDeptButton.Click += AddDeptButton_Click;
            // 
            // DeptLeaderTextBox
            // 
            DeptLeaderTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptLeaderTextBox.Location = new Point(354, 67);
            DeptLeaderTextBox.Margin = new Padding(3, 4, 3, 4);
            DeptLeaderTextBox.Name = "DeptLeaderTextBox";
            DeptLeaderTextBox.Size = new Size(166, 32);
            DeptLeaderTextBox.TabIndex = 11;
            // 
            // DeptLeaderLabel
            // 
            DeptLeaderLabel.AutoSize = true;
            DeptLeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptLeaderLabel.Location = new Point(354, 36);
            DeptLeaderLabel.Name = "DeptLeaderLabel";
            DeptLeaderLabel.Size = new Size(131, 25);
            DeptLeaderLabel.TabIndex = 12;
            DeptLeaderLabel.Text = "Trưởng phòng";
            // 
            // DeptNameTextBox
            // 
            DeptNameTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptNameTextBox.Location = new Point(181, 67);
            DeptNameTextBox.Margin = new Padding(3, 4, 3, 4);
            DeptNameTextBox.Name = "DeptNameTextBox";
            DeptNameTextBox.Size = new Size(166, 32);
            DeptNameTextBox.TabIndex = 9;
            // 
            // DeptNameLabel
            // 
            DeptNameLabel.AutoSize = true;
            DeptNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptNameLabel.Location = new Point(181, 36);
            DeptNameLabel.Name = "DeptNameLabel";
            DeptNameLabel.Size = new Size(138, 25);
            DeptNameLabel.TabIndex = 10;
            DeptNameLabel.Text = "Tên phòng ban";
            // 
            // DeptIdTextBox
            // 
            DeptIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptIdTextBox.Location = new Point(7, 67);
            DeptIdTextBox.Margin = new Padding(3, 4, 3, 4);
            DeptIdTextBox.Name = "DeptIdTextBox";
            DeptIdTextBox.Size = new Size(166, 32);
            DeptIdTextBox.TabIndex = 7;
            // 
            // DeptIdLabel
            // 
            DeptIdLabel.AutoSize = true;
            DeptIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DeptIdLabel.Location = new Point(7, 36);
            DeptIdLabel.Name = "DeptIdLabel";
            DeptIdLabel.Size = new Size(136, 25);
            DeptIdLabel.TabIndex = 8;
            DeptIdLabel.Text = "Mã phòng ban";
            // 
            // DataGridView
            // 
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(14, 420);
            DataGridView.Margin = new Padding(3, 4, 3, 4);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(887, 320);
            DataGridView.TabIndex = 1;
            // 
            // EmpGroupBox
            // 
            EmpGroupBox.Controls.Add(EmpAddressRichTextBox);
            EmpGroupBox.Controls.Add(EmpGenderComboBox);
            EmpGroupBox.Controls.Add(EmpBirthDatePicker);
            EmpGroupBox.Controls.Add(UpdateEmpButton);
            EmpGroupBox.Controls.Add(ViewEmpButton);
            EmpGroupBox.Controls.Add(EmpDeptTextBox);
            EmpGroupBox.Controls.Add(EmpDeptLabel);
            EmpGroupBox.Controls.Add(EmpManagerIdTextBox);
            EmpGroupBox.Controls.Add(EmpManagerIdLabel);
            EmpGroupBox.Controls.Add(EmpRoleTextBox);
            EmpGroupBox.Controls.Add(EmpRoleLabel);
            EmpGroupBox.Controls.Add(EmpPhoneTextBox);
            EmpGroupBox.Controls.Add(EmpPhoneLabel);
            EmpGroupBox.Controls.Add(AddressLabel);
            EmpGroupBox.Controls.Add(EmpBirthDateLabel);
            EmpGroupBox.Controls.Add(EmpGenderLabel);
            EmpGroupBox.Controls.Add(EmpNameTextBox);
            EmpGroupBox.Controls.Add(EmpNameLabel);
            EmpGroupBox.Controls.Add(EmpIdTextBox);
            EmpGroupBox.Controls.Add(EmpIdLabel);
            EmpGroupBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            EmpGroupBox.Location = new Point(14, 179);
            EmpGroupBox.Margin = new Padding(3, 4, 3, 4);
            EmpGroupBox.Name = "EmpGroupBox";
            EmpGroupBox.Padding = new Padding(3, 4, 3, 4);
            EmpGroupBox.Size = new Size(887, 233);
            EmpGroupBox.TabIndex = 2;
            EmpGroupBox.TabStop = false;
            EmpGroupBox.Text = "Trên quan hệ nhân viên";
            // 
            // EmpAddressRichTextBox
            // 
            EmpAddressRichTextBox.Location = new Point(629, 68);
            EmpAddressRichTextBox.Margin = new Padding(3, 4, 3, 4);
            EmpAddressRichTextBox.Name = "EmpAddressRichTextBox";
            EmpAddressRichTextBox.Size = new Size(239, 153);
            EmpAddressRichTextBox.TabIndex = 3;
            EmpAddressRichTextBox.Text = "";
            // 
            // EmpGenderComboBox
            // 
            EmpGenderComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpGenderComboBox.FormattingEnabled = true;
            EmpGenderComboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            EmpGenderComboBox.Location = new Point(318, 68);
            EmpGenderComboBox.Margin = new Padding(3, 4, 3, 4);
            EmpGenderComboBox.Name = "EmpGenderComboBox";
            EmpGenderComboBox.Size = new Size(148, 33);
            EmpGenderComboBox.TabIndex = 35;
            // 
            // EmpBirthDatePicker
            // 
            EmpBirthDatePicker.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpBirthDatePicker.CustomFormat = "dd/MM/yyyy";
            EmpBirthDatePicker.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpBirthDatePicker.Format = DateTimePickerFormat.Custom;
            EmpBirthDatePicker.Location = new Point(473, 68);
            EmpBirthDatePicker.Margin = new Padding(3, 4, 3, 4);
            EmpBirthDatePicker.Name = "EmpBirthDatePicker";
            EmpBirthDatePicker.Size = new Size(148, 32);
            EmpBirthDatePicker.TabIndex = 34;
            EmpBirthDatePicker.Value = new DateTime(2023, 5, 5, 22, 41, 0, 0);
            // 
            // UpdateEmpButton
            // 
            UpdateEmpButton.BackColor = Color.Chartreuse;
            UpdateEmpButton.Cursor = Cursors.Hand;
            UpdateEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateEmpButton.Location = new Point(318, 185);
            UpdateEmpButton.Margin = new Padding(3, 4, 3, 4);
            UpdateEmpButton.Name = "UpdateEmpButton";
            UpdateEmpButton.Size = new Size(304, 40);
            UpdateEmpButton.TabIndex = 33;
            UpdateEmpButton.Text = "Chỉnh sửa nhân viên";
            UpdateEmpButton.UseVisualStyleBackColor = false;
            UpdateEmpButton.Click += UpdateEmpButton_Click;
            // 
            // ViewEmpButton
            // 
            ViewEmpButton.BackColor = Color.Chartreuse;
            ViewEmpButton.Cursor = Cursors.Hand;
            ViewEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewEmpButton.Location = new Point(7, 183);
            ViewEmpButton.Margin = new Padding(3, 4, 3, 4);
            ViewEmpButton.Name = "ViewEmpButton";
            ViewEmpButton.Size = new Size(304, 40);
            ViewEmpButton.TabIndex = 31;
            ViewEmpButton.Text = "Xem danh sách nhân viên";
            ViewEmpButton.UseVisualStyleBackColor = false;
            ViewEmpButton.Click += ViewEmpButton_Click;
            // 
            // EmpDeptTextBox
            // 
            EmpDeptTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpDeptTextBox.Location = new Point(473, 139);
            EmpDeptTextBox.Margin = new Padding(3, 4, 3, 4);
            EmpDeptTextBox.Name = "EmpDeptTextBox";
            EmpDeptTextBox.Size = new Size(148, 32);
            EmpDeptTextBox.TabIndex = 29;
            // 
            // EmpDeptLabel
            // 
            EmpDeptLabel.AutoSize = true;
            EmpDeptLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpDeptLabel.Location = new Point(473, 108);
            EmpDeptLabel.Name = "EmpDeptLabel";
            EmpDeptLabel.Size = new Size(67, 25);
            EmpDeptLabel.TabIndex = 30;
            EmpDeptLabel.Text = "Phòng";
            // 
            // EmpManagerIdTextBox
            // 
            EmpManagerIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpManagerIdTextBox.Location = new Point(318, 139);
            EmpManagerIdTextBox.Margin = new Padding(3, 4, 3, 4);
            EmpManagerIdTextBox.Name = "EmpManagerIdTextBox";
            EmpManagerIdTextBox.Size = new Size(148, 32);
            EmpManagerIdTextBox.TabIndex = 27;
            // 
            // EmpManagerIdLabel
            // 
            EmpManagerIdLabel.AutoSize = true;
            EmpManagerIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpManagerIdLabel.Location = new Point(318, 108);
            EmpManagerIdLabel.Name = "EmpManagerIdLabel";
            EmpManagerIdLabel.Size = new Size(160, 25);
            EmpManagerIdLabel.TabIndex = 28;
            EmpManagerIdLabel.Text = "Mã người quản lý";
            // 
            // EmpRoleTextBox
            // 
            EmpRoleTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpRoleTextBox.Location = new Point(162, 139);
            EmpRoleTextBox.Margin = new Padding(3, 4, 3, 4);
            EmpRoleTextBox.Name = "EmpRoleTextBox";
            EmpRoleTextBox.Size = new Size(148, 32);
            EmpRoleTextBox.TabIndex = 25;
            // 
            // EmpRoleLabel
            // 
            EmpRoleLabel.AutoSize = true;
            EmpRoleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpRoleLabel.Location = new Point(162, 108);
            EmpRoleLabel.Name = "EmpRoleLabel";
            EmpRoleLabel.Size = new Size(67, 25);
            EmpRoleLabel.TabIndex = 26;
            EmpRoleLabel.Text = "Vai trò";
            // 
            // EmpPhoneTextBox
            // 
            EmpPhoneTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpPhoneTextBox.Location = new Point(7, 139);
            EmpPhoneTextBox.Margin = new Padding(3, 4, 3, 4);
            EmpPhoneTextBox.Name = "EmpPhoneTextBox";
            EmpPhoneTextBox.Size = new Size(148, 32);
            EmpPhoneTextBox.TabIndex = 23;
            EmpPhoneTextBox.KeyPress += EmpPhoneTextBox_KeyPress;
            // 
            // EmpPhoneLabel
            // 
            EmpPhoneLabel.AutoSize = true;
            EmpPhoneLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpPhoneLabel.Location = new Point(7, 108);
            EmpPhoneLabel.Name = "EmpPhoneLabel";
            EmpPhoneLabel.Size = new Size(123, 25);
            EmpPhoneLabel.TabIndex = 24;
            EmpPhoneLabel.Text = "Số điện thoại";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AddressLabel.Location = new Point(629, 39);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(70, 25);
            AddressLabel.TabIndex = 22;
            AddressLabel.Text = "Địa chỉ";
            // 
            // EmpBirthDateLabel
            // 
            EmpBirthDateLabel.AutoSize = true;
            EmpBirthDateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpBirthDateLabel.Location = new Point(473, 36);
            EmpBirthDateLabel.Name = "EmpBirthDateLabel";
            EmpBirthDateLabel.Size = new Size(96, 25);
            EmpBirthDateLabel.TabIndex = 20;
            EmpBirthDateLabel.Text = "Ngày sinh";
            // 
            // EmpGenderLabel
            // 
            EmpGenderLabel.AutoSize = true;
            EmpGenderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpGenderLabel.Location = new Point(318, 37);
            EmpGenderLabel.Name = "EmpGenderLabel";
            EmpGenderLabel.Size = new Size(49, 25);
            EmpGenderLabel.TabIndex = 18;
            EmpGenderLabel.Text = "Phái";
            // 
            // EmpNameTextBox
            // 
            EmpNameTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTextBox.Location = new Point(162, 68);
            EmpNameTextBox.Margin = new Padding(3, 4, 3, 4);
            EmpNameTextBox.Name = "EmpNameTextBox";
            EmpNameTextBox.Size = new Size(148, 32);
            EmpNameTextBox.TabIndex = 15;
            // 
            // EmpNameLabel
            // 
            EmpNameLabel.AutoSize = true;
            EmpNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameLabel.Location = new Point(162, 37);
            EmpNameLabel.Name = "EmpNameLabel";
            EmpNameLabel.Size = new Size(129, 25);
            EmpNameLabel.TabIndex = 16;
            EmpNameLabel.Text = "Tên nhân viên";
            // 
            // EmpIdTextBox
            // 
            EmpIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdTextBox.Location = new Point(7, 68);
            EmpIdTextBox.Margin = new Padding(3, 4, 3, 4);
            EmpIdTextBox.Name = "EmpIdTextBox";
            EmpIdTextBox.Size = new Size(148, 32);
            EmpIdTextBox.TabIndex = 13;
            // 
            // EmpIdLabel
            // 
            EmpIdLabel.AutoSize = true;
            EmpIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdLabel.Location = new Point(7, 37);
            EmpIdLabel.Name = "EmpIdLabel";
            EmpIdLabel.Size = new Size(127, 25);
            EmpIdLabel.TabIndex = 14;
            EmpIdLabel.Text = "Mã nhân viên";
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.BorderStyle = BorderStyle.Fixed3D;
            RoleLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            RoleLabel.Location = new Point(512, 9);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(117, 33);
            RoleLabel.TabIndex = 18;
            RoleLabel.Text = "User Role";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.BorderStyle = BorderStyle.Fixed3D;
            IDLabel.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            IDLabel.Location = new Point(311, 9);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(94, 33);
            IDLabel.TabIndex = 17;
            IDLabel.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(439, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 31);
            label2.TabIndex = 16;
            label2.Text = "Role:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 15;
            label1.Text = "User:";
            // 
            // EmployeeInterfaceButton
            // 
            EmployeeInterfaceButton.BackColor = SystemColors.GradientActiveCaption;
            EmployeeInterfaceButton.Cursor = Cursors.Hand;
            EmployeeInterfaceButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInterfaceButton.Location = new Point(14, 5);
            EmployeeInterfaceButton.Margin = new Padding(3, 4, 3, 4);
            EmployeeInterfaceButton.Name = "EmployeeInterfaceButton";
            EmployeeInterfaceButton.Size = new Size(202, 40);
            EmployeeInterfaceButton.TabIndex = 14;
            EmployeeInterfaceButton.Text = "Giao diện nhân viên";
            EmployeeInterfaceButton.UseVisualStyleBackColor = false;
            EmployeeInterfaceButton.Click += EmployeeInterfaceButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.Salmon;
            LogOutButton.Cursor = Cursors.Hand;
            LogOutButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutButton.Location = new Point(727, 5);
            LogOutButton.Margin = new Padding(3, 4, 3, 4);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(174, 40);
            LogOutButton.TabIndex = 13;
            LogOutButton.Text = "Đăng xuất";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // fNhanSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 756);
            Controls.Add(RoleLabel);
            Controls.Add(IDLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmployeeInterfaceButton);
            Controls.Add(LogOutButton);
            Controls.Add(EmpGroupBox);
            Controls.Add(DataGridView);
            Controls.Add(DeptGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fNhanSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fNhanSu";
            DeptGroupBox.ResumeLayout(false);
            DeptGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            EmpGroupBox.ResumeLayout(false);
            EmpGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private GroupBox EmpGroupBox;
        private TextBox EmpDeptTextBox;
        private Label EmpDeptLabel;
        private TextBox EmpManagerIdTextBox;
        private Label EmpManagerIdLabel;
        private TextBox EmpRoleTextBox;
        private Label EmpRoleLabel;
        private TextBox EmpPhoneTextBox;
        private Label EmpPhoneLabel;
        private Label AddressLabel;
        private Label EmpBirthDateLabel;
        private Label EmpGenderLabel;
        private TextBox EmpNameTextBox;
        private Label EmpNameLabel;
        private TextBox EmpIdTextBox;
        private Label EmpIdLabel;
        private Button ViewEmpButton;
        private Button UpdateEmpButton;
        private DateTimePicker EmpBirthDatePicker;
        private ComboBox EmpGenderComboBox;
        private RichTextBox EmpAddressRichTextBox;
        private Button ViewDeptButton;
        private Label RoleLabel;
        private Label IDLabel;
        private Label label2;
        private Label label1;
        private Button EmployeeInterfaceButton;
        private Button LogOutButton;
    }
}