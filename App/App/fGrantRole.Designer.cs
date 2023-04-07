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
            privileges = new DataGridView();
            grantRole = new Button();
            checkBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)privileges).BeginInit();
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
            privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            privileges.Location = new Point(308, 37);
            privileges.Name = "privileges";
            privileges.RowTemplate.Height = 25;
            privileges.Size = new Size(480, 323);
            privileges.TabIndex = 5;
            // 
            // grantRole
            // 
            grantRole.Location = new Point(162, 201);
            grantRole.Name = "grantRole";
            grantRole.Size = new Size(140, 23);
            grantRole.TabIndex = 6;
            grantRole.Text = "Cấp vai trò";
            grantRole.UseVisualStyleBackColor = true;
            grantRole.Click += grantRole_Click;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(12, 201);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(140, 23);
            checkBtn.TabIndex = 7;
            checkBtn.Text = "Kiểm tra";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // fGrantRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBtn);
            Controls.Add(grantRole);
            Controls.Add(privileges);
            Controls.Add(granteeTextBox);
            Controls.Add(granteeLabel);
            Controls.Add(roleLabel);
            Controls.Add(roleList);
            Name = "fGrantRole";
            Text = "fGrantRole";
            ((System.ComponentModel.ISupportInitialize)privileges).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox roleList;
        private Label roleLabel;
        private Label granteeLabel;
        private TextBox granteeTextBox;
        private DataGridView privileges;
        private Button grantRole;
        private Button checkBtn;
    }
}