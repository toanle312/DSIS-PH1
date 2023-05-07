using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1
{
    public partial class fSuaNhanvien : Form
    {
        public fSuaNhanvien()
        {
            InitializeComponent();
        }

        private void checkBox_Ngaysinh_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_Ngaysinh.CheckState == CheckState.Checked)
                textBox_Ngaysinh.ReadOnly = false;
            else
                textBox_Ngaysinh.ReadOnly = true;
        }

        private void CheckBox_Diachi_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_Diachi.CheckState == CheckState.Checked)
                textBox_Diachi.ReadOnly = false;
            else
                textBox_Diachi.ReadOnly = true;
        }

        private void checkBox_Sodt_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_Sodt.CheckState == CheckState.Checked)
                textBox_Sodt.ReadOnly = false;
            else
                textBox_Sodt.ReadOnly = true;
        }

        private void button_Capnhat_Click(object sender, EventArgs e)
        {
            string query = "UPDATE U_AD_QLNV.NHANVIEN SET ";

            if (checkBox_Ngaysinh.CheckState == CheckState.Checked)
            {
                string ngaysinh = textBox_Ngaysinh.Text.Trim().ToString();
                string month = "";
                if (ngaysinh.Substring(3, 2) == "01")
                    month = "JAN";
                else if (ngaysinh.Substring(3, 2) == "02")
                    month = "FEB";
                else if (ngaysinh.Substring(3, 2) == "03")
                    month = "MAR";
                else if (ngaysinh.Substring(3, 2) == "04")
                    month = "APR";
                else if (ngaysinh.Substring(3, 2) == "05")
                    month = "MAY";
                else if (ngaysinh.Substring(3, 2) == "06")
                    month = "JUN";
                else if (ngaysinh.Substring(3, 2) == "07")
                    month = "JUL";
                else if (ngaysinh.Substring(3, 2) == "08")
                    month = "AUG";
                else if (ngaysinh.Substring(3, 2) == "09")
                    month = "SEP";
                else if (ngaysinh.Substring(3, 2) == "10")
                    month = "OCT";
                else if (ngaysinh.Substring(3, 2) == "11")
                    month = "NOV";
                else if (ngaysinh.Substring(3, 2) == "12")
                    month = "DEC";
                query = query + "NGAYSINH = to_date('" + ngaysinh.Substring(0, 2) + "-" + month + "-" + ngaysinh.Substring(8, 2) + "', 'DD-MON-RR'), ";
            }

            if (checkBox_Diachi.CheckState == CheckState.Checked)
            {
                string diachi = textBox_Diachi.Text.Trim().ToString();
                query = query + "DIACHI = N'" + diachi + "', ";
            }

            if (checkBox_Sodt.CheckState == CheckState.Checked)
            {
                string sodt = textBox_Sodt.Text.Trim().ToString();
                query = query + "SODT = '" + sodt + "', ";
            }

            query = query.TrimEnd(' ', ',');

            try
            {
                DataProvider.Instance.ExcuteNonQuery(query);
                MessageBox.Show("Cập nhật thông tin thành công!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch
            {
                MessageBox.Show("Cập nhật thông tin không thành công!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

    }
}
