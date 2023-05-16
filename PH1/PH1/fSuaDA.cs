using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH1
{
    public partial class fSuaDA : Form
    {
        private string mada = "";
        public fSuaDA(string mada)
        {
            InitializeComponent();
            this.mada = mada;
            textBox_Mada.Text = mada;

            string query = "SELECT MAPB FROM U_AD_QLNV.PHONGBAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            comboBox_Phong.DataSource = data;
            comboBox_Phong.DisplayMember = "MAPB";
            comboBox_Phong.ValueMember = "MAPB";
        }

        private void checkBox_TenDA_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_TenDA.CheckState == CheckState.Checked)
                textBox_TenDA.ReadOnly = false;
            else
                textBox_TenDA.ReadOnly = true;
        }

        private void checkBox_NgayBD_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_NgayBD.CheckState == CheckState.Checked)
                textBox_NgayBD.ReadOnly = false;
            else
                textBox_NgayBD.ReadOnly = true;
        }

        private void checkBox_Phong_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox_Phong.CheckState == CheckState.Checked)
                comboBox_Phong.Enabled = true;
            else
                comboBox_Phong.Enabled = false;
        }

        private void button_Capnhat_Click(object sender, EventArgs e)
        {
            string query = "UPDATE U_AD_QLNV.DEAN SET ";

            if (checkBox_TenDA.CheckState == CheckState.Checked)
            {
                string tenda = textBox_TenDA.Text.Trim().ToString();
                if (tenda == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đề án!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                query = query + "TENDA = N'" + tenda + "', ";
            }

            if (checkBox_NgayBD.CheckState == CheckState.Checked)
            {
                string ngaybd = textBox_NgayBD.Text.Trim().ToString();
                string month = "";
                if (ngaybd.Substring(3, 2) == "01")
                    month = "JAN";
                else if (ngaybd.Substring(3, 2) == "02")
                    month = "FEB";
                else if (ngaybd.Substring(3, 2) == "03")
                    month = "MAR";
                else if (ngaybd.Substring(3, 2) == "04")
                    month = "APR";
                else if (ngaybd.Substring(3, 2) == "05")
                    month = "MAY";
                else if (ngaybd.Substring(3, 2) == "06")
                    month = "JUN";
                else if (ngaybd.Substring(3, 2) == "07")
                    month = "JUL";
                else if (ngaybd.Substring(3, 2) == "08")
                    month = "AUG";
                else if (ngaybd.Substring(3, 2) == "09")
                    month = "SEP";
                else if (ngaybd.Substring(3, 2) == "10")
                    month = "OCT";
                else if (ngaybd.Substring(3, 2) == "11")
                    month = "NOV";
                else if (ngaybd.Substring(3, 2) == "12")
                    month = "DEC";
                query = query + "NGAYBD = to_date('" + ngaybd.Substring(0, 2) + "-" + month + "-" + ngaybd.Substring(8, 2) + "', 'DD-MON-RR'), ";
            }

            if (checkBox_Phong.CheckState == CheckState.Checked)
            {
                string phong = comboBox_Phong.Text.Trim().ToString();
                query = query + "PHONG = '" + phong + "', ";
            }

            query = query.TrimEnd(' ', ',');
            query = query + "WHERE MADA = '" + mada + "'";

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
