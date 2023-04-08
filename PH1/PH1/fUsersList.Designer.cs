namespace PH1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUsersList));
            user_list_view = new DataGridView();
            label1 = new Label();
            refresh_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)user_list_view).BeginInit();
            SuspendLayout();
            // 
            // user_list_view
            // 
            user_list_view.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            user_list_view.Location = new Point(59, 110);
            user_list_view.Name = "user_list_view";
            user_list_view.RowHeadersWidth = 51;
            user_list_view.RowTemplate.Height = 29;
            user_list_view.Size = new Size(832, 337);
            user_list_view.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe Script", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(633, 70);
            label1.TabIndex = 5;
            label1.Text = "LIST OF USERS IN SYSTEM";
            // 
            // refresh_btn
            // 
            refresh_btn.BackColor = SystemColors.ButtonFace;
            refresh_btn.Cursor = Cursors.Hand;
            refresh_btn.Image = (Image)resources.GetObject("refresh_btn.Image");
            refresh_btn.ImageAlign = ContentAlignment.MiddleLeft;
            refresh_btn.Location = new Point(60, 68);
            refresh_btn.Name = "refresh_btn";
            refresh_btn.Size = new Size(94, 36);
            refresh_btn.TabIndex = 6;
            refresh_btn.Text = "Refresh";
            refresh_btn.TextAlign = ContentAlignment.MiddleRight;
            refresh_btn.UseVisualStyleBackColor = false;
            refresh_btn.Click += refresh_btn_Click;
            // 
            // fUsersList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 500);
            Controls.Add(refresh_btn);
            Controls.Add(label1);
            Controls.Add(user_list_view);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fUsersList";
            Text = "fUsersList";
            ((System.ComponentModel.ISupportInitialize)user_list_view).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button view_btn;
        private DataGridView user_list_view;
        private Label label1;
        private Button refresh_btn;
    }
}