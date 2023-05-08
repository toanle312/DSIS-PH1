using System.Windows.Forms;

namespace PH1
{
    partial class fQLTrucTiep
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
            infoView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)infoView).BeginInit();
            SuspendLayout();
            // 
            // personalInfoBtn
            // 
            personalInfoBtn.BackColor = SystemColors.ActiveCaption;
            personalInfoBtn.Cursor = Cursors.Hand;
            personalInfoBtn.Location = new Point(12, 24);
            personalInfoBtn.Name = "personalInfoBtn";
            personalInfoBtn.Size = new Size(121, 41);
            personalInfoBtn.TabIndex = 5;
            personalInfoBtn.Text = "Personal info";
            personalInfoBtn.UseVisualStyleBackColor = false;
            personalInfoBtn.Click += personalInfoBtn_Click;
            // 
            // infoView
            // 
            infoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoView.Location = new Point(12, 88);
            infoView.Name = "infoView";
            infoView.RowHeadersWidth = 51;
            infoView.RowTemplate.Height = 29;
            infoView.Size = new Size(960, 329);
            infoView.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(151, 24);
            button1.Name = "button1";
            button1.Size = new Size(121, 41);
            button1.TabIndex = 7;
            button1.Text = "Employee info";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(296, 24);
            button2.Name = "button2";
            button2.Size = new Size(121, 41);
            button2.TabIndex = 8;
            button2.Text = "Phân công";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // fQLTrucTiep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 493);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(infoView);
            Controls.Add(personalInfoBtn);
            Name = "fQLTrucTiep";
            Text = "fQLTrucTiep";
            ((System.ComponentModel.ISupportInitialize)infoView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button personalInfoBtn;
        private DataGridView infoView;
        private Button button1;
        private Button button2;
    }
}