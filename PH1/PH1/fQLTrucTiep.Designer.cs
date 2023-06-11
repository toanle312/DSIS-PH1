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
            label5 = new Label();
            log_out_btn = new Button();
            rolename_label = new Label();
            role = new Label();
            username_label = new Label();
            label6 = new Label();
            EmployeeInterfaceButton = new Button();
            infoView = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)infoView).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 417);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 17;
            // 
            // log_out_btn
            // 
            log_out_btn.BackColor = Color.Salmon;
            log_out_btn.Cursor = Cursors.Hand;
            log_out_btn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            log_out_btn.Location = new Point(803, 12);
            log_out_btn.Name = "log_out_btn";
            log_out_btn.Size = new Size(169, 53);
            log_out_btn.TabIndex = 36;
            log_out_btn.Text = "Đăng xuất";
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
            rolename_label.Size = new Size(143, 33);
            rolename_label.TabIndex = 40;
            rolename_label.Text = "QL trực tiếp";
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
            // EmployeeInterfaceButton
            // 
            EmployeeInterfaceButton.BackColor = SystemColors.GradientActiveCaption;
            EmployeeInterfaceButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeInterfaceButton.Location = new Point(12, 76);
            EmployeeInterfaceButton.Margin = new Padding(3, 4, 3, 4);
            EmployeeInterfaceButton.Name = "EmployeeInterfaceButton";
            EmployeeInterfaceButton.Size = new Size(202, 51);
            EmployeeInterfaceButton.TabIndex = 46;
            EmployeeInterfaceButton.Text = "Giao diện nhân viên";
            EmployeeInterfaceButton.UseVisualStyleBackColor = false;
            EmployeeInterfaceButton.Click += EmployeeInterfaceButton_Click;
            // 
            // infoView
            // 
            infoView.BackgroundColor = Color.WhiteSmoke;
            infoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoView.Location = new Point(12, 142);
            infoView.Name = "infoView";
            infoView.RowHeadersWidth = 51;
            infoView.RowTemplate.Height = 29;
            infoView.Size = new Size(960, 381);
            infoView.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.Aquamarine;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(220, 76);
            button3.Name = "button3";
            button3.Size = new Size(239, 51);
            button3.TabIndex = 7;
            button3.Text = "Thông tin các nhân viên";
            button3.UseVisualStyleBackColor = false;
            button3.Click += employeeInfo_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(465, 76);
            button4.Name = "button4";
            button4.Size = new Size(192, 52);
            button4.TabIndex = 8;
            button4.Text = "Bảng phân công";
            button4.UseVisualStyleBackColor = false;
            button4.Click += phancong_Click;
            // 
            // fQLTrucTiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 535);
            Controls.Add(EmployeeInterfaceButton);
            Controls.Add(rolename_label);
            Controls.Add(role);
            Controls.Add(username_label);
            Controls.Add(label6);
            Controls.Add(log_out_btn);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(infoView);
            Name = "fQLTrucTiep";
            Text = "fQLTrucTiep";
            ((System.ComponentModel.ISupportInitialize)infoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button log_out_btn;
        private Label rolename_label;
        private Label role;
        private Label username_label;
        private Label label6;
        private Button EmployeeInterfaceButton;
        private DataGridView infoView;
        private Button button3;
        private Button button4;
    }
}