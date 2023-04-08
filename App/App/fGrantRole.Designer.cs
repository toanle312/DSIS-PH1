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
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)grantedRoles).BeginInit();
            SuspendLayout();
            // 
            // roleList
            // 
            roleList.BackColor = SystemColors.GradientActiveCaption;
            roleList.CheckOnClick = true;
            roleList.FormattingEnabled = true;
            roleList.Location = new Point(15, 69);
            roleList.Margin = new Padding(3, 4, 3, 4);
            roleList.Name = "roleList";
            roleList.Size = new Size(331, 114);
            roleList.TabIndex = 0;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(15, 45);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(94, 20);
            roleLabel.TabIndex = 1;
            roleLabel.Text = "Choose roles";
            // 
            // granteeLabel
            // 
            granteeLabel.AutoSize = true;
            granteeLabel.Location = new Point(15, 225);
            granteeLabel.Name = "granteeLabel";
            granteeLabel.Size = new Size(111, 20);
            granteeLabel.TabIndex = 3;
            granteeLabel.Text = "Input username";
            // 
            // granteeTextBox
            // 
            granteeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            granteeTextBox.Location = new Point(15, 249);
            granteeTextBox.Margin = new Padding(3, 4, 3, 4);
            granteeTextBox.Name = "granteeTextBox";
            granteeTextBox.Size = new Size(331, 34);
            granteeTextBox.TabIndex = 4;
            // 
            // grantedRoles
            // 
            grantedRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grantedRoles.Location = new Point(353, 69);
            grantedRoles.Margin = new Padding(3, 4, 3, 4);
            grantedRoles.Name = "grantedRoles";
            grantedRoles.RowHeadersWidth = 51;
            grantedRoles.RowTemplate.Height = 25;
            grantedRoles.Size = new Size(549, 404);
            grantedRoles.TabIndex = 5;
            // 
            // grantRoleButton
            // 
            grantRoleButton.BackColor = Color.LightGreen;
            grantRoleButton.Cursor = Cursors.Hand;
            grantRoleButton.Location = new Point(186, 291);
            grantRoleButton.Margin = new Padding(3, 4, 3, 4);
            grantRoleButton.Name = "grantRoleButton";
            grantRoleButton.Size = new Size(160, 41);
            grantRoleButton.TabIndex = 6;
            grantRoleButton.Text = "Grant Roles";
            grantRoleButton.UseVisualStyleBackColor = false;
            grantRoleButton.Click += GrantRoleButton_Click;
            // 
            // checkRoleButton
            // 
            checkRoleButton.BackColor = Color.Khaki;
            checkRoleButton.Cursor = Cursors.Hand;
            checkRoleButton.Location = new Point(15, 291);
            checkRoleButton.Margin = new Padding(3, 4, 3, 4);
            checkRoleButton.Name = "checkRoleButton";
            checkRoleButton.Size = new Size(160, 41);
            checkRoleButton.TabIndex = 7;
            checkRoleButton.Text = "Check Roles";
            checkRoleButton.UseVisualStyleBackColor = false;
            checkRoleButton.Click += CheckRoleButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe Script", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(283, -5);
            label4.Name = "label4";
            label4.Size = new Size(351, 70);
            label4.TabIndex = 11;
            label4.Text = "GRANT ROLE";
            // 
            // fGrantRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(checkRoleButton);
            Controls.Add(grantRoleButton);
            Controls.Add(grantedRoles);
            Controls.Add(granteeTextBox);
            Controls.Add(granteeLabel);
            Controls.Add(roleLabel);
            Controls.Add(roleList);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label4;
    }
}