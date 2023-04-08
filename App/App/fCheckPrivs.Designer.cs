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
            c_table_priv = new Button();
            c_column_priv = new Button();
            c_sys_priv = new Button();
            table_priv_view = new DataGridView();
            name_or_role = new Label();
            name_init = new TextBox();
            c_role_user = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)table_priv_view).BeginInit();
            SuspendLayout();
            // 
            // c_table_priv
            // 
            c_table_priv.BackColor = Color.LightSkyBlue;
            c_table_priv.Cursor = Cursors.Hand;
            c_table_priv.Location = new Point(53, 144);
            c_table_priv.Margin = new Padding(3, 4, 3, 4);
            c_table_priv.Name = "c_table_priv";
            c_table_priv.Size = new Size(173, 41);
            c_table_priv.TabIndex = 0;
            c_table_priv.Text = "Check Table Privileges";
            c_table_priv.UseVisualStyleBackColor = false;
            c_table_priv.Click += c_table_priv_Click;
            // 
            // c_column_priv
            // 
            c_column_priv.BackColor = Color.LightSkyBlue;
            c_column_priv.Cursor = Cursors.Hand;
            c_column_priv.Location = new Point(244, 144);
            c_column_priv.Margin = new Padding(3, 4, 3, 4);
            c_column_priv.Name = "c_column_priv";
            c_column_priv.Size = new Size(184, 41);
            c_column_priv.TabIndex = 1;
            c_column_priv.Text = "Check Column Privileges";
            c_column_priv.UseVisualStyleBackColor = false;
            c_column_priv.Click += c_column_priv_Click;
            // 
            // c_sys_priv
            // 
            c_sys_priv.BackColor = Color.LightSkyBlue;
            c_sys_priv.Cursor = Cursors.Hand;
            c_sys_priv.Location = new Point(448, 144);
            c_sys_priv.Margin = new Padding(3, 4, 3, 4);
            c_sys_priv.Name = "c_sys_priv";
            c_sys_priv.Size = new Size(177, 41);
            c_sys_priv.TabIndex = 2;
            c_sys_priv.Text = "Check System Privileges";
            c_sys_priv.UseVisualStyleBackColor = false;
            c_sys_priv.Click += c_sys_priv_Click;
            // 
            // table_priv_view
            // 
            table_priv_view.AllowUserToAddRows = false;
            table_priv_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_priv_view.EditMode = DataGridViewEditMode.EditProgrammatically;
            table_priv_view.Location = new Point(39, 193);
            table_priv_view.Margin = new Padding(3, 4, 3, 4);
            table_priv_view.Name = "table_priv_view";
            table_priv_view.RowHeadersWidth = 51;
            table_priv_view.RowTemplate.Height = 25;
            table_priv_view.Size = new Size(802, 295);
            table_priv_view.TabIndex = 3;
            // 
            // name_or_role
            // 
            name_or_role.AutoSize = true;
            name_or_role.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_or_role.Location = new Point(53, 94);
            name_or_role.Name = "name_or_role";
            name_or_role.Size = new Size(135, 23);
            name_or_role.TabIndex = 4;
            name_or_role.Text = "User/Role Name";
            // 
            // name_init
            // 
            name_init.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name_init.Location = new Point(194, 85);
            name_init.Margin = new Padding(3, 4, 3, 4);
            name_init.Name = "name_init";
            name_init.Size = new Size(209, 34);
            name_init.TabIndex = 5;
            name_init.Text = "\r\n";
            // 
            // c_role_user
            // 
            c_role_user.BackColor = Color.LightSkyBlue;
            c_role_user.Cursor = Cursors.Hand;
            c_role_user.Location = new Point(642, 144);
            c_role_user.Margin = new Padding(3, 4, 3, 4);
            c_role_user.Name = "c_role_user";
            c_role_user.Size = new Size(154, 41);
            c_role_user.TabIndex = 6;
            c_role_user.Text = "Check Roles Of User";
            c_role_user.UseVisualStyleBackColor = false;
            c_role_user.Click += c_role_user_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe Script", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(217, 9);
            label2.Name = "label2";
            label2.Size = new Size(481, 70);
            label2.TabIndex = 10;
            label2.Text = "CHECK PRIVILEGES";
            label2.Click += label2_Click;
            // 
            // fCheckPrivs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(c_role_user);
            Controls.Add(name_init);
            Controls.Add(name_or_role);
            Controls.Add(table_priv_view);
            Controls.Add(c_sys_priv);
            Controls.Add(c_column_priv);
            Controls.Add(c_table_priv);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "fCheckPrivs";
            Text = "fCheckPrivs";
            TransparencyKey = Color.White;
            ((System.ComponentModel.ISupportInitialize)table_priv_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button c_table_priv;
        private Button c_column_priv;
        private Button c_sys_priv;
        private DataGridView table_priv_view;
        private Label name_or_role;
        private TextBox name_init;
        private Button c_role_user;
        private Label label2;
    }
}