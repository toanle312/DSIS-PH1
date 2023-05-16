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
    public partial class fThemDA : Form
    {
        public fThemDA()
        {
            InitializeComponent();
            string query = "SELECT MAPB FROM U_AD_QLNV.PHONGBAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            comboBox_Phong.DataSource = data;
            comboBox_Phong.DisplayMember = "MAPB";
            comboBox_Phong.ValueMember = "MAPB";
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            string query = "Insert into U_AD_QLNV.DEAN (MADA,TENDA,NGAYBD,PHONG) values ('";

            string mada = textBox_Mada.Text.Trim().ToString();
            if (mada == "")
            {
                MessageBox.Show("Vui lòng nhập mã đề án!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            query = query + mada + "', N'";

            string tenda = textBox_TenDA.Text.Trim().ToString();
            if (tenda == "")
            {
                MessageBox.Show("Vui lòng nhập tên đề án!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            query = query + tenda + "', ";

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
            query = query + "to_date('" + ngaybd.Substring(0, 2) + "-" + month + "-" + ngaybd.Substring(8, 2) + "', 'DD-MON-RR'), '";


            string phong = comboBox_Phong.Text.Trim().ToString();
            query = query + phong + "')";

            try
            {
                DataProvider.Instance.ExcuteNonQuery(query);
                MessageBox.Show("Thêm đề án thành công!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch
            {
                MessageBox.Show("Thêm đề án không thành công!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
