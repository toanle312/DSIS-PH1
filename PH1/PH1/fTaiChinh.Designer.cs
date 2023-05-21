namespace PH1
{
    partial class fTaiChinh
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
            components = new System.ComponentModel.Container();
            ViewEmpButton = new Button();
            ViewAllocationButton = new Button();
            GroupBox = new GroupBox();
            UpdateButton = new Button();
            AllowanceTextBox = new TextBox();
            AllowanceLabel = new Label();
            SalaryTextBox = new TextBox();
            SalaryLabel = new Label();
            EmpIdTextBox = new TextBox();
            EmpIdLabel = new Label();
            DataGridView = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            RoleLabel = new Label();
            IDLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            EmployeeInterfaceButton = new Button();
            LogOutButton = new Button();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // ViewEmpButton
            // 
            ViewEmpButton.BackColor = Color.Aquamarine;
            ViewEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewEmpButton.Location = new Point(12, 50);
            ViewEmpButton.Name = "ViewEmpButton";
            ViewEmpButton.Size = new Size(150, 40);
            ViewEmpButton.TabIndex = 0;
            ViewEmpButton.Text = "Xem nhân viên";
            ViewEmpButton.UseVisualStyleBackColor = false;
            ViewEmpButton.Click += ViewEmpButton_Click;
            // 
            // ViewAllocationButton
            // 
            ViewAllocationButton.BackColor = Color.Aquamarine;
            ViewAllocationButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewAllocationButton.Location = new Point(12, 96);
            ViewAllocationButton.Name = "ViewAllocationButton";
            ViewAllocationButton.Size = new Size(150, 40);
            ViewAllocationButton.TabIndex = 1;
            ViewAllocationButton.Text = "Xem phân công";
            ViewAllocationButton.UseVisualStyleBackColor = false;
            ViewAllocationButton.Click += ViewAllocationButton_Click;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(UpdateButton);
            GroupBox.Controls.Add(AllowanceTextBox);
            GroupBox.Controls.Add(AllowanceLabel);
            GroupBox.Controls.Add(SalaryTextBox);
            GroupBox.Controls.Add(SalaryLabel);
            GroupBox.Controls.Add(EmpIdTextBox);
            GroupBox.Controls.Add(EmpIdLabel);
            GroupBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBox.Location = new Point(168, 38);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(620, 98);
            GroupBox.TabIndex = 2;
            GroupBox.TabStop = false;
            GroupBox.Text = "Chỉnh sửa lương và phụ cấp";
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.Aquamarine;
            UpdateButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(468, 57);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(146, 30);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Chỉnh sửa";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AllowanceTextBox
            // 
            AllowanceTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AllowanceTextBox.Location = new Point(316, 59);
            AllowanceTextBox.Name = "AllowanceTextBox";
            AllowanceTextBox.Size = new Size(146, 27);
            AllowanceTextBox.TabIndex = 5;
            AllowanceTextBox.KeyPress += AllowanceTextBox_KeyPress;
            // 
            // AllowanceLabel
            // 
            AllowanceLabel.AutoSize = true;
            AllowanceLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            AllowanceLabel.Location = new Point(316, 36);
            AllowanceLabel.Name = "AllowanceLabel";
            AllowanceLabel.Size = new Size(61, 20);
            AllowanceLabel.TabIndex = 6;
            AllowanceLabel.Text = "Phụ cấp";
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryTextBox.Location = new Point(164, 59);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new Size(146, 27);
            SalaryTextBox.TabIndex = 4;
            SalaryTextBox.KeyPress += SalaryTextBox_KeyPress;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryLabel.Location = new Point(164, 36);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(51, 20);
            SalaryLabel.TabIndex = 4;
            SalaryLabel.Text = "Lương";
            // 
            // EmpIdTextBox
            // 
            EmpIdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdTextBox.Location = new Point(12, 59);
            EmpIdTextBox.Name = "EmpIdTextBox";
            EmpIdTextBox.Size = new Size(146, 27);
            EmpIdTextBox.TabIndex = 3;
            // 
            // EmpIdLabel
            // 
            EmpIdLabel.AutoSize = true;
            EmpIdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmpIdLabel.Location = new Point(12, 36);
            EmpIdLabel.Name = "EmpIdLabel";
            EmpIdLabel.Size = new Size(97, 20);
            EmpIdLabel.TabIndex = 3;
            EmpIdLabel.Text = "Mã nhân viên";
            // 
            // DataGridView
            // 
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 142);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(776, 296);
            DataGridView.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            RoleLabel.Location = new Point(448, 6);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(93, 25);
            RoleLabel.TabIndex = 24;
            RoleLabel.Text = "User Role";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            IDLabel.Location = new Point(295, 6);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(74, 25);
            IDLabel.TabIndex = 23;
            IDLabel.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(375, 6);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 22;
            label2.Text = "Vai trò:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(257, 6);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 21;
            label1.Text = "ID:";
            // 
            // EmployeeInterfaceButton
            // 
            EmployeeInterfaceButton.BackColor = SystemColors.GradientActiveCaption;
            EmployeeInterfaceButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInterfaceButton.Location = new Point(12, 3);
            EmployeeInterfaceButton.Name = "EmployeeInterfaceButton";
            EmployeeInterfaceButton.Size = new Size(152, 30);
            EmployeeInterfaceButton.TabIndex = 20;
            EmployeeInterfaceButton.Text = "Giao diện nhân viên";
            EmployeeInterfaceButton.UseVisualStyleBackColor = false;
            EmployeeInterfaceButton.Click += EmployeeInterfaceButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.LightSalmon;
            LogOutButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LogOutButton.Location = new Point(636, 3);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(152, 30);
            LogOutButton.TabIndex = 19;
            LogOutButton.Text = "Đăng xuất";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // fTaiChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RoleLabel);
            Controls.Add(IDLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmployeeInterfaceButton);
            Controls.Add(LogOutButton);
            Controls.Add(DataGridView);
            Controls.Add(GroupBox);
            Controls.Add(ViewAllocationButton);
            Controls.Add(ViewEmpButton);
            Name = "fTaiChinh";
            Text = "fTaiChinh";
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ViewEmpButton;
        private Button ViewAllocationButton;
        private GroupBox GroupBox;
        private Label EmpIdLabel;
        private TextBox EmpIdTextBox;
        private Label SalaryLabel;
        private TextBox SalaryTextBox;
        private TextBox AllowanceTextBox;
        private Label AllowanceLabel;
        private Button UpdateButton;
        private DataGridView DataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private Label RoleLabel;
        private Label IDLabel;
        private Label label2;
        private Label label1;
        private Button EmployeeInterfaceButton;
        private Button LogOutButton;
    }
}