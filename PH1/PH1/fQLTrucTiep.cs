using Microsoft.VisualBasic;
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
    public partial class fQLTrucTiep : Form
    {
        public fQLTrucTiep()
        {
            InitializeComponent();
            infoView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            infoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            ngaysinh_textbox.Visible = false;
            sdt_textbox.Visible = false;
            diachi_textbox.Visible = false;
        }

        private void personalInfoBtn_Click(object sender, EventArgs e)
        {
            infoView.Size = new Size(960, 100);
            button3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            ngaysinh_textbox.Visible = true;
            sdt_textbox.Visible = true;
            diachi_textbox.Visible = true;
            label5.Text = string.Empty;

            string query = "SELECT * from U_AD_QLNV.NHANVIEN_SESSION";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            ngaysinh_textbox.Visible = false;
            sdt_textbox.Visible = false;
            diachi_textbox.Visible = false;
            infoView.Size = new Size(960, 329);
            label5.Text = string.Empty;

            string query = "SELECT * from U_AD_QLNV.QUANLI_THONGTIN_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            ngaysinh_textbox.Visible = false;
            sdt_textbox.Visible = false;
            diachi_textbox.Visible = false;
            infoView.Size = new Size(330, 329);
            label5.Text = string.Empty;

            string query = "SELECT * from U_AD_QLNV.QUANLI_PHANCONG_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ngaysinh_textbox.Text == String.Empty || diachi_textbox.Text == String.Empty || sdt_textbox.Text == String.Empty)
            {
                label5.Text = "Hãy điền đầy đủ thông tin!!";
            }
            else
            {
                var date = ngaysinh_textbox.Text;
                var dob = date.Split(' ')[0];
                dob = dob.Replace('/', '-');

                string query = @"BEGIN
                                    UPDATE 
                                        U_AD_QLNV.NHANVIEN 
                                     SET
                                        DIACHI = '{0}', 
                                        SODT = '{1}',
                                        NGAYSINH = TO_DATE('{2}','MM-DD-YYYY')
                                     WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
                                     COMMIT;
                                 END;";

                query = String.Format(query, diachi_textbox.Text, sdt_textbox.Text, dob.ToString());
                DataProvider.Instance.ExcuteNonQuery(query);

                personalInfoBtn_Click(sender,e);

                ngaysinh_textbox.Text = string.Empty;
                sdt_textbox.Text = string.Empty;
                diachi_textbox.Text = string.Empty;
            }
        }
    }
}
