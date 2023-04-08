namespace PH1
{
    public partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            username = new Label();
            password = new Label();
            title = new Label();
            pictureBox1 = new PictureBox();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            connect_btn = new Button();
            cancel_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(195, 93);
            username.Name = "username";
            username.Size = new Size(117, 31);
            username.TabIndex = 0;
            username.Text = "Username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(195, 160);
            password.Name = "password";
            password.Size = new Size(110, 31);
            password.TabIndex = 1;
            password.Text = "Password";
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Location = new Point(195, 23);
            title.Name = "title";
            title.Size = new Size(255, 50);
            title.TabIndex = 2;
            title.Text = "CONNECT TO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // username_textbox
            // 
            username_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username_textbox.Location = new Point(350, 90);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(200, 34);
            username_textbox.TabIndex = 4;
            // 
            // password_textbox
            // 
            password_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password_textbox.Location = new Point(350, 157);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(200, 34);
            password_textbox.TabIndex = 5;
            password_textbox.UseSystemPasswordChar = true;
            // 
            // connect_btn
            // 
            connect_btn.BackColor = Color.SpringGreen;
            connect_btn.Cursor = Cursors.Hand;
            connect_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            connect_btn.ForeColor = Color.Black;
            connect_btn.Location = new Point(608, 76);
            connect_btn.Name = "connect_btn";
            connect_btn.Size = new Size(143, 52);
            connect_btn.TabIndex = 6;
            connect_btn.Text = "CONNECT";
            connect_btn.UseVisualStyleBackColor = false;
            connect_btn.Click += connect_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.Salmon;
            cancel_btn.Cursor = Cursors.Hand;
            cancel_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_btn.ForeColor = Color.Black;
            cancel_btn.Location = new Point(608, 151);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(143, 52);
            cancel_btn.TabIndex = 7;
            cancel_btn.Text = "CANCEL";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(440, 23);
            label1.Name = "label1";
            label1.Size = new Size(161, 50);
            label1.TabIndex = 8;
            label1.Text = "ORACLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(590, 23);
            label2.Name = "label2";
            label2.Size = new Size(207, 50);
            label2.TabIndex = 9;
            label2.Text = "DATABASE";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(802, 227);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel_btn);
            Controls.Add(connect_btn);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(pictureBox1);
            Controls.Add(title);
            Controls.Add(password);
            Controls.Add(username);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label password;
        private Label title;
        private PictureBox pictureBox1;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private Button connect_btn;
        private Button cancel_btn;
        private Label label1;
        private Label label2;
    }
}