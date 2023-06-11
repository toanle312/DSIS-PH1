using Microsoft.VisualBasic;
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
    public partial class fQLTrucTiep : Form
    {
        public fQLTrucTiep(string username)
        {
            InitializeComponent();
            infoView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            infoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            username_label.Text = username;
        }


        private void employeeInfo_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from U_AD_QLNV.QUANLI_THONGTIN_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void phancong_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from U_AD_QLNV.QUANLI_PHANCONG_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }


        private void log_out_btn_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.DisconnectDB();
            DialogResult = DialogResult.OK;
            this.Close();
            Login f = new Login();
            f.Show();
        }

        private void EmployeeInterfaceButton_Click(object sender, EventArgs e)
        {
            Hide();

            var screen = new fNhanVien(username_label.Text, "QL trực tiếp");
            var result = screen.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                var newScreen = new fQLTrucTiep(username_label.Text);
                DialogResult = newScreen.ShowDialog();
            }
            else
            {
                DialogResult = DialogResult.OK;

            }
        }
    }
}
