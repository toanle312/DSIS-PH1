namespace App
{
    partial class fAddRole
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
            rolename_textbox = new TextBox();
            button1 = new Button();
            ResultLabel = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 113);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Rolename";
            // 
            // rolename_textbox
            // 
            rolename_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rolename_textbox.Location = new Point(308, 108);
            rolename_textbox.Name = "rolename_textbox";
            rolename_textbox.Size = new Size(153, 34);
            rolename_textbox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(486, 106);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(226, 185);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(29, 20);
            ResultLabel.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe Script", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(267, 9);
            label2.Name = "label2";
            label2.Size = new Size(289, 70);
            label2.TabIndex = 11;
            label2.Text = "ADD ROLE";
            // 
            // fAddRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ResultLabel);
            Controls.Add(button1);
            Controls.Add(rolename_textbox);
            Controls.Add(label1);
            Name = "fAddRole";
            Text = "fAddRole";
            Load += fAddRole_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox rolename_textbox;
        private Button button1;
        private Label ResultLabel;
        private Label label2;
    }
}