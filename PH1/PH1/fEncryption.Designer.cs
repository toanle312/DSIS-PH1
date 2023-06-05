namespace PH1
{
    partial class fEncryption
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
            EncryptButton = new Button();
            DataGridView = new DataGridView();
            DecryptButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // EncryptButton
            // 
            EncryptButton.Location = new Point(12, 12);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(150, 30);
            EncryptButton.TabIndex = 0;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_OnClick;
            // 
            // DataGridView
            // 
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 48);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(776, 390);
            DataGridView.TabIndex = 1;
            // 
            // DecryptButton
            // 
            DecryptButton.Location = new Point(168, 12);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(150, 30);
            DecryptButton.TabIndex = 2;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // fEncryption
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DecryptButton);
            Controls.Add(DataGridView);
            Controls.Add(EncryptButton);
            Name = "fEncryption";
            Text = "Cryptography";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button EncryptButton;
        private DataGridView DataGridView;
        private Button DecryptButton;
    }
}