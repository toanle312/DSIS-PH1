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
            label3 = new Label();
            button1 = new Button();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 117);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Rolename";
            // 
            // rolename_textbox
            // 
            rolename_textbox.Location = new Point(50, 149);
            rolename_textbox.Name = "rolename_textbox";
            rolename_textbox.Size = new Size(153, 27);
            rolename_textbox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(38, 9);
            label3.Name = "label3";
            label3.Size = new Size(372, 67);
            label3.TabIndex = 7;
            label3.Text = "Add role sreen";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(50, 196);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Location = new Point(50, 260);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(10, 20);
            ResultLabel.TabIndex = 10;
            // 
            // fAddRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(button1);
            Controls.Add(label3);
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
        private Label label3;
        private Button button1;
        private Label ResultLabel;
    }
}