namespace App
{
    partial class fDelUser
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
            label2 = new Label();
            username_textbox = new TextBox();
            button1 = new Button();
            resultLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 133);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // username_textbox
            // 
            username_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_textbox.Location = new Point(283, 123);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(145, 34);
            username_textbox.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(457, 120);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(202, 195);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(29, 20);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe Script", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(202, 20);
            label3.Name = "label3";
            label3.Size = new Size(362, 70);
            label3.TabIndex = 8;
            label3.Text = "DELETE USER";
            // 
            // fDelUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(resultLabel);
            Controls.Add(button1);
            Controls.Add(username_textbox);
            Controls.Add(label2);
            ForeColor = Color.Black;
            Name = "fDelUser";
            Text = "fDelUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox username_textbox;
        private Button button1;
        private Label resultLabel;
        private Label label3;
    }
}