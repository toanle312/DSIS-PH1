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
            DeptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
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
            DeptGroupBox.Size = new Size(776, 87);
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
            DataGridView.Location = new Point(18, 168);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(770, 270);
            DataGridView.TabIndex = 1;
            // 
            // fNhanSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView);
            Controls.Add(DeptGroupBox);
            Name = "fNhanSu";
            Text = "fNhanSu";
            DeptGroupBox.ResumeLayout(false);
            DeptGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
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
    }
}