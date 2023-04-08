namespace App
{
    partial class fDelRole
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
            rolenameLabel = new Label();
            rolename_textbox = new TextBox();
            Delete = new Button();
            resultLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // rolenameLabel
            // 
            rolenameLabel.AutoSize = true;
            rolenameLabel.Location = new Point(208, 126);
            rolenameLabel.Name = "rolenameLabel";
            rolenameLabel.Size = new Size(76, 20);
            rolenameLabel.TabIndex = 1;
            rolenameLabel.Text = "Rolename";
            // 
            // rolename_textbox
            // 
            rolename_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rolename_textbox.Location = new Point(290, 116);
            rolename_textbox.Name = "rolename_textbox";
            rolename_textbox.Size = new Size(146, 34);
            rolename_textbox.TabIndex = 2;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Khaki;
            Delete.Location = new Point(470, 114);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 41);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(208, 190);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(25, 20);
            resultLabel.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe Script", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(208, 23);
            label2.Name = "label2";
            label2.Size = new Size(367, 70);
            label2.TabIndex = 9;
            label2.Text = "DELETE ROLE";
            // 
            // fDelRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(resultLabel);
            Controls.Add(Delete);
            Controls.Add(rolename_textbox);
            Controls.Add(rolenameLabel);
            Name = "fDelRole";
            Text = "fDelRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label rolenameLabel;
        private TextBox rolename_textbox;
        private Button Delete;
        private Label resultLabel;
        private Label label2;
    }
}