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
            checkBtn = new Button();
            privileges = new DataGridView();
            granteeTxtBox = new TextBox();
            selectPrivCheckBox = new CheckBox();
            insertPrivCheckBox = new CheckBox();
            updatePrivCheckBox = new CheckBox();
            deletePrivCheckBox = new CheckBox();
            withGrantCheckBox = new CheckBox();
            granteeLabel = new Label();
            objectLabel = new Label();
            grantBtn = new Button();
            objectList = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)privileges).BeginInit();
            SuspendLayout();
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(355, 63);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(110, 30);
            checkBtn.TabIndex = 3;
            checkBtn.Text = "Kiểm tra";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkButton_Click;
            // 
            // privileges
            // 
            privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            privileges.Location = new Point(12, 128);
            privileges.Name = "privileges";
            privileges.RowTemplate.Height = 25;
            privileges.Size = new Size(776, 243);
            privileges.TabIndex = 4;
            // 
            // granteeTxtBox
            // 
            granteeTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            granteeTxtBox.Location = new Point(355, 28);
            granteeTxtBox.Name = "granteeTxtBox";
            granteeTxtBox.Size = new Size(240, 29);
            granteeTxtBox.TabIndex = 5;
            // 
            // selectPrivCheckBox
            // 
            selectPrivCheckBox.AutoSize = true;
            selectPrivCheckBox.Location = new Point(601, 28);
            selectPrivCheckBox.Name = "selectPrivCheckBox";
            selectPrivCheckBox.Size = new Size(64, 19);
            selectPrivCheckBox.TabIndex = 6;
            selectPrivCheckBox.Text = "SELECT";
            selectPrivCheckBox.UseVisualStyleBackColor = true;
            // 
            // insertPrivCheckBox
            // 
            insertPrivCheckBox.AutoSize = true;
            insertPrivCheckBox.Location = new Point(601, 53);
            insertPrivCheckBox.Name = "insertPrivCheckBox";
            insertPrivCheckBox.Size = new Size(62, 19);
            insertPrivCheckBox.TabIndex = 7;
            insertPrivCheckBox.Text = "INSERT";
            insertPrivCheckBox.UseVisualStyleBackColor = true;
            // 
            // updatePrivCheckBox
            // 
            updatePrivCheckBox.AutoSize = true;
            updatePrivCheckBox.Location = new Point(671, 53);
            updatePrivCheckBox.Name = "updatePrivCheckBox";
            updatePrivCheckBox.Size = new Size(68, 19);
            updatePrivCheckBox.TabIndex = 8;
            updatePrivCheckBox.Text = "UPDATE";
            updatePrivCheckBox.UseVisualStyleBackColor = true;
            // 
            // deletePrivCheckBox
            // 
            deletePrivCheckBox.AutoSize = true;
            deletePrivCheckBox.Location = new Point(671, 28);
            deletePrivCheckBox.Name = "deletePrivCheckBox";
            deletePrivCheckBox.Size = new Size(64, 19);
            deletePrivCheckBox.TabIndex = 9;
            deletePrivCheckBox.Text = "DELETE";
            deletePrivCheckBox.UseVisualStyleBackColor = true;
            // 
            // withGrantCheckBox
            // 
            withGrantCheckBox.AutoSize = true;
            withGrantCheckBox.Location = new Point(601, 74);
            withGrantCheckBox.Name = "withGrantCheckBox";
            withGrantCheckBox.Size = new Size(142, 19);
            withGrantCheckBox.TabIndex = 10;
            withGrantCheckBox.Text = "WITH GRANT OPTION";
            withGrantCheckBox.UseVisualStyleBackColor = true;
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
            objectLabel.AutoSize = true;
            objectLabel.Location = new Point(12, 9);
            objectLabel.Name = "objectLabel";
            objectLabel.Size = new Size(94, 15);
            objectLabel.TabIndex = 13;
            objectLabel.Text = "Chọn table/view";
            // 
            // grantBtn
            // 
            grantBtn.Location = new Point(485, 63);
            grantBtn.Name = "grantBtn";
            grantBtn.Size = new Size(110, 30);
            grantBtn.TabIndex = 16;
            grantBtn.Text = "Cấp quyền";
            grantBtn.UseVisualStyleBackColor = true;
            grantBtn.Click += grantBtn_Click;
            // 
            // objectList
            // 
            objectList.CheckOnClick = true;
            objectList.FormattingEnabled = true;
            objectList.Location = new Point(12, 28);
            objectList.Name = "objectList";
            objectList.Size = new Size(337, 94);
            objectList.TabIndex = 17;
            // 
            // fGrantPrivs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(objectList);
            Controls.Add(grantBtn);
            Controls.Add(objectLabel);
            Controls.Add(granteeLabel);
            Controls.Add(withGrantCheckBox);
            Controls.Add(deletePrivCheckBox);
            Controls.Add(updatePrivCheckBox);
            Controls.Add(insertPrivCheckBox);
            Controls.Add(selectPrivCheckBox);
            Controls.Add(granteeTxtBox);
            Controls.Add(privileges);
            Controls.Add(checkBtn);
            Name = "fGrantPrivs";
            Text = "fGrantPrivs";
            ((System.ComponentModel.ISupportInitialize)privileges).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkBtn;
        private Button grantBtn;
        private DataGridView privileges;
        private TextBox granteeTxtBox;
        private CheckBox selectPrivCheckBox;
        private CheckBox insertPrivCheckBox;
        private CheckBox updatePrivCheckBox;
        private CheckBox deletePrivCheckBox;
        private CheckBox withGrantCheckBox;
        private Label granteeLabel;
        private Label objectLabel;
        private CheckedListBox objectList;
    }
}