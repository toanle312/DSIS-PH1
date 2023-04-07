namespace App
{
    partial class fGrantRole
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
            roleList = new CheckedListBox();
            roleLabel = new Label();
            granteeLabel = new Label();
            granteeTextBox = new TextBox();
            grantedRoles = new DataGridView();
            grantRoleButton = new Button();
            checkRoleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)grantedRoles).BeginInit();
            SuspendLayout();
            // 
            // roleList
            // 
            roleList.CheckOnClick = true;
            roleList.FormattingEnabled = true;
            roleList.Location = new Point(12, 37);
            roleList.Name = "roleList";
            roleList.Size = new Size(290, 94);
            roleList.TabIndex = 0;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(12, 19);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(64, 15);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Chọn roles";
            // 
            // granteeLabel
            // 
            granteeLabel.AutoSize = true;
            granteeLabel.Location = new Point(12, 154);
            granteeLabel.Name = "granteeLabel";
            granteeLabel.Size = new Size(121, 15);
            granteeLabel.TabIndex = 3;
            granteeLabel.Text = "Nhập tên người dùng";
            // 
            // granteeTextBox
            // 
            granteeTextBox.Location = new Point(12, 172);
            granteeTextBox.Name = "granteeTextBox";
            granteeTextBox.Size = new Size(290, 23);
            granteeTextBox.TabIndex = 4;
            // 
            // privileges
            // 
            grantedRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grantedRoles.Location = new Point(308, 37);
            grantedRoles.Name = "privileges";
            grantedRoles.RowTemplate.Height = 25;
            grantedRoles.Size = new Size(480, 323);
            grantedRoles.TabIndex = 5;
            // 
            // grantRole
            // 
            grantRoleButton.Location = new Point(162, 201);
            grantRoleButton.Name = "grantRole";
            grantRoleButton.Size = new Size(140, 23);
            grantRoleButton.TabIndex = 6;
            grantRoleButton.Text = "Cấp vai trò";
            grantRoleButton.UseVisualStyleBackColor = true;
            grantRoleButton.Click += GrantRoleButton_Click;
            // 
            // checkBtn
            // 
            checkRoleButton.Location = new Point(12, 201);
            checkRoleButton.Name = "checkBtn";
            checkRoleButton.Size = new Size(140, 23);
            checkRoleButton.TabIndex = 7;
            checkRoleButton.Text = "Kiểm tra";
            checkRoleButton.UseVisualStyleBackColor = true;
            checkRoleButton.Click += CheckRoleButton_Click;
            // 
            // fGrantRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkRoleButton);
            Controls.Add(grantRoleButton);
            Controls.Add(grantedRoles);
            Controls.Add(granteeTextBox);
            Controls.Add(granteeLabel);
            Controls.Add(roleLabel);
            Controls.Add(roleList);
            Name = "fGrantRole";
            Text = "fGrantRole";
            ((System.ComponentModel.ISupportInitialize)grantedRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roleLabel;
        private CheckedListBox roleList;

        private Label granteeLabel;
        private TextBox granteeTextBox;

        private Button grantRoleButton;
        private Button checkRoleButton;
        private DataGridView grantedRoles;
    }
}