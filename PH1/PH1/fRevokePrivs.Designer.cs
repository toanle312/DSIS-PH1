namespace PH1
{
    partial class fRevokePrivs
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
            exec_revoke = new Button();
            revoked_priv = new Label();
            label1 = new Label();
            user_role = new TextBox();
            role_priv = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // exec_revoke
            // 
            exec_revoke.BackColor = Color.Khaki;
            exec_revoke.Cursor = Cursors.Hand;
            exec_revoke.Location = new Point(401, 206);
            exec_revoke.Margin = new Padding(3, 4, 3, 4);
            exec_revoke.Name = "exec_revoke";
            exec_revoke.Size = new Size(106, 41);
            exec_revoke.TabIndex = 0;
            exec_revoke.Text = "Revoke";
            exec_revoke.UseVisualStyleBackColor = false;
            exec_revoke.Click += button1_Click;
            // 
            // revoked_priv
            // 
            revoked_priv.AutoSize = true;
            revoked_priv.Location = new Point(28, 149);
            revoked_priv.Name = "revoked_priv";
            revoked_priv.Size = new Size(154, 20);
            revoked_priv.TabIndex = 1;
            revoked_priv.Text = "Revoke Privilege/Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 146);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "from User/Role";
            // 
            // user_role
            // 
            user_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user_role.Location = new Point(691, 139);
            user_role.Margin = new Padding(3, 4, 3, 4);
            user_role.Name = "user_role";
            user_role.Size = new Size(185, 34);
            user_role.TabIndex = 4;
            // 
            // role_priv
            // 
            role_priv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            role_priv.Location = new Point(188, 139);
            role_priv.Margin = new Padding(3, 4, 3, 4);
            role_priv.Name = "role_priv";
            role_priv.Size = new Size(381, 34);
            role_priv.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe Script", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(201, 30);
            label4.Name = "label4";
            label4.Size = new Size(523, 70);
            label4.TabIndex = 10;
            label4.Text = "REVOKE PRIVILEGES";
            // 
            // fRevokePrivs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(role_priv);
            Controls.Add(user_role);
            Controls.Add(label1);
            Controls.Add(revoked_priv);
            Controls.Add(exec_revoke);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fRevokePrivs";
            Text = "fRevokePrivs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exec_revoke;
        private Label revoked_priv;
        private Label label1;
        private TextBox user_role;
        private TextBox role_priv;
        private Label label4;
    }
}