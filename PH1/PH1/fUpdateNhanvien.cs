using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PH1
{
    public partial class fUpdateNhanvien : Form
    {
        public fUpdateNhanvien(string ngaysinh, string diachi, string sodt)
        {
            InitializeComponent();
            textBox_Diachi.Text = diachi;
            textBox_Sodt.Text = sodt;
            dateTimePicker_Ngaysinh.Value = DateTime.ParseExact(ngaysinh.Split()[0], "M/d/yyyy", null);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string nngaysinh = dateTimePicker_Ngaysinh.Text.Split(' ')[0].Replace('/', '-').ToString();
            string ndiachi = textBox_Diachi.Text.Trim().ToString();
            if (ndiachi == "")
            {
                MessageBox.Show("Please fill the address!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string nsodt = textBox_Sodt.Text.Trim().ToString();
            if (nsodt == "")
            {
                MessageBox.Show("Please fill the phone number!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string pattern = @"^[1-9]\d*$";
            bool isMatch = Regex.IsMatch(nsodt, pattern);
            if (!isMatch)
            {
                MessageBox.Show("The phone number is invalid!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = string.Format("UPDATE U_AD_QLNV.NHANVIEN SET NGAYSINH = to_date('{0}', 'MM-DD-YYYY'), DIACHI = N'{1}', SODT = '{2}'", nngaysinh, ndiachi, nsodt);

            try
            {
                DataProvider.Instance.ExcuteNonQuery(query);
                MessageBox.Show("Personal information was updated successfully!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch
            {
                MessageBox.Show("Updating information fail!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

    }
}
