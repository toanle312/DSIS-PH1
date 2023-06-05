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
    public partial class fUpdateDA : Form
    {
        private string mada = "";

        public fUpdateDA(string mada, string tenda, string ngaybd, string phong)
        {
            InitializeComponent();
            this.mada = mada;
            textBox_Mada.Text = mada;
            textBox_TenDA.Text = tenda;
            dateTimePicker_Ngaybd.Value = DateTime.ParseExact(ngaybd.Split()[0], "M/d/yyyy", null);

            string query = "SELECT MAPB FROM U_AD_QLNV.PHONGBAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            comboBox_Phong.DataSource = data;
            comboBox_Phong.DisplayMember = "MAPB";
            comboBox_Phong.ValueMember = "MAPB";
            comboBox_Phong.SelectedValue = phong;
        }

        private void button_Capnhat_Click(object sender, EventArgs e)
        {
            string ntenda = textBox_TenDA.Text.Trim().ToString();
            if (ntenda == "")
            {
                MessageBox.Show("Please fill the project name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string nngaybd = dateTimePicker_Ngaybd.Text.Split(' ')[0].Replace('/', '-').ToString();
            string nphong = comboBox_Phong.Text.Trim().ToString();

            string query = string.Format("UPDATE U_AD_QLNV.DEAN SET TENDA = N'{0}', NGAYBD = to_date('{1}', 'MM-DD-YYYY'), PHONG = '{2}' WHERE MADA = '{3}'", ntenda, nngaybd, nphong, mada);
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query);
                MessageBox.Show("The project information was updated successfully !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch
            {
                MessageBox.Show("Updating project information fail!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}