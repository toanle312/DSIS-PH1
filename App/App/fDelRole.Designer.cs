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
            label1 = new Label();
            rolenameLabel = new Label();
            rolename_textbox = new TextBox();
            Delete = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(426, 67);
            label1.TabIndex = 7;
            label1.Text = "Delete role sreen";
            // 
            // rolenameLabel
            // 
            rolenameLabel.AutoSize = true;
            rolenameLabel.Location = new Point(52, 102);
            rolenameLabel.Name = "rolenameLabel";
            rolenameLabel.Size = new Size(76, 20);
            rolenameLabel.TabIndex = 1;
            rolenameLabel.Text = "Rolename";
            // 
            // rolename_textbox
            // 
            rolename_textbox.Location = new Point(52, 125);
            rolename_textbox.Name = "rolename_textbox";
            rolename_textbox.Size = new Size(146, 27);
            rolename_textbox.TabIndex = 2;
            // 
            // Delete
            // 
            Delete.BackColor = Color.DarkOrange;
            Delete.Location = new Point(52, 170);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(52, 224);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 8;
            // 
            // fDelRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(Delete);
            Controls.Add(rolename_textbox);
            Controls.Add(rolenameLabel);
            Controls.Add(label1);
            Name = "fDelRole";
            Text = "fDelRole";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label rolenameLabel;
        private TextBox rolename_textbox;
        private Button Delete;
        private Label resultLabel;
    }
}