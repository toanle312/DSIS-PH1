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
            granteeLabel = new Label();
            objectLabel = new Label();
            grantBtn = new Button();
            objectList = new CheckedListBox();
            grantColPrivsBtn = new Button();
            privListBox = new CheckedListBox();
            privsLabel = new Label();
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
            // grantColPrivsBtn
            // 
            grantColPrivsBtn.Location = new Point(355, 99);
            grantColPrivsBtn.Name = "grantColPrivsBtn";
            grantColPrivsBtn.Size = new Size(240, 23);
            grantColPrivsBtn.TabIndex = 18;
            grantColPrivsBtn.Text = "Cấp quyền cho từng cột";
            grantColPrivsBtn.UseVisualStyleBackColor = true;
            grantColPrivsBtn.Click += grantColPrivsBtn_Click;
            // 
            // privListBox
            // 
            privListBox.CheckOnClick = true;
            privListBox.FormattingEnabled = true;
            privListBox.Location = new Point(601, 28);
            privListBox.Name = "privListBox";
            privListBox.Size = new Size(187, 94);
            privListBox.TabIndex = 19;
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
            Controls.Add(privListBox);
            Controls.Add(grantColPrivsBtn);
            Controls.Add(objectList);
            Controls.Add(grantBtn);
            Controls.Add(objectLabel);
            Controls.Add(granteeLabel);
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
        private Label granteeLabel;
        private Label objectLabel;
        private CheckedListBox objectList;
        private Button grantColPrivsBtn;
        private CheckedListBox privListBox;
        private Label privsLabel;
    }
}