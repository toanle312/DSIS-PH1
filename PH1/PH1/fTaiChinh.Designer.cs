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
            ViewEmpButton = new Button();
            ViewAllocationButton = new Button();
            GroupBox = new GroupBox();
            UpdateButton = new Button();
            AllowanceTextBox = new TextBox();
            AllowanceLabel = new Label();
            SalaryTextBox = new TextBox();
            SalaryLabel = new Label();
            IdTextBox = new TextBox();
            IdLabel = new Label();
            DataGridView = new DataGridView();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // ViewEmpButton
            // 
            ViewEmpButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewEmpButton.Location = new Point(12, 50);
            ViewEmpButton.Name = "ViewEmpButton";
            ViewEmpButton.Size = new Size(150, 40);
            ViewEmpButton.TabIndex = 0;
            ViewEmpButton.Text = "Xem nhân viên";
            ViewEmpButton.UseVisualStyleBackColor = true;
            ViewEmpButton.Click += ViewEmpButton_Click;
            // 
            // ViewAllocationButton
            // 
            ViewAllocationButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ViewAllocationButton.Location = new Point(12, 96);
            ViewAllocationButton.Name = "ViewAllocationButton";
            ViewAllocationButton.Size = new Size(150, 40);
            ViewAllocationButton.TabIndex = 1;
            ViewAllocationButton.Text = "Xem phân công";
            ViewAllocationButton.UseVisualStyleBackColor = true;
            ViewAllocationButton.Click += ViewAllocationButton_Click;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(UpdateButton);
            GroupBox.Controls.Add(AllowanceTextBox);
            GroupBox.Controls.Add(AllowanceLabel);
            GroupBox.Controls.Add(SalaryTextBox);
            GroupBox.Controls.Add(SalaryLabel);
            GroupBox.Controls.Add(IdTextBox);
            GroupBox.Controls.Add(IdLabel);
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
            UpdateButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(468, 57);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(146, 30);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Chỉnh sửa";
            UpdateButton.UseVisualStyleBackColor = true;
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
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(12, 59);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(146, 27);
            IdTextBox.TabIndex = 3;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(12, 36);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(97, 20);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "Mã nhân viên";
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 142);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(776, 296);
            DataGridView.TabIndex = 3;
            // 
            // fTaiChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        }

        #endregion

        private Button ViewEmpButton;
        private Button ViewAllocationButton;
        private GroupBox GroupBox;
        private Label IdLabel;
        private TextBox IdTextBox;
        private Label SalaryLabel;
        private TextBox SalaryTextBox;
        private TextBox AllowanceTextBox;
        private Label AllowanceLabel;
        private Button UpdateButton;
        private DataGridView DataGridView;
    }
}