namespace PH1
{
    partial class fUpdateNhanvien
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
            textBox_Sodt = new TextBox();
            textBox_Diachi = new TextBox();
            label2 = new Label();
            update_btn = new Button();
            dateTimePicker_Ngaysinh = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox_Sodt
            // 
            textBox_Sodt.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Sodt.Location = new Point(171, 228);
            textBox_Sodt.Name = "textBox_Sodt";
            textBox_Sodt.Size = new Size(315, 27);
            textBox_Sodt.TabIndex = 37;
            // 
            // textBox_Diachi
            // 
            textBox_Diachi.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Diachi.Location = new Point(171, 165);
            textBox_Diachi.Name = "textBox_Diachi";
            textBox_Diachi.Size = new Size(315, 27);
            textBox_Diachi.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(145, 44);
            label2.Name = "label2";
            label2.Size = new Size(252, 25);
            label2.TabIndex = 34;
            label2.Text = "PERSONAL INFORMATION ";
            // 
            // update_btn
            // 
            update_btn.BackColor = SystemColors.ActiveCaption;
            update_btn.Cursor = Cursors.Hand;
            update_btn.Location = new Point(200, 292);
            update_btn.Margin = new Padding(3, 2, 3, 2);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(115, 36);
            update_btn.TabIndex = 42;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // dateTimePicker_Ngaysinh
            // 
            dateTimePicker_Ngaysinh.CalendarFont = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Ngaysinh.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker_Ngaysinh.Location = new Point(171, 104);
            dateTimePicker_Ngaysinh.Name = "dateTimePicker_Ngaysinh";
            dateTimePicker_Ngaysinh.Size = new Size(315, 27);
            dateTimePicker_Ngaysinh.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 109);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 44;
            label1.Text = "Date of birth ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 168);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 45;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(31, 231);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 46;
            label4.Text = "Phone number";
            // 
            // fUpdateNhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 369);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker_Ngaysinh);
            Controls.Add(update_btn);
            Controls.Add(textBox_Sodt);
            Controls.Add(textBox_Diachi);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fUpdateNhanvien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "fUpdateNhanvien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_Sodt;
        private TextBox textBox_Diachi;
        private Label label2;
        private Button update_btn;
        private DateTimePicker dateTimePicker_Ngaysinh;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}