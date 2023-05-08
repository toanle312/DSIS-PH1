using System.Windows.Forms;

namespace PH1
{
    partial class fTruongPhong
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
            personalInfoBtn = new Button();
            button1 = new Button();
            button2 = new Button();
            infoView = new DataGridView();
            UpdateBtn = new Button();
            AddBtn = new Button();
            DeleteBtn = new Button();
            manvTb = new TextBox();
            madaTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            thoigianTb = new TextBox();
            SubmitBtn = new Button();
            label4 = new Label();
            AddOkBtn = new Button();
            DeleteOkBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)infoView).BeginInit();
            SuspendLayout();
            // 
            // personalInfoBtn
            // 
            personalInfoBtn.BackColor = SystemColors.ActiveCaption;
            personalInfoBtn.Cursor = Cursors.Hand;
            personalInfoBtn.Location = new Point(12, 21);
            personalInfoBtn.Name = "personalInfoBtn";
            personalInfoBtn.Size = new Size(121, 41);
            personalInfoBtn.TabIndex = 6;
            personalInfoBtn.Text = "Personal info";
            personalInfoBtn.UseVisualStyleBackColor = false;
            personalInfoBtn.Click += personalInfoBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(149, 21);
            button1.Name = "button1";
            button1.Size = new Size(121, 41);
            button1.TabIndex = 8;
            button1.Text = "Employee info";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(295, 21);
            button2.Name = "button2";
            button2.Size = new Size(121, 41);
            button2.TabIndex = 9;
            button2.Text = "Phân công";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // infoView
            // 
            infoView.ColumnHeadersHeight = 29;
            infoView.Location = new Point(12, 86);
            infoView.Name = "infoView";
            infoView.RowHeadersWidth = 51;
            infoView.RowTemplate.Height = 29;
            infoView.Size = new Size(960, 329);
            infoView.TabIndex = 10;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.LightSkyBlue;
            UpdateBtn.Cursor = Cursors.Hand;
            UpdateBtn.Location = new Point(459, 86);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(101, 41);
            UpdateBtn.TabIndex = 11;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(192, 255, 192);
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.Location = new Point(586, 86);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(80, 41);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(255, 192, 128);
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.Location = new Point(696, 86);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(101, 41);
            DeleteBtn.TabIndex = 13;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // manvTb
            // 
            manvTb.Location = new Point(462, 175);
            manvTb.Name = "manvTb";
            manvTb.Size = new Size(125, 27);
            manvTb.TabIndex = 14;
            // 
            // madaTb
            // 
            madaTb.Location = new Point(462, 244);
            madaTb.Name = "madaTb";
            madaTb.Size = new Size(125, 27);
            madaTb.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(462, 152);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 16;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 221);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 17;
            label2.Text = "Mã đề án";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 288);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 19;
            label3.Text = "Thời gian";
            // 
            // thoigianTb
            // 
            thoigianTb.Location = new Point(462, 311);
            thoigianTb.Name = "thoigianTb";
            thoigianTb.Size = new Size(125, 27);
            thoigianTb.TabIndex = 18;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.LightSkyBlue;
            SubmitBtn.Cursor = Cursors.Hand;
            SubmitBtn.Location = new Point(462, 387);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(55, 41);
            SubmitBtn.TabIndex = 20;
            SubmitBtn.Text = "Ok";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 364);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 21;
            label4.Text = "label4";
            // 
            // AddOkBtn
            // 
            AddOkBtn.BackColor = Color.LightSkyBlue;
            AddOkBtn.Cursor = Cursors.Hand;
            AddOkBtn.Location = new Point(518, 387);
            AddOkBtn.Name = "AddOkBtn";
            AddOkBtn.Size = new Size(55, 41);
            AddOkBtn.TabIndex = 22;
            AddOkBtn.Text = "Ok";
            AddOkBtn.UseVisualStyleBackColor = false;
            AddOkBtn.Click += AddOkBtn_Click;
            // 
            // DeleteOkBtn
            // 
            DeleteOkBtn.BackColor = Color.LightSkyBlue;
            DeleteOkBtn.Cursor = Cursors.Hand;
            DeleteOkBtn.Location = new Point(570, 387);
            DeleteOkBtn.Name = "DeleteOkBtn";
            DeleteOkBtn.Size = new Size(55, 41);
            DeleteOkBtn.TabIndex = 23;
            DeleteOkBtn.Text = "Ok";
            DeleteOkBtn.UseVisualStyleBackColor = false;
            DeleteOkBtn.Click += DeleteOkBtn_Click;
            // 
            // fTruongPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 516);
            Controls.Add(DeleteOkBtn);
            Controls.Add(AddOkBtn);
            Controls.Add(label4);
            Controls.Add(SubmitBtn);
            Controls.Add(label3);
            Controls.Add(thoigianTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(madaTb);
            Controls.Add(manvTb);
            Controls.Add(DeleteBtn);
            Controls.Add(AddBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(infoView);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(personalInfoBtn);
            Name = "fTruongPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTruongPhong";
            ((System.ComponentModel.ISupportInitialize)infoView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button personalInfoBtn;
        private Button button1;
        private Button button2;
        private DataGridView infoView;
        private Button UpdateBtn;
        private Button AddBtn;
        private Button DeleteBtn;
        private TextBox manvTb;
        private TextBox madaTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox thoigianTb;
        private Button SubmitBtn;
        private Label label4;
        private Button AddOkBtn;
        private Button DeleteOkBtn;
    }
}