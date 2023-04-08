namespace App
{
    partial class fCheckPrivs
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
            this.c_table_priv = new System.Windows.Forms.Button();
            this.c_column_priv = new System.Windows.Forms.Button();
            this.c_sys_priv = new System.Windows.Forms.Button();
            this.table_priv_view = new System.Windows.Forms.DataGridView();
            this.name_or_role = new System.Windows.Forms.Label();
            this.name_init = new System.Windows.Forms.TextBox();
            this.c_role_user = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_priv_view)).BeginInit();
            this.SuspendLayout();
            // 
            // c_table_priv
            // 
            this.c_table_priv.Location = new System.Drawing.Point(46, 52);
            this.c_table_priv.Name = "c_table_priv";
            this.c_table_priv.Size = new System.Drawing.Size(151, 23);
            this.c_table_priv.TabIndex = 0;
            this.c_table_priv.Text = "Check Table Privileges";
            this.c_table_priv.UseVisualStyleBackColor = true;
            this.c_table_priv.Click += new System.EventHandler(this.c_table_priv_Click);
            // 
            // c_column_priv
            // 
            this.c_column_priv.Location = new System.Drawing.Point(225, 52);
            this.c_column_priv.Name = "c_column_priv";
            this.c_column_priv.Size = new System.Drawing.Size(161, 23);
            this.c_column_priv.TabIndex = 1;
            this.c_column_priv.Text = "Check Column Privileges";
            this.c_column_priv.UseVisualStyleBackColor = true;
            this.c_column_priv.Click += new System.EventHandler(this.c_column_priv_Click);
            // 
            // c_sys_priv
            // 
            this.c_sys_priv.Location = new System.Drawing.Point(406, 52);
            this.c_sys_priv.Name = "c_sys_priv";
            this.c_sys_priv.Size = new System.Drawing.Size(155, 23);
            this.c_sys_priv.TabIndex = 2;
            this.c_sys_priv.Text = "Check System Privileges";
            this.c_sys_priv.UseVisualStyleBackColor = true;
            this.c_sys_priv.Click += new System.EventHandler(this.c_sys_priv_Click);
            // 
            // table_priv_view
            // 
            this.table_priv_view.AllowUserToAddRows = false;
            this.table_priv_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_priv_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.table_priv_view.Location = new System.Drawing.Point(34, 94);
            this.table_priv_view.Name = "table_priv_view";
            this.table_priv_view.RowTemplate.Height = 25;
            this.table_priv_view.Size = new System.Drawing.Size(702, 272);
            this.table_priv_view.TabIndex = 3;
            // 
            // name_or_role
            // 
            this.name_or_role.AutoSize = true;
            this.name_or_role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_or_role.Location = new System.Drawing.Point(46, 21);
            this.name_or_role.Name = "name_or_role";
            this.name_or_role.Size = new System.Drawing.Size(105, 17);
            this.name_or_role.TabIndex = 4;
            this.name_or_role.Text = "User/Role Name";
            // 
            // name_init
            // 
            this.name_init.Location = new System.Drawing.Point(166, 20);
            this.name_init.Name = "name_init";
            this.name_init.Size = new System.Drawing.Size(267, 23);
            this.name_init.TabIndex = 5;
            this.name_init.Text = "\r\n";
            // 
            // c_role_user
            // 
            this.c_role_user.Location = new System.Drawing.Point(589, 52);
            this.c_role_user.Name = "c_role_user";
            this.c_role_user.Size = new System.Drawing.Size(135, 23);
            this.c_role_user.TabIndex = 6;
            this.c_role_user.Text = "Check Roles Of User";
            this.c_role_user.UseVisualStyleBackColor = true;
            this.c_role_user.Click += new System.EventHandler(this.c_role_user_Click);
            // 
            // fCheckPrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c_role_user);
            this.Controls.Add(this.name_init);
            this.Controls.Add(this.name_or_role);
            this.Controls.Add(this.table_priv_view);
            this.Controls.Add(this.c_sys_priv);
            this.Controls.Add(this.c_column_priv);
            this.Controls.Add(this.c_table_priv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fCheckPrivs";
            this.Text = "fCheckPrivs";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.table_priv_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button c_table_priv;
        private Button c_column_priv;
        private Button c_sys_priv;
        private DataGridView table_priv_view;
        private Label name_or_role;
        private TextBox name_init;
        private Button c_role_user;
    }
}