namespace App
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
            this.exec_revoke = new System.Windows.Forms.Button();
            this.revoked_priv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_role = new System.Windows.Forms.TextBox();
            this.role_priv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exec_revoke
            // 
            this.exec_revoke.Location = new System.Drawing.Point(328, 258);
            this.exec_revoke.Name = "exec_revoke";
            this.exec_revoke.Size = new System.Drawing.Size(75, 23);
            this.exec_revoke.TabIndex = 0;
            this.exec_revoke.Text = "Execute";
            this.exec_revoke.UseVisualStyleBackColor = true;
            this.exec_revoke.Click += new System.EventHandler(this.button1_Click);
            // 
            // revoked_priv
            // 
            this.revoked_priv.AutoSize = true;
            this.revoked_priv.Location = new System.Drawing.Point(21, 226);
            this.revoked_priv.Name = "revoked_priv";
            this.revoked_priv.Size = new System.Drawing.Size(121, 15);
            this.revoked_priv.TabIndex = 1;
            this.revoked_priv.Text = "Revoke Privilege/Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "from User/Role";
            // 
            // user_role
            // 
            this.user_role.Location = new System.Drawing.Point(603, 223);
            this.user_role.Name = "user_role";
            this.user_role.Size = new System.Drawing.Size(162, 23);
            this.user_role.TabIndex = 4;
            // 
            // role_priv
            // 
            this.role_priv.Location = new System.Drawing.Point(148, 223);
            this.role_priv.Name = "role_priv";
            this.role_priv.Size = new System.Drawing.Size(334, 23);
            this.role_priv.TabIndex = 5;
            // 
            // fRevokePrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.role_priv);
            this.Controls.Add(this.user_role);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.revoked_priv);
            this.Controls.Add(this.exec_revoke);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRevokePrivs";
            this.Text = "fRevokePrivs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exec_revoke;
        private Label revoked_priv;
        private Label label1;
        private TextBox user_role;
        private TextBox role_priv;
    }
}