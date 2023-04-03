namespace App
{
    partial class fUsersList
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
            view_btn = new Button();
            user_list_view = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)user_list_view).BeginInit();
            SuspendLayout();
            // 
            // view_btn
            // 
            view_btn.Location = new Point(74, 27);
            view_btn.Name = "view_btn";
            view_btn.Size = new Size(94, 29);
            view_btn.TabIndex = 3;
            view_btn.Text = "View";
            view_btn.UseVisualStyleBackColor = true;
            view_btn.Click += view_btn_Click;
            // 
            // user_list_view
            // 
            user_list_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            user_list_view.Location = new Point(58, 103);
            user_list_view.Name = "user_list_view";
            user_list_view.RowHeadersWidth = 51;
            user_list_view.RowTemplate.Height = 29;
            user_list_view.Size = new Size(832, 358);
            user_list_view.TabIndex = 4;
            // 
            // fUsersList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 500);
            Controls.Add(user_list_view);
            Controls.Add(view_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fUsersList";
            Text = "fUsersList";
            ((System.ComponentModel.ISupportInitialize)user_list_view).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button view_btn;
        private DataGridView user_list_view;
    }
}