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
            ViewEmployeeButton = new Button();
            DataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // ViewEmployeeButton
            // 
            ViewEmployeeButton.Location = new Point(12, 12);
            ViewEmployeeButton.Name = "ViewEmployeeButton";
            ViewEmployeeButton.Size = new Size(150, 30);
            ViewEmployeeButton.TabIndex = 0;
            ViewEmployeeButton.Text = "Xem nhân viên";
            ViewEmployeeButton.UseVisualStyleBackColor = true;
            ViewEmployeeButton.Click += ViewEmployeeButton_OnClick;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 48);
            DataGridView.Name = "DataGridView";
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(776, 390);
            DataGridView.TabIndex = 1;
            // 
            // Cryptography
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView);
            Controls.Add(ViewEmployeeButton);
            Name = "Cryptography";
            Text = "Cryptography";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ViewEmployeeButton;
        private DataGridView DataGridView;
    }
}