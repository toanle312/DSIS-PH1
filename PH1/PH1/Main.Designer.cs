namespace PH1
{
    partial class Main
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
            label1 = new Label();
            username_label = new Label();
            user_list_btn = new Button();
            check_privs_btn = new Button();
            add_user_btn = new Button();
            add_role_btn = new Button();
            edit_user_btn = new Button();
            del_user_btn = new Button();
            del_role_btn = new Button();
            revoke_privs_btn = new Button();
            grant_role_btn = new Button();
            grant_privs_btn = new Button();
            control = new Panel();
            log_out_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 0;
            label1.Text = "User: ";
            label1.Click += label1_Click;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.BorderStyle = BorderStyle.Fixed3D;
            username_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            username_label.Location = new Point(93, 9);
            username_label.Name = "username_label";
            username_label.Size = new Size(122, 33);
            username_label.TabIndex = 1;
            username_label.Text = "username";
            username_label.Click += username_label_Click;
            // 
            // user_list_btn
            // 
            user_list_btn.BackColor = SystemColors.ActiveCaption;
            user_list_btn.Cursor = Cursors.Hand;
            user_list_btn.Location = new Point(12, 57);
            user_list_btn.Name = "user_list_btn";
            user_list_btn.Size = new Size(131, 41);
            user_list_btn.TabIndex = 2;
            user_list_btn.Text = "Users List";
            user_list_btn.UseVisualStyleBackColor = false;
            user_list_btn.Click += user_list_btn_Click;
            // 
            // check_privs_btn
            // 
            check_privs_btn.BackColor = SystemColors.ActiveCaption;
            check_privs_btn.Cursor = Cursors.Hand;
            check_privs_btn.Location = new Point(149, 57);
            check_privs_btn.Name = "check_privs_btn";
            check_privs_btn.Size = new Size(131, 41);
            check_privs_btn.TabIndex = 3;
            check_privs_btn.Text = "Check Privileges";
            check_privs_btn.UseVisualStyleBackColor = false;
            check_privs_btn.Click += check_privs_btn_Click;
            // 
            // add_user_btn
            // 
            add_user_btn.BackColor = SystemColors.ActiveCaption;
            add_user_btn.Cursor = Cursors.Hand;
            add_user_btn.Location = new Point(286, 57);
            add_user_btn.Name = "add_user_btn";
            add_user_btn.Size = new Size(131, 41);
            add_user_btn.TabIndex = 4;
            add_user_btn.Text = "Add User";
            add_user_btn.UseVisualStyleBackColor = false;
            add_user_btn.Click += add_user_btn_Click;
            // 
            // add_role_btn
            // 
            add_role_btn.BackColor = SystemColors.ActiveCaption;
            add_role_btn.Cursor = Cursors.Hand;
            add_role_btn.Location = new Point(697, 57);
            add_role_btn.Name = "add_role_btn";
            add_role_btn.Size = new Size(131, 41);
            add_role_btn.TabIndex = 7;
            add_role_btn.Text = "Add Role";
            add_role_btn.UseVisualStyleBackColor = false;
            add_role_btn.Click += add_role_btn_Click;
            // 
            // edit_user_btn
            // 
            edit_user_btn.BackColor = SystemColors.ActiveCaption;
            edit_user_btn.Cursor = Cursors.Hand;
            edit_user_btn.Location = new Point(560, 57);
            edit_user_btn.Name = "edit_user_btn";
            edit_user_btn.Size = new Size(131, 41);
            edit_user_btn.TabIndex = 6;
            edit_user_btn.Text = "Edit User";
            edit_user_btn.UseVisualStyleBackColor = false;
            edit_user_btn.Click += edit_user_btn_Click;
            // 
            // del_user_btn
            // 
            del_user_btn.BackColor = SystemColors.ActiveCaption;
            del_user_btn.Cursor = Cursors.Hand;
            del_user_btn.Location = new Point(423, 57);
            del_user_btn.Name = "del_user_btn";
            del_user_btn.Size = new Size(131, 41);
            del_user_btn.TabIndex = 5;
            del_user_btn.Text = "Delete User";
            del_user_btn.UseVisualStyleBackColor = false;
            del_user_btn.Click += del_user_btn_Click;
            // 
            // del_role_btn
            // 
            del_role_btn.BackColor = SystemColors.ActiveCaption;
            del_role_btn.Cursor = Cursors.Hand;
            del_role_btn.Location = new Point(834, 57);
            del_role_btn.Name = "del_role_btn";
            del_role_btn.Size = new Size(131, 41);
            del_role_btn.TabIndex = 8;
            del_role_btn.Text = "Delete Role";
            del_role_btn.UseVisualStyleBackColor = false;
            del_role_btn.Click += del_role_btn_Click;
            // 
            // revoke_privs_btn
            // 
            revoke_privs_btn.BackColor = SystemColors.ActiveCaption;
            revoke_privs_btn.Cursor = Cursors.Hand;
            revoke_privs_btn.Location = new Point(305, 104);
            revoke_privs_btn.Name = "revoke_privs_btn";
            revoke_privs_btn.Size = new Size(146, 41);
            revoke_privs_btn.TabIndex = 11;
            revoke_privs_btn.Text = "Revoke Privileges";
            revoke_privs_btn.UseVisualStyleBackColor = false;
            revoke_privs_btn.Click += revoke_privs_btn_Click;
            // 
            // grant_role_btn
            // 
            grant_role_btn.BackColor = SystemColors.ActiveCaption;
            grant_role_btn.Cursor = Cursors.Hand;
            grant_role_btn.Location = new Point(149, 104);
            grant_role_btn.Name = "grant_role_btn";
            grant_role_btn.Size = new Size(150, 41);
            grant_role_btn.TabIndex = 10;
            grant_role_btn.Text = "Grant Role To User";
            grant_role_btn.UseVisualStyleBackColor = false;
            grant_role_btn.Click += grant_role_btn_Click;
            // 
            // grant_privs_btn
            // 
            grant_privs_btn.BackColor = SystemColors.ActiveCaption;
            grant_privs_btn.Cursor = Cursors.Hand;
            grant_privs_btn.Location = new Point(12, 104);
            grant_privs_btn.Name = "grant_privs_btn";
            grant_privs_btn.Size = new Size(131, 41);
            grant_privs_btn.TabIndex = 9;
            grant_privs_btn.Text = "Grant Privileges";
            grant_privs_btn.UseVisualStyleBackColor = false;
            grant_privs_btn.Click += grant_privs_btn_Click;
            // 
            // control
            // 
            control.BorderStyle = BorderStyle.FixedSingle;
            control.Location = new Point(19, 174);
            control.Margin = new Padding(10);
            control.Name = "control";
            control.Size = new Size(950, 500);
            control.TabIndex = 12;
            control.Paint += control_Paint;
            // 
            // log_out_btn
            // 
            log_out_btn.BackColor = Color.LightCoral;
            log_out_btn.Cursor = Cursors.Hand;
            log_out_btn.Location = new Point(238, 8);
            log_out_btn.Name = "log_out_btn";
            log_out_btn.Size = new Size(94, 40);
            log_out_btn.TabIndex = 13;
            log_out_btn.Text = "Log Out";
            log_out_btn.UseVisualStyleBackColor = false;
            log_out_btn.Click += log_out_btn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(987, 693);
            Controls.Add(log_out_btn);
            Controls.Add(control);
            Controls.Add(revoke_privs_btn);
            Controls.Add(grant_role_btn);
            Controls.Add(grant_privs_btn);
            Controls.Add(del_role_btn);
            Controls.Add(add_role_btn);
            Controls.Add(edit_user_btn);
            Controls.Add(del_user_btn);
            Controls.Add(add_user_btn);
            Controls.Add(check_privs_btn);
            Controls.Add(user_list_btn);
            Controls.Add(username_label);
            Controls.Add(label1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label username_label;
        private Button user_list_btn;
        private Button check_privs_btn;
        private Button add_user_btn;
        private Button add_role_btn;
        private Button edit_user_btn;
        private Button del_user_btn;
        private Button del_role_btn;
        private Button revoke_privs_btn;
        private Button grant_role_btn;
        private Button grant_privs_btn;
        private Panel control;
        private Button log_out_btn;
    }
}