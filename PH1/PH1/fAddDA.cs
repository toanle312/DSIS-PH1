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
    public partial class fAddDA : Form
    {
        public fAddDA()
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
            string mada = textBox_Mada.Text.Trim().ToString();
            if (mada == "")
            {
                MessageBox.Show("Please fill the project ID!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string tenda = textBox_TenDA.Text.Trim().ToString();
            if (tenda == "")
            {
                MessageBox.Show("Please fill the project name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ngaybd = dateTimePicker_Ngaybd.Text.Split(' ')[0].Replace('/', '-').ToString();
            string phong = comboBox_Phong.Text.Trim().ToString();
            string query = string.Format("Insert into U_AD_QLNV.DEAN (MADA,TENDA,NGAYBD,PHONG) values ('{0}', N'{1}', to_date('{2}', 'MM-DD-YYYY'), '{3}')", mada, tenda, ngaybd, phong);

            try
            {
                DataProvider.Instance.ExcuteNonQuery(query);
                MessageBox.Show("The new project was added successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch
            {
                MessageBox.Show("Adding project fail!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
