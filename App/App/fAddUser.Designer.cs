namespace App
{
    partial class fAddUser
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
            label2 = new Label();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            resultLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(50, 264);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 108);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 189);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(51, 131);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(166, 27);
            username_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(51, 212);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(167, 27);
            password_textbox.TabIndex = 4;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(50, 317);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 20);
            resultLabel.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumAquamarine;
            label3.Location = new Point(38, 9);
            label3.Name = "label3";
            label3.Size = new Size(379, 67);
            label3.TabIndex = 7;
            label3.Text = "Add user sreen";
            // 
            // fAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(resultLabel);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "fAddUser";
            Text = "fAddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private Label resultLabel;
        private Label label3;
    }
}