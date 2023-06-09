namespace PH1
{
    partial class fTruongDA
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
            components = new System.ComponentModel.Container();
            b_Dean = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xóaĐềÁnToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtĐềÁnToolStripMenuItem = new ToolStripMenuItem();
            b_ThemDean = new Button();
            rolename_label = new Label();
            role = new Label();
            username_label = new Label();
            label1 = new Label();
            b_Thoat = new Button();
            EmployeeInterfaceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // b_Dean
            // 
            b_Dean.BackColor = Color.Aquamarine;
            b_Dean.Cursor = Cursors.Hand;
            b_Dean.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            b_Dean.Location = new Point(217, 69);
            b_Dean.Margin = new Padding(3, 4, 3, 4);
            b_Dean.Name = "b_Dean";
            b_Dean.Size = new Size(131, 55);
            b_Dean.TabIndex = 2;
            b_Dean.Text = "Đề án";
            b_Dean.UseVisualStyleBackColor = false;
            b_Dean.Click += b_Dean_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(21, 151);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(903, 437);
            dataGridView1.TabIndex = 4;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaĐềÁnToolStripMenuItem, cậpNhậtĐềÁnToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(136, 60);
            contextMenuStrip1.Text = "Test";
            // 
            // xóaĐềÁnToolStripMenuItem
            // 
            xóaĐềÁnToolStripMenuItem.BackColor = Color.LightCoral;
            xóaĐềÁnToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            xóaĐềÁnToolStripMenuItem.Name = "xóaĐềÁnToolStripMenuItem";
            xóaĐềÁnToolStripMenuItem.Size = new Size(135, 28);
            xóaĐềÁnToolStripMenuItem.Text = "Delete";
            xóaĐềÁnToolStripMenuItem.Click += xóaĐềÁnToolStripMenuItem_Click;
            // 
            // cậpNhậtĐềÁnToolStripMenuItem
            // 
            cậpNhậtĐềÁnToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            cậpNhậtĐềÁnToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cậpNhậtĐềÁnToolStripMenuItem.Name = "cậpNhậtĐềÁnToolStripMenuItem";
            cậpNhậtĐềÁnToolStripMenuItem.Size = new Size(135, 28);
            cậpNhậtĐềÁnToolStripMenuItem.Text = "Update";
            cậpNhậtĐềÁnToolStripMenuItem.Click += cậpNhậtĐềÁnToolStripMenuItem_Click;
            // 
            // b_ThemDean
            // 
            b_ThemDean.BackColor = Color.Aquamarine;
            b_ThemDean.Cursor = Cursors.Hand;
            b_ThemDean.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            b_ThemDean.Location = new Point(354, 69);
            b_ThemDean.Margin = new Padding(3, 4, 3, 4);
            b_ThemDean.Name = "b_ThemDean";
            b_ThemDean.Size = new Size(131, 55);
            b_ThemDean.TabIndex = 7;
            b_ThemDean.Text = "Thêm đề án";
            b_ThemDean.UseVisualStyleBackColor = false;
            b_ThemDean.Click += b_ThemDean_Click;
            // 
            // rolename_label
            // 
            rolename_label.AutoSize = true;
            rolename_label.BorderStyle = BorderStyle.Fixed3D;
            rolename_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rolename_label.Location = new Point(323, 16);
            rolename_label.Name = "rolename_label";
            rolename_label.Size = new Size(118, 33);
            rolename_label.TabIndex = 33;
            rolename_label.Text = "rolename";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            role.ForeColor = Color.Black;
            role.Location = new Point(244, 16);
            role.Name = "role";
            role.Size = new Size(73, 31);
            role.TabIndex = 32;
            role.Text = "Role: ";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BorderStyle = BorderStyle.Fixed3D;
            username_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(102, 16);
            username_label.Name = "username_label";
            username_label.Size = new Size(122, 33);
            username_label.TabIndex = 31;
            username_label.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 30;
            label1.Text = "User: ";
            // 
            // b_Thoat
            // 
            b_Thoat.BackColor = Color.Salmon;
            b_Thoat.Cursor = Cursors.Hand;
            b_Thoat.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            b_Thoat.Location = new Point(767, 13);
            b_Thoat.Name = "b_Thoat";
            b_Thoat.Size = new Size(157, 51);
            b_Thoat.TabIndex = 34;
            b_Thoat.Text = "Đăng xuất";
            b_Thoat.UseVisualStyleBackColor = false;
            b_Thoat.Click += b_Thoat_Click;
            // 
            // EmployeeInterfaceButton
            // 
            EmployeeInterfaceButton.BackColor = SystemColors.GradientActiveCaption;
            EmployeeInterfaceButton.Cursor = Cursors.Hand;
            EmployeeInterfaceButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInterfaceButton.Location = new Point(21, 69);
            EmployeeInterfaceButton.Margin = new Padding(3, 4, 3, 4);
            EmployeeInterfaceButton.Name = "EmployeeInterfaceButton";
            EmployeeInterfaceButton.Size = new Size(190, 55);
            EmployeeInterfaceButton.TabIndex = 35;
            EmployeeInterfaceButton.Text = "Giao diện nhân viên";
            EmployeeInterfaceButton.UseVisualStyleBackColor = false;
            EmployeeInterfaceButton.Click += EmployeeInterfaceButton_Click;
            // 
            // fTruongDA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 604);
            Controls.Add(EmployeeInterfaceButton);
            Controls.Add(b_Thoat);
            Controls.Add(rolename_label);
            Controls.Add(role);
            Controls.Add(username_label);
            Controls.Add(label1);
            Controls.Add(b_ThemDean);
            Controls.Add(dataGridView1);
            Controls.Add(b_Dean);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fTruongDA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTruongDA";
            Load += fTruongDA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button b_Dean;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip_Nhanvien;
        private ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaĐềÁnToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtĐềÁnToolStripMenuItem;
        private Button b_ThemDean;
        private Label rolename_label;
        private Label role;
        private Label username_label;
        private Label label1;
        private Button b_Thoat;
        private Button EmployeeInterfaceButton;
    }
}