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
            b_Nhanvien = new Button();
            b_Phancong = new Button();
            b_Dean = new Button();
            b_Phongban = new Button();
            dataGridView1 = new DataGridView();
            b_Nhanvien2 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xóaĐềÁnToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtĐềÁnToolStripMenuItem = new ToolStripMenuItem();
            b_ThemDean = new Button();
            rolename_label = new Label();
            role = new Label();
            username_label = new Label();
            label1 = new Label();
            b_Thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // b_Nhanvien
            // 
            b_Nhanvien.BackColor = SystemColors.ActiveCaption;
            b_Nhanvien.Location = new Point(40, 52);
            b_Nhanvien.Name = "b_Nhanvien";
            b_Nhanvien.Size = new Size(115, 46);
            b_Nhanvien.TabIndex = 0;
            b_Nhanvien.Text = "Personal Info";
            b_Nhanvien.UseVisualStyleBackColor = false;
            b_Nhanvien.Click += b_Nhanvien_Click;
            // 
            // b_Phancong
            // 
            b_Phancong.BackColor = SystemColors.ActiveCaption;
            b_Phancong.Location = new Point(298, 52);
            b_Phancong.Name = "b_Phancong";
            b_Phancong.Size = new Size(115, 46);
            b_Phancong.TabIndex = 1;
            b_Phancong.Text = "View PHANCONG";
            b_Phancong.UseVisualStyleBackColor = false;
            b_Phancong.Click += b_Phancong_Click;
            // 
            // b_Dean
            // 
            b_Dean.BackColor = SystemColors.ActiveCaption;
            b_Dean.Location = new Point(540, 52);
            b_Dean.Name = "b_Dean";
            b_Dean.Size = new Size(115, 46);
            b_Dean.TabIndex = 2;
            b_Dean.Text = "View DEAN";
            b_Dean.UseVisualStyleBackColor = false;
            b_Dean.Click += b_Dean_Click;
            // 
            // b_Phongban
            // 
            b_Phongban.BackColor = SystemColors.ActiveCaption;
            b_Phongban.Location = new Point(419, 52);
            b_Phongban.Name = "b_Phongban";
            b_Phongban.Size = new Size(115, 46);
            b_Phongban.TabIndex = 3;
            b_Phongban.Text = "View PHONGBAN";
            b_Phongban.UseVisualStyleBackColor = false;
            b_Phongban.Click += b_Phongban_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(40, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(736, 288);
            dataGridView1.TabIndex = 4;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // b_Nhanvien2
            // 
            b_Nhanvien2.BackColor = SystemColors.ActiveCaption;
            b_Nhanvien2.Location = new Point(161, 52);
            b_Nhanvien2.Name = "b_Nhanvien2";
            b_Nhanvien2.Size = new Size(131, 46);
            b_Nhanvien2.TabIndex = 6;
            b_Nhanvien2.Text = "Update Personal Info";
            b_Nhanvien2.UseVisualStyleBackColor = false;
            b_Nhanvien2.Click += b_Nhanvien2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaĐềÁnToolStripMenuItem, cậpNhậtĐềÁnToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 52);
            // 
            // xóaĐềÁnToolStripMenuItem
            // 
            xóaĐềÁnToolStripMenuItem.BackColor = Color.LightCoral;
            xóaĐềÁnToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            xóaĐềÁnToolStripMenuItem.Name = "xóaĐềÁnToolStripMenuItem";
            xóaĐềÁnToolStripMenuItem.Size = new Size(121, 24);
            xóaĐềÁnToolStripMenuItem.Text = "Delete";
            xóaĐềÁnToolStripMenuItem.Click += xóaĐềÁnToolStripMenuItem_Click;
            // 
            // cậpNhậtĐềÁnToolStripMenuItem
            // 
            cậpNhậtĐềÁnToolStripMenuItem.BackColor = SystemColors.ActiveCaption;
            cậpNhậtĐềÁnToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cậpNhậtĐềÁnToolStripMenuItem.Name = "cậpNhậtĐềÁnToolStripMenuItem";
            cậpNhậtĐềÁnToolStripMenuItem.Size = new Size(121, 24);
            cậpNhậtĐềÁnToolStripMenuItem.Text = "Update";
            cậpNhậtĐềÁnToolStripMenuItem.Click += cậpNhậtĐềÁnToolStripMenuItem_Click;
            // 
            // b_ThemDean
            // 
            b_ThemDean.BackColor = SystemColors.ActiveCaption;
            b_ThemDean.Location = new Point(661, 52);
            b_ThemDean.Name = "b_ThemDean";
            b_ThemDean.Size = new Size(115, 46);
            b_ThemDean.TabIndex = 7;
            b_ThemDean.Text = "Add new DEAN ";
            b_ThemDean.UseVisualStyleBackColor = false;
            b_ThemDean.Click += b_ThemDean_Click;
            // 
            // rolename_label
            // 
            rolename_label.AutoSize = true;
            rolename_label.BorderStyle = BorderStyle.Fixed3D;
            rolename_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rolename_label.Location = new Point(298, 12);
            rolename_label.Name = "rolename_label";
            rolename_label.Size = new Size(98, 27);
            rolename_label.TabIndex = 33;
            rolename_label.Text = "rolename";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            role.ForeColor = Color.Firebrick;
            role.Location = new Point(231, 12);
            role.Name = "role";
            role.Size = new Size(61, 25);
            role.TabIndex = 32;
            role.Text = "Role: ";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BorderStyle = BorderStyle.Fixed3D;
            username_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(109, 12);
            username_label.Name = "username_label";
            username_label.Size = new Size(100, 27);
            username_label.TabIndex = 31;
            username_label.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(40, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 30;
            label1.Text = "User: ";
            // 
            // b_Thoat
            // 
            b_Thoat.BackColor = Color.LightCoral;
            b_Thoat.Cursor = Cursors.Hand;
            b_Thoat.Location = new Point(540, 12);
            b_Thoat.Margin = new Padding(3, 2, 3, 2);
            b_Thoat.Name = "b_Thoat";
            b_Thoat.Size = new Size(115, 30);
            b_Thoat.TabIndex = 34;
            b_Thoat.Text = "Log Out";
            b_Thoat.UseVisualStyleBackColor = false;
            b_Thoat.Click += b_Thoat_Click;
            // 
            // fTruongDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 451);
            Controls.Add(b_Thoat);
            Controls.Add(rolename_label);
            Controls.Add(role);
            Controls.Add(username_label);
            Controls.Add(label1);
            Controls.Add(b_ThemDean);
            Controls.Add(b_Nhanvien2);
            Controls.Add(dataGridView1);
            Controls.Add(b_Phongban);
            Controls.Add(b_Dean);
            Controls.Add(b_Phancong);
            Controls.Add(b_Nhanvien);
            Name = "fTruongDA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTruongDA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Nhanvien;
        private Button b_Phancong;
        private Button b_Dean;
        private Button b_Phongban;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip_Nhanvien;
        private ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private Button b_Nhanvien2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaĐềÁnToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtĐềÁnToolStripMenuItem;
        private Button b_ThemDean;
        private Label rolename_label;
        private Label role;
        private Label username_label;
        private Label label1;
        private Button b_Thoat;
    }
}