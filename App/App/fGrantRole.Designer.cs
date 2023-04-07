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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            grantRole = new Button();
            checkBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // roleList
            // 
            roleList.FormattingEnabled = true;
            roleList.Location = new Point(12, 37);
            roleList.Name = "roleList";
            roleList.Size = new Size(330, 94);
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 23);
            textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(419, 356);
            dataGridView1.TabIndex = 5;
            // 
            // grantRole
            // 
            grantRole.Location = new Point(12, 201);
            grantRole.Name = "grantRole";
            grantRole.Size = new Size(160, 23);
            grantRole.TabIndex = 6;
            grantRole.Text = "Cấp vai trò";
            grantRole.UseVisualStyleBackColor = true;
            grantRole.Click += button1_Click;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(182, 201);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(160, 23);
            checkBtn.TabIndex = 7;
            checkBtn.Text = "Kiểm tra";
            checkBtn.UseVisualStyleBackColor = true;
            // 
            // fGrantRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBtn);
            Controls.Add(grantRole);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(granteeLabel);
            Controls.Add(roleLabel);
            Controls.Add(roleList);
            Name = "fGrantRole";
            Text = "fGrantRole";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox roleList;
        private Label roleLabel;
        private Label granteeLabel;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button grantRole;
        private Button checkBtn;
    }
}