namespace App
{
    partial class fGrantPrivs
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
            checkPrivsBtn = new Button();
            queriedPrivileges = new DataGridView();
            granteeTextBox = new TextBox();
            granteeLabel = new Label();
            targetLabel = new Label();
            grantPrivsBtn = new Button();
            targetList = new CheckedListBox();
            grantColPrivsBtn = new Button();
            privList = new CheckedListBox();
            privsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)queriedPrivileges).BeginInit();
            SuspendLayout();
            // 
            // checkBtn
            // 
            checkPrivsBtn.Location = new Point(355, 63);
            checkPrivsBtn.Name = "checkBtn";
            checkPrivsBtn.Size = new Size(110, 30);
            checkPrivsBtn.TabIndex = 3;
            checkPrivsBtn.Text = "Kiểm tra";
            checkPrivsBtn.UseVisualStyleBackColor = true;
            checkPrivsBtn.Click += CheckPrivsButton_Click;
            // 
            // privileges
            // 
            queriedPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            queriedPrivileges.Location = new Point(12, 128);
            queriedPrivileges.Name = "privileges";
            queriedPrivileges.RowTemplate.Height = 25;
            queriedPrivileges.Size = new Size(776, 243);
            queriedPrivileges.TabIndex = 4;
            // 
            // granteeTxtBox
            // 
            granteeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            granteeTextBox.Location = new Point(355, 28);
            granteeTextBox.Name = "granteeTxtBox";
            granteeTextBox.Size = new Size(240, 29);
            granteeTextBox.TabIndex = 5;
            // 
            // granteeLabel
            // 
            granteeLabel.AutoSize = true;
            granteeLabel.Location = new Point(355, 9);
            granteeLabel.Name = "granteeLabel";
            granteeLabel.Size = new Size(106, 15);
            granteeLabel.TabIndex = 11;
            granteeLabel.Text = "Nhập tên user/role";
            // 
            // objectLabel
            // 
            targetLabel.AutoSize = true;
            targetLabel.Location = new Point(12, 9);
            targetLabel.Name = "objectLabel";
            targetLabel.Size = new Size(94, 15);
            targetLabel.TabIndex = 13;
            targetLabel.Text = "Chọn table/view";
            // 
            // grantBtn
            // 
            grantPrivsBtn.Location = new Point(485, 63);
            grantPrivsBtn.Name = "grantBtn";
            grantPrivsBtn.Size = new Size(110, 30);
            grantPrivsBtn.TabIndex = 16;
            grantPrivsBtn.Text = "Cấp quyền";
            grantPrivsBtn.UseVisualStyleBackColor = true;
            grantPrivsBtn.Click += GrantPrivsButton_Click;
            // 
            // objectList
            // 
            targetList.CheckOnClick = true;
            targetList.FormattingEnabled = true;
            targetList.Location = new Point(12, 28);
            targetList.Name = "objectList";
            targetList.Size = new Size(337, 94);
            targetList.TabIndex = 17;
            // 
            // grantColPrivsBtn
            // 
            grantColPrivsBtn.Location = new Point(355, 99);
            grantColPrivsBtn.Name = "grantColPrivsBtn";
            grantColPrivsBtn.Size = new Size(240, 23);
            grantColPrivsBtn.TabIndex = 18;
            grantColPrivsBtn.Text = "Cấp quyền cho từng cột";
            grantColPrivsBtn.UseVisualStyleBackColor = true;
            grantColPrivsBtn.Click += GrantColPrivsButton_Click;
            // 
            // privListBox
            // 
            privList.CheckOnClick = true;
            privList.FormattingEnabled = true;
            privList.Location = new Point(601, 28);
            privList.Name = "privListBox";
            privList.Size = new Size(187, 94);
            privList.TabIndex = 19;
            // 
            // privsLabel
            // 
            privsLabel.AutoSize = true;
            privsLabel.Location = new Point(601, 9);
            privsLabel.Name = "privsLabel";
            privsLabel.Size = new Size(72, 15);
            privsLabel.TabIndex = 20;
            privsLabel.Text = "Chọn quyền";
            // 
            // fGrantPrivs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(privsLabel);
            Controls.Add(privList);
            Controls.Add(grantColPrivsBtn);
            Controls.Add(targetList);
            Controls.Add(grantPrivsBtn);
            Controls.Add(targetLabel);
            Controls.Add(granteeLabel);
            Controls.Add(granteeTextBox);
            Controls.Add(queriedPrivileges);
            Controls.Add(checkPrivsBtn);
            Name = "fGrantPrivs";
            Text = "fGrantPrivs";
            ((System.ComponentModel.ISupportInitialize)queriedPrivileges).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label privsLabel;
        private CheckedListBox privList;

        private Label targetLabel;
        private CheckedListBox targetList;

        private Label granteeLabel;
        private TextBox granteeTextBox;
        
        private Button grantPrivsBtn;
        private Button checkPrivsBtn;
        private Button grantColPrivsBtn;
        private DataGridView queriedPrivileges;
    }
}