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
            b_Thoat = new Button();
            b_Nhanvien2 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xóaĐềÁnToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtĐềÁnToolStripMenuItem = new ToolStripMenuItem();
            b_ThemDean = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // b_Nhanvien
            // 
            b_Nhanvien.Location = new Point(40, 40);
            b_Nhanvien.Name = "b_Nhanvien";
            b_Nhanvien.Size = new Size(177, 23);
            b_Nhanvien.TabIndex = 0;
            b_Nhanvien.Text = "Xem thông tin cá nhân";
            b_Nhanvien.UseVisualStyleBackColor = true;
            b_Nhanvien.Click += b_Nhanvien_Click;
            // 
            // b_Phancong
            // 
            b_Phancong.Location = new Point(266, 88);
            b_Phancong.Name = "b_Phancong";
            b_Phancong.Size = new Size(122, 23);
            b_Phancong.TabIndex = 1;
            b_Phancong.Text = "Xem Phân công";
            b_Phancong.UseVisualStyleBackColor = true;
            b_Phancong.Click += b_Phancong_Click;
            // 
            // b_Dean
            // 
            b_Dean.Location = new Point(448, 40);
            b_Dean.Name = "b_Dean";
            b_Dean.Size = new Size(117, 23);
            b_Dean.TabIndex = 2;
            b_Dean.Text = "Xem Đề án";
            b_Dean.UseVisualStyleBackColor = true;
            b_Dean.Click += b_Dean_Click;
            // 
            // b_Phongban
            // 
            b_Phongban.Location = new Point(266, 40);
            b_Phongban.Name = "b_Phongban";
            b_Phongban.Size = new Size(122, 23);
            b_Phongban.TabIndex = 3;
            b_Phongban.Text = "Xem Phòng ban";
            b_Phongban.UseVisualStyleBackColor = true;
            b_Phongban.Click += b_Phongban_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(40, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(710, 231);
            dataGridView1.TabIndex = 4;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // b_Thoat
            // 
            b_Thoat.Location = new Point(621, 40);
            b_Thoat.Name = "b_Thoat";
            b_Thoat.Size = new Size(117, 23);
            b_Thoat.TabIndex = 5;
            b_Thoat.Text = "Thoát";
            b_Thoat.UseVisualStyleBackColor = true;
            b_Thoat.Click += b_Thoat_Click;
            // 
            // b_Nhanvien2
            // 
            b_Nhanvien2.Location = new Point(40, 88);
            b_Nhanvien2.Name = "b_Nhanvien2";
            b_Nhanvien2.Size = new Size(177, 23);
            b_Nhanvien2.TabIndex = 6;
            b_Nhanvien2.Text = "Chỉnh sửa thông tin cá nhân";
            b_Nhanvien2.UseVisualStyleBackColor = true;
            b_Nhanvien2.Click += b_Nhanvien2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaĐềÁnToolStripMenuItem, cậpNhậtĐềÁnToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // xóaĐềÁnToolStripMenuItem
            // 
            xóaĐềÁnToolStripMenuItem.Name = "xóaĐềÁnToolStripMenuItem";
            xóaĐềÁnToolStripMenuItem.Size = new Size(180, 22);
            xóaĐềÁnToolStripMenuItem.Text = "Xóa Đề án";
            xóaĐềÁnToolStripMenuItem.Click += xóaĐềÁnToolStripMenuItem_Click;
            // 
            // cậpNhậtĐềÁnToolStripMenuItem
            // 
            cậpNhậtĐềÁnToolStripMenuItem.Name = "cậpNhậtĐềÁnToolStripMenuItem";
            cậpNhậtĐềÁnToolStripMenuItem.Size = new Size(180, 22);
            cậpNhậtĐềÁnToolStripMenuItem.Text = "Sửa đề án";
            cậpNhậtĐềÁnToolStripMenuItem.Click += cậpNhậtĐềÁnToolStripMenuItem_Click;
            // 
            // b_ThemDean
            // 
            b_ThemDean.Location = new Point(448, 88);
            b_ThemDean.Name = "b_ThemDean";
            b_ThemDean.Size = new Size(117, 23);
            b_ThemDean.TabIndex = 7;
            b_ThemDean.Text = "Thêm đề án";
            b_ThemDean.UseVisualStyleBackColor = true;
            b_ThemDean.Click += b_ThemDean_Click;
            // 
            // fTruongDA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(b_ThemDean);
            Controls.Add(b_Nhanvien2);
            Controls.Add(b_Thoat);
            Controls.Add(dataGridView1);
            Controls.Add(b_Phongban);
            Controls.Add(b_Dean);
            Controls.Add(b_Phancong);
            Controls.Add(b_Nhanvien);
            Name = "fTruongDA";
            Text = "fTruongDA";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button b_Nhanvien;
        private Button b_Phancong;
        private Button b_Dean;
        private Button b_Phongban;
        private DataGridView dataGridView1;
        private Button b_Thoat;
        private ContextMenuStrip contextMenuStrip_Nhanvien;
        private ToolStripMenuItem sửaThôngTinToolStripMenuItem;
        private Button b_Nhanvien2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaĐềÁnToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtĐềÁnToolStripMenuItem;
        private Button b_ThemDean;
    }
}