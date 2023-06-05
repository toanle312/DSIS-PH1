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
        public fTruongDA()
        {
            InitializeComponent();
        }

        private void b_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login screen = new Login();
            screen.ShowDialog();
        }

        private void b_Nhanvien_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.NHANVIEN";
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void b_Phancong_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.PHANCONG";
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
            fSuaNhanvien screen = new fSuaNhanvien();
            screen.ShowDialog();
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

<<<<<<< Updated upstream
            if (MessageBox.Show("Bạn muốn xóa đề án này?", "Massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
=======
            if (MessageBox.Show("Do you want to delete this project?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
>>>>>>> Stashed changes
            {
                string query = "DELETE U_AD_QLNV.DEAN WHERE MADA = '" + mada + "'";
                try
                {
                    DataProvider.Instance.ExcuteNonQuery(query);
<<<<<<< Updated upstream
                    MessageBox.Show("Xóa đề án thành công!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa đề án không thành công!" + query, "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
=======
                    MessageBox.Show("The project was deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query_load = "SELECT * FROM U_AD_QLNV.DEAN";
                    dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query_load);
                }
                catch
                {
                    MessageBox.Show("Deleting project fail!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
>>>>>>> Stashed changes
                }
            }
        }

        private void cậpNhậtĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedRows[0].Index;
            string mada = dataGridView1.Rows[rowIndex].Cells["MADA"].Value.ToString();

            fSuaDA screen = new fSuaDA(mada);
            screen.ShowDialog();
        }

        private void b_ThemDean_Click(object sender, EventArgs e)
        {
            fThemDA screen = new fThemDA();
            screen.ShowDialog();
        }
    }
}