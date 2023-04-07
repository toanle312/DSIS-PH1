namespace App
{
    partial class fEditUser
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
            button1 = new Button();
            label1 = new Label();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(54, 243);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(373, 67);
            label1.TabIndex = 7;
            label1.Text = "Edit user sreen";
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(54, 121);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(168, 27);
            username_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(54, 195);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(168, 27);
            password_textbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 98);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 172);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 5;
            label3.Text = "New password";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(54, 298);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 8;
            // 
            // fEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "fEditUser";
            Text = "fEditUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private Label label2;
        private Label label3;
        private Label resultLabel;
    }
}