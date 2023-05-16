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
            DeptGroupBox.Location = new Point(12, 35);
            DeptGroupBox.Name = "DeptGroupBox";
            DeptGroupBox.Size = new Size(776, 93);
            DeptGroupBox.TabIndex = 0;
            DeptGroupBox.TabStop = false;
            DeptGroupBox.Text = "Trên quan hệ phòng ban";
            // 
            // ViewDeptButton
            // 
            ViewDeptButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewDeptButton.Location = new Point(462, 17);
            ViewDeptButton.Name = "ViewDeptButton";
            ViewDeptButton.Size = new Size(298, 30);
            ViewDeptButton.TabIndex = 15;
            ViewDeptButton.Text = "Xem danh sách phòng ban";
            ViewDeptButton.UseVisualStyleBackColor = true;
            ViewDeptButton.Click += ViewDeptButton_Click;
            // 
            // UpdateDeptButton
            // 
            UpdateDeptButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateDeptButton.Location = new Point(614, 47);
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
            EmpGroupBox.Location = new Point(12, 134);
            EmpGroupBox.Name = "EmpGroupBox";
            EmpGroupBox.Size = new Size(776, 175);
            EmpGroupBox.TabIndex = 2;
            EmpGroupBox.TabStop = false;
            EmpGroupBox.Text = "Trên quan hệ nhân viên";
            // 
            // EmpAddressRichTextBox
            // 
            EmpAddressRichTextBox.Location = new Point(550, 51);
            EmpAddressRichTextBox.Name = "EmpAddressRichTextBox";
            EmpAddressRichTextBox.Size = new Size(210, 116);
            EmpAddressRichTextBox.TabIndex = 3;
            EmpAddressRichTextBox.Text = "";
            // 
            // EmpGenderComboBox
            // 
            EmpGenderComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpGenderComboBox.FormattingEnabled = true;
            EmpGenderComboBox.Items.AddRange(new object[] { "Nam", "Nữ" });
            EmpGenderComboBox.Location = new Point(278, 51);
            EmpGenderComboBox.Name = "EmpGenderComboBox";
            EmpGenderComboBox.Size = new Size(130, 28);
            EmpGenderComboBox.TabIndex = 35;
            // 
            // EmpBirthDatePicker
            // 
            EmpBirthDatePicker.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpBirthDatePicker.CustomFormat = "dd/MM/yyyy";
            EmpBirthDatePicker.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpBirthDatePicker.Format = DateTimePickerFormat.Custom;
            EmpBirthDatePicker.Location = new Point(414, 51);
            EmpBirthDatePicker.Name = "EmpBirthDatePicker";
            EmpBirthDatePicker.Size = new Size(130, 27);
            EmpBirthDatePicker.TabIndex = 34;
            EmpBirthDatePicker.Value = new DateTime(2023, 5, 5, 22, 41, 0, 0);
            // 
            // UpdateEmpButton
            // 
            UpdateEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateEmpButton.Location = new Point(278, 139);
            UpdateEmpButton.Name = "UpdateEmpButton";
            UpdateEmpButton.Size = new Size(266, 30);
            UpdateEmpButton.TabIndex = 33;
            UpdateEmpButton.Text = "Chỉnh sửa nhân viên";
            UpdateEmpButton.UseVisualStyleBackColor = true;
            UpdateEmpButton.Click += UpdateEmpButton_Click;
            // 
            // ViewEmpButton
            // 
            ViewEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewEmpButton.Location = new Point(6, 137);
            ViewEmpButton.Name = "ViewEmpButton";
            ViewEmpButton.Size = new Size(266, 30);
            ViewEmpButton.TabIndex = 31;
            ViewEmpButton.Text = "Xem danh sách nhân viên";
            ViewEmpButton.UseVisualStyleBackColor = true;
            ViewEmpButton.Click += ViewEmpButton_Click;
            // 
            // EmpDeptTextBox
            // 
            EmpDeptTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpDeptTextBox.Location = new Point(414, 104);
            EmpDeptTextBox.Name = "EmpDeptTextBox";
            EmpDeptTextBox.Size = new Size(130, 27);
            EmpDeptTextBox.TabIndex = 29;
            // 
            // EmpDeptLabel
            // 
            EmpDeptLabel.AutoSize = true;
            EmpDeptLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpDeptLabel.Location = new Point(414, 81);
            EmpDeptLabel.Name = "EmpDeptLabel";
            EmpDeptLabel.Size = new Size(51, 20);
            EmpDeptLabel.TabIndex = 30;
            EmpDeptLabel.Text = "Phòng";
            // 
            // EmpManagerIdTextBox
            // 
            EmpManagerIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpManagerIdTextBox.Location = new Point(278, 104);
            EmpManagerIdTextBox.Name = "EmpManagerIdTextBox";
            EmpManagerIdTextBox.Size = new Size(130, 27);
            EmpManagerIdTextBox.TabIndex = 27;
            // 
            // EmpManagerIdLabel
            // 
            EmpManagerIdLabel.AutoSize = true;
            EmpManagerIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpManagerIdLabel.Location = new Point(278, 81);
            EmpManagerIdLabel.Name = "EmpManagerIdLabel";
            EmpManagerIdLabel.Size = new Size(125, 20);
            EmpManagerIdLabel.TabIndex = 28;
            EmpManagerIdLabel.Text = "Mã người quản lý";
            // 
            // EmpRoleTextBox
            // 
            EmpRoleTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpRoleTextBox.Location = new Point(142, 104);
            EmpRoleTextBox.Name = "EmpRoleTextBox";
            EmpRoleTextBox.Size = new Size(130, 27);
            EmpRoleTextBox.TabIndex = 25;
            // 
            // EmpRoleLabel
            // 
            EmpRoleLabel.AutoSize = true;
            EmpRoleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpRoleLabel.Location = new Point(142, 81);
            EmpRoleLabel.Name = "EmpRoleLabel";
            EmpRoleLabel.Size = new Size(52, 20);
            EmpRoleLabel.TabIndex = 26;
            EmpRoleLabel.Text = "Vai trò";
            // 
            // EmpPhoneTextBox
            // 
            EmpPhoneTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpPhoneTextBox.Location = new Point(6, 104);
            EmpPhoneTextBox.Name = "EmpPhoneTextBox";
            EmpPhoneTextBox.Size = new Size(130, 27);
            EmpPhoneTextBox.TabIndex = 23;
            EmpPhoneTextBox.KeyPress += EmpPhoneTextBox_KeyPress;
            // 
            // EmpPhoneLabel
            // 
            EmpPhoneLabel.AutoSize = true;
            EmpPhoneLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpPhoneLabel.Location = new Point(6, 81);
            EmpPhoneLabel.Name = "EmpPhoneLabel";
            EmpPhoneLabel.Size = new Size(97, 20);
            EmpPhoneLabel.TabIndex = 24;
            EmpPhoneLabel.Text = "Số điện thoại";
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
            // EmpBirthDateLabel
            // 
            EmpBirthDateLabel.AutoSize = true;
            EmpBirthDateLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpBirthDateLabel.Location = new Point(414, 27);
            EmpBirthDateLabel.Name = "EmpBirthDateLabel";
            EmpBirthDateLabel.Size = new Size(74, 20);
            EmpBirthDateLabel.TabIndex = 20;
            EmpBirthDateLabel.Text = "Ngày sinh";
            // 
            // EmpGenderLabel
            // 
            EmpGenderLabel.AutoSize = true;
            EmpGenderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpGenderLabel.Location = new Point(278, 28);
            EmpGenderLabel.Name = "EmpGenderLabel";
            EmpGenderLabel.Size = new Size(37, 20);
            EmpGenderLabel.TabIndex = 18;
            EmpGenderLabel.Text = "Phái";
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
            // fNhanSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(EmpGroupBox);
            Controls.Add(DataGridView);
            Controls.Add(DeptGroupBox);
            Name = "fNhanSu";
            Text = "fNhanSu";
            DeptGroupBox.ResumeLayout(false);
            DeptGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            EmpGroupBox.ResumeLayout(false);
            EmpGroupBox.PerformLayout();
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
    }
}