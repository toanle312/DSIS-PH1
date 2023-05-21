using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PH1
{
    public partial class fTruongDA : Form
    {
        public fTruongDA(string username, string rolename)
        {
            InitializeComponent();
            username_label.Text = username;
            rolename_label.Text = rolename;
        }

        private void b_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login screen = new Login();
            screen.ShowDialog();
        }

        private void b_Nhanvien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.NHANVIEN_SESSION";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void b_Phancong_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.PHANCONG_SESSION";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void b_Phongban_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.PHONGBAN";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void b_Dean_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.DEAN";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void b_Nhanvien2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.NHANVIEN_SESSION";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);

            string ngaysinh = dataGridView1.Rows[0].Cells["NGAYSINH"].Value.ToString();
            string diachi = dataGridView1.Rows[0].Cells["DIACHI"].Value.ToString();
            string sodt = dataGridView1.Rows[0].Cells["SODT"].Value.ToString();

            fUpdateNhanvien screen = new fUpdateNhanvien(ngaysinh, diachi, sodt);
            screen.ShowDialog();

            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }

        private void xóaĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            string mada = dataGridView1.Rows[rowIndex].Cells["MADA"].Value.ToString();

            if (MessageBox.Show("Do you want to delete this project?", "Massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE U_AD_QLNV.DEAN WHERE MADA = '" + mada + "'";
                try
                {
                    DataProvider.Instance.ExcuteNonQuery(query);
                    MessageBox.Show("The project was deleted successfully!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query_load = "SELECT * FROM U_AD_QLNV.DEAN";
                    dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query_load);
                }
                catch
                {
                    MessageBox.Show("Deleting project fail!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cậpNhậtĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            string mada = dataGridView1.Rows[rowIndex].Cells["MADA"].Value.ToString();
            string tenda = dataGridView1.Rows[rowIndex].Cells["TENDA"].Value.ToString();
            string ngaybd = dataGridView1.Rows[rowIndex].Cells["NGAYBD"].Value.ToString();
            string phong = dataGridView1.Rows[rowIndex].Cells["PHONG"].Value.ToString();

            fUpdateDA screen = new fUpdateDA(mada, tenda, ngaybd, phong);
            screen.ShowDialog();

            string query = "SELECT * FROM U_AD_QLNV.DEAN";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void b_ThemDean_Click(object sender, EventArgs e)
        {
            fAddDA screen = new fAddDA();
            screen.ShowDialog();

            string query = "SELECT * FROM U_AD_QLNV.DEAN";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

    }
}
