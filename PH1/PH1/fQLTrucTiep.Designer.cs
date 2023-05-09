using System.Windows.Forms;

namespace PH1
{
    partial class fQLTrucTiep
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
            personalInfoBtn = new Button();
            infoView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            diachi_textbox = new TextBox();
            label3 = new Label();
            sdt_textbox = new TextBox();
            label4 = new Label();
            ngaysinh_textbox = new DateTimePicker();
            label5 = new Label();
            phongbanBtn = new Button();
            deanBtn = new Button();
            log_out_btn = new Button();
            rolename_label = new Label();
            role = new Label();
            username_label = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)infoView).BeginInit();
            SuspendLayout();
            // 
            // personalInfoBtn
            // 
            personalInfoBtn.BackColor = SystemColors.ActiveCaption;
            personalInfoBtn.Cursor = Cursors.Hand;
            personalInfoBtn.Location = new Point(5, 76);
            personalInfoBtn.Name = "personalInfoBtn";
            personalInfoBtn.Size = new Size(121, 41);
            personalInfoBtn.TabIndex = 5;
            personalInfoBtn.Text = "Personal info";
            personalInfoBtn.UseVisualStyleBackColor = false;
            personalInfoBtn.Click += personalInfoBtn_Click;
            // 
            // infoView
            // 
            infoView.BackgroundColor = Color.WhiteSmoke;
            infoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoView.Location = new Point(12, 134);
            infoView.Name = "infoView";
            infoView.RowHeadersWidth = 51;
            infoView.RowTemplate.Height = 29;
            infoView.Size = new Size(960, 329);
            infoView.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(132, 76);
            button1.Name = "button1";
            button1.Size = new Size(121, 41);
            button1.TabIndex = 7;
            button1.Text = "Employee info";
            button1.UseVisualStyleBackColor = false;
            button1.Click += employeeInfo_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(259, 76);
            button2.Name = "button2";
            button2.Size = new Size(121, 41);
            button2.TabIndex = 8;
            button2.Text = "Phân công";
            button2.UseVisualStyleBackColor = false;
            button2.Click += phancong_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(22, 486);
            button3.Name = "button3";
            button3.Size = new Size(121, 41);
            button3.TabIndex = 9;
            button3.Text = "Edit info";
            button3.UseVisualStyleBackColor = false;
            button3.Click += editInfo_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 275);
            label1.Name = "label1";
            label1.Size = new Size(330, 28);
            label1.TabIndex = 10;
            label1.Text = "Chỉnh sửa thông tin cá nhân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 324);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 11;
            label2.Text = "Ngày sinh";
            // 
            // diachi_textbox
            // 
            diachi_textbox.Location = new Point(22, 418);
            diachi_textbox.Name = "diachi_textbox";
            diachi_textbox.Size = new Size(320, 27);
            diachi_textbox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 395);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 13;
            label3.Text = "Địa chỉ";
            // 
            // sdt_textbox
            // 
            sdt_textbox.Location = new Point(259, 352);
            sdt_textbox.Name = "sdt_textbox";
            sdt_textbox.Size = new Size(158, 27);
            sdt_textbox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 324);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 15;
            label4.Text = "Số điện thoại";
            // 
            // ngaysinh_textbox
            // 
            ngaysinh_textbox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ngaysinh_textbox.Location = new Point(22, 347);
            ngaysinh_textbox.Name = "ngaysinh_textbox";
            ngaysinh_textbox.Size = new Size(210, 32);
            ngaysinh_textbox.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 417);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 17;
            // 
            // phongbanBtn
            // 
            phongbanBtn.BackColor = SystemColors.ActiveCaption;
            phongbanBtn.Cursor = Cursors.Hand;
            phongbanBtn.Location = new Point(386, 76);
            phongbanBtn.Name = "phongbanBtn";
            phongbanBtn.Size = new Size(121, 41);
            phongbanBtn.TabIndex = 34;
            phongbanBtn.Text = "Phòng ban";
            phongbanBtn.UseVisualStyleBackColor = false;
            phongbanBtn.Click += phongbanBtn_Click;
            // 
            // deanBtn
            // 
            deanBtn.BackColor = SystemColors.ActiveCaption;
            deanBtn.Cursor = Cursors.Hand;
            deanBtn.Location = new Point(513, 76);
            deanBtn.Name = "deanBtn";
            deanBtn.Size = new Size(121, 41);
            deanBtn.TabIndex = 35;
            deanBtn.Text = "Đề án";
            deanBtn.UseVisualStyleBackColor = false;
            deanBtn.Click += deanBtn_Click;
            // 
            // log_out_btn
            // 
            log_out_btn.BackColor = Color.LightCoral;
            log_out_btn.Cursor = Cursors.Hand;
            log_out_btn.Location = new Point(526, 17);
            log_out_btn.Name = "log_out_btn";
            log_out_btn.Size = new Size(94, 40);
            log_out_btn.TabIndex = 36;
            log_out_btn.Text = "Log Out";
            log_out_btn.UseVisualStyleBackColor = false;
            log_out_btn.Click += log_out_btn_Click;
            // 
            // rolename_label
            // 
            rolename_label.AutoSize = true;
            rolename_label.BorderStyle = BorderStyle.Fixed3D;
            rolename_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rolename_label.Location = new Point(299, 18);
            rolename_label.Name = "rolename_label";
            rolename_label.Size = new Size(193, 33);
            rolename_label.TabIndex = 40;
            rolename_label.Text = "Quản lí trực tiếp";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            role.Location = new Point(238, 20);
            role.Name = "role";
            role.Size = new Size(73, 31);
            role.TabIndex = 39;
            role.Text = "Role: ";
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BorderStyle = BorderStyle.Fixed3D;
            username_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(82, 20);
            username_label.Name = "username_label";
            username_label.Size = new Size(122, 33);
            username_label.TabIndex = 38;
            username_label.Text = "username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(75, 31);
            label6.TabIndex = 37;
            label6.Text = "User: ";
            // 
            // fQLTrucTiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 535);
            Controls.Add(rolename_label);
            Controls.Add(role);
            Controls.Add(username_label);
            Controls.Add(label6);
            Controls.Add(log_out_btn);
            Controls.Add(deanBtn);
            Controls.Add(phongbanBtn);
            Controls.Add(label5);
            Controls.Add(ngaysinh_textbox);
            Controls.Add(sdt_textbox);
            Controls.Add(label4);
            Controls.Add(diachi_textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(infoView);
            Controls.Add(personalInfoBtn);
            Name = "fQLTrucTiep";
            Text = "fQLTrucTiep";
            ((System.ComponentModel.ISupportInitialize)infoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button personalInfoBtn;
        private DataGridView infoView;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox diachi_textbox;
        private Label label3;
        private TextBox sdt_textbox;
        private Label label4;
        private DateTimePicker ngaysinh_textbox;
        private Label label5;
        private Button phongbanBtn;
        private Button deanBtn;
        private Button log_out_btn;
        private Label rolename_label;
        private Label role;
        private Label username_label;
        private Label label6;
    }
}