namespace PH1
{
    partial class fNhanVien
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
            log_out_btn = new Button();
            da_btn = new Button();
            phancong_btn = new Button();
            nhanvien_btn = new Button();
            username_label = new Label();
            label1 = new Label();
            role = new Label();
            rolename_label = new Label();
            pb_btn = new Button();
            update_infor_btn = new Button();
            user_list_view = new DataGridView();
            feature_label = new Label();
            ((System.ComponentModel.ISupportInitialize)user_list_view).BeginInit();
            SuspendLayout();
            // 
            // log_out_btn
            // 
            log_out_btn.BackColor = Color.Salmon;
            log_out_btn.Cursor = Cursors.Hand;
            log_out_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            log_out_btn.Location = new Point(806, 14);
            log_out_btn.Name = "log_out_btn";
            log_out_btn.Size = new Size(169, 51);
            log_out_btn.TabIndex = 27;
            log_out_btn.Text = "Đăng xuất";
            log_out_btn.UseVisualStyleBackColor = false;
            log_out_btn.Click += log_out_btn_Click;
            // 
            // da_btn
            // 
            da_btn.BackColor = Color.Aquamarine;
            da_btn.Cursor = Cursors.Hand;
            da_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            da_btn.ForeColor = SystemColors.ControlText;
            da_btn.Location = new Point(358, 62);
            da_btn.Name = "da_btn";
            da_btn.Size = new Size(131, 58);
            da_btn.TabIndex = 18;
            da_btn.Text = "Đề án";
            da_btn.UseVisualStyleBackColor = false;
            da_btn.Click += da_btn_Click;
            // 
            // phancong_btn
            // 
            phancong_btn.BackColor = Color.Aquamarine;
            phancong_btn.Cursor = Cursors.Hand;
            phancong_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            phancong_btn.ForeColor = SystemColors.ControlText;
            phancong_btn.Location = new Point(221, 62);
            phancong_btn.Name = "phancong_btn";
            phancong_btn.Size = new Size(131, 58);
            phancong_btn.TabIndex = 17;
            phancong_btn.Text = "Phân công";
            phancong_btn.UseVisualStyleBackColor = false;
            phancong_btn.Click += phancong_btn_Click;
            // 
            // nhanvien_btn
            // 
            nhanvien_btn.BackColor = Color.Aquamarine;
            nhanvien_btn.Cursor = Cursors.Hand;
            nhanvien_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            nhanvien_btn.ForeColor = SystemColors.ControlText;
            nhanvien_btn.Location = new Point(15, 62);
            nhanvien_btn.Name = "nhanvien_btn";
            nhanvien_btn.Size = new Size(200, 58);
            nhanvien_btn.TabIndex = 16;
            nhanvien_btn.Text = "Thông tin cá nhân";
            nhanvien_btn.UseVisualStyleBackColor = false;
            nhanvien_btn.Click += nhanvien_btn_Click;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BorderStyle = BorderStyle.Fixed3D;
            username_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(96, 14);
            username_label.Name = "username_label";
            username_label.Size = new Size(122, 33);
            username_label.TabIndex = 15;
            username_label.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 14;
            label1.Text = "User: ";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            role.Location = new Point(233, 14);
            role.Name = "role";
            role.Size = new Size(73, 31);
            role.TabIndex = 28;
            role.Text = "Role: ";
            // 
            // rolename_label
            // 
            rolename_label.AutoSize = true;
            rolename_label.BorderStyle = BorderStyle.Fixed3D;
            rolename_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rolename_label.Location = new Point(312, 12);
            rolename_label.Name = "rolename_label";
            rolename_label.Size = new Size(118, 33);
            rolename_label.TabIndex = 29;
            rolename_label.Text = "rolename";
            // 
            // pb_btn
            // 
            pb_btn.BackColor = Color.Aquamarine;
            pb_btn.Cursor = Cursors.Hand;
            pb_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            pb_btn.ForeColor = SystemColors.ControlText;
            pb_btn.Location = new Point(495, 62);
            pb_btn.Name = "pb_btn";
            pb_btn.Size = new Size(131, 58);
            pb_btn.TabIndex = 30;
            pb_btn.Text = "Phòng ban";
            pb_btn.UseVisualStyleBackColor = false;
            pb_btn.Click += pb_btn_Click;
            // 
            // update_infor_btn
            // 
            update_infor_btn.BackColor = SystemColors.GradientActiveCaption;
            update_infor_btn.Cursor = Cursors.Hand;
            update_infor_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            update_infor_btn.ForeColor = SystemColors.ControlText;
            update_infor_btn.Location = new Point(15, 126);
            update_infor_btn.Name = "update_infor_btn";
            update_infor_btn.Size = new Size(200, 58);
            update_infor_btn.TabIndex = 31;
            update_infor_btn.Text = "Cập nhật thông tin";
            update_infor_btn.UseVisualStyleBackColor = false;
            update_infor_btn.Click += update_infor_btn_Click;
            // 
            // user_list_view
            // 
            user_list_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            user_list_view.Location = new Point(15, 232);
            user_list_view.Name = "user_list_view";
            user_list_view.RowHeadersWidth = 51;
            user_list_view.RowTemplate.Height = 29;
            user_list_view.Size = new Size(960, 441);
            user_list_view.TabIndex = 32;
            // 
            // feature_label
            // 
            feature_label.AutoSize = true;
            feature_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            feature_label.Location = new Point(15, 187);
            feature_label.Name = "feature_label";
            feature_label.Size = new Size(94, 31);
            feature_label.TabIndex = 33;
            feature_label.Text = "Feature";
            // 
            // fNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 693);
            Controls.Add(feature_label);
            Controls.Add(user_list_view);
            Controls.Add(update_infor_btn);
            Controls.Add(pb_btn);
            Controls.Add(rolename_label);
            Controls.Add(role);
            Controls.Add(log_out_btn);
            Controls.Add(da_btn);
            Controls.Add(phancong_btn);
            Controls.Add(nhanvien_btn);
            Controls.Add(username_label);
            Controls.Add(label1);
            Name = "fNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fNhanVien";
            Load += fNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)user_list_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button log_out_btn;
        private Button da_btn;
        private Button phancong_btn;
        private Button nhanvien_btn;
        private Label username_label;
        private Label label1;
        private Label role;
        private Label rolename_label;
        private Button pb_btn;
        private Button update_infor_btn;
        private DataGridView user_list_view;
        private Label feature_label;
    }
}