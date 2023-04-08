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
            grantedPrivileges = new DataGridView();
            granteeTextBox = new TextBox();
            granteeLabel = new Label();
            targetLabel = new Label();
            grantPrivsBtn = new Button();
            targetList = new CheckedListBox();
            grantColPrivsBtn = new Button();
            privList = new CheckedListBox();
            privsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)grantedPrivileges).BeginInit();
            SuspendLayout();
            // 
            // checkPrivsBtn
            // 
            checkPrivsBtn.BackColor = Color.Khaki;
            checkPrivsBtn.Location = new Point(406, 84);
            checkPrivsBtn.Margin = new Padding(3, 4, 3, 4);
            checkPrivsBtn.Name = "checkPrivsBtn";
            checkPrivsBtn.Size = new Size(126, 41);
            checkPrivsBtn.TabIndex = 3;
            checkPrivsBtn.Text = "Check Privileges";
            checkPrivsBtn.UseVisualStyleBackColor = false;
            checkPrivsBtn.Click += CheckPrivsButton_Click;
            // 
            // grantedPrivileges
            // 
            grantedPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grantedPrivileges.Location = new Point(14, 193);
            grantedPrivileges.Margin = new Padding(3, 4, 3, 4);
            grantedPrivileges.Name = "grantedPrivileges";
            grantedPrivileges.RowHeadersWidth = 51;
            grantedPrivileges.RowTemplate.Height = 25;
            grantedPrivileges.Size = new Size(887, 302);
            grantedPrivileges.TabIndex = 4;
            // 
            // granteeTextBox
            // 
            granteeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            granteeTextBox.Location = new Point(406, 37);
            granteeTextBox.Margin = new Padding(3, 4, 3, 4);
            granteeTextBox.Name = "granteeTextBox";
            granteeTextBox.Size = new Size(274, 34);
            granteeTextBox.TabIndex = 5;
            // 
            // granteeLabel
            // 
            granteeLabel.AutoSize = true;
            granteeLabel.Location = new Point(406, 12);
            granteeLabel.Name = "granteeLabel";
            granteeLabel.Size = new Size(173, 20);
            granteeLabel.TabIndex = 11;
            granteeLabel.Text = "Input name of user / role";
            // 
            // targetLabel
            // 
            targetLabel.AutoSize = true;
            targetLabel.Location = new Point(14, 12);
            targetLabel.Name = "targetLabel";
            targetLabel.Size = new Size(140, 20);
            targetLabel.TabIndex = 13;
            targetLabel.Text = "Choose table / view";
            // 
            // grantPrivsBtn
            // 
            grantPrivsBtn.BackColor = Color.LightGreen;
            grantPrivsBtn.Location = new Point(554, 84);
            grantPrivsBtn.Margin = new Padding(3, 4, 3, 4);
            grantPrivsBtn.Name = "grantPrivsBtn";
            grantPrivsBtn.Size = new Size(126, 41);
            grantPrivsBtn.TabIndex = 16;
            grantPrivsBtn.Text = "Grant Privileges";
            grantPrivsBtn.UseVisualStyleBackColor = false;
            grantPrivsBtn.Click += GrantPrivsButton_Click;
            // 
            // targetList
            // 
            targetList.BackColor = SystemColors.GradientActiveCaption;
            targetList.CheckOnClick = true;
            targetList.FormattingEnabled = true;
            targetList.Location = new Point(14, 37);
            targetList.Margin = new Padding(3, 4, 3, 4);
            targetList.Name = "targetList";
            targetList.Size = new Size(385, 136);
            targetList.TabIndex = 17;
            // 
            // grantColPrivsBtn
            // 
            grantColPrivsBtn.BackColor = Color.LightSkyBlue;
            grantColPrivsBtn.Location = new Point(406, 133);
            grantColPrivsBtn.Margin = new Padding(3, 4, 3, 4);
            grantColPrivsBtn.Name = "grantColPrivsBtn";
            grantColPrivsBtn.Size = new Size(274, 41);
            grantColPrivsBtn.TabIndex = 18;
            grantColPrivsBtn.Text = "Grant Privileges For Column";
            grantColPrivsBtn.UseVisualStyleBackColor = false;
            grantColPrivsBtn.Click += GrantColPrivsButton_Click;
            // 
            // privList
            // 
            privList.BackColor = SystemColors.GradientActiveCaption;
            privList.CheckOnClick = true;
            privList.FormattingEnabled = true;
            privList.Location = new Point(687, 37);
            privList.Margin = new Padding(3, 4, 3, 4);
            privList.Name = "privList";
            privList.Size = new Size(213, 136);
            privList.TabIndex = 19;
            // 
            // privsLabel
            // 
            privsLabel.AutoSize = true;
            privsLabel.Location = new Point(687, 12);
            privsLabel.Name = "privsLabel";
            privsLabel.Size = new Size(126, 20);
            privsLabel.TabIndex = 20;
            privsLabel.Text = "Choose privileges";
            // 
            // fGrantPrivs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(privsLabel);
            Controls.Add(privList);
            Controls.Add(grantColPrivsBtn);
            Controls.Add(targetList);
            Controls.Add(grantPrivsBtn);
            Controls.Add(targetLabel);
            Controls.Add(granteeLabel);
            Controls.Add(granteeTextBox);
            Controls.Add(grantedPrivileges);
            Controls.Add(checkPrivsBtn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fGrantPrivs";
            Text = "fGrantPrivs";
            ((System.ComponentModel.ISupportInitialize)grantedPrivileges).EndInit();
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
        private DataGridView grantedPrivileges;
    }
}