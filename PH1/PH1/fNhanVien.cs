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
    public partial class fNhanVien : Form
    {
        private bool isHideUpdate = true;
        public fNhanVien(string username, string rolename)
        {
            InitializeComponent();
            hideUpdate();
            feature_label.Text = "";
            username_label.Text = username;
            rolename_label.Text = rolename;
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.DisconnectDB();
            DialogResult = DialogResult.OK;
            this.Close();
            Login f = new Login();
            f.Show();
        }

        private void nhanvien_btn_Click(object sender, EventArgs e)
        {
            user_list_view.DataSource = null;
            feature_label.Text = "Thông tin nhân viên";
            string query = @"SELECT * FROM U_AD_QLNV.NHANVIEN_SESSION";
            var data = DataProvider.Instance.ExcuteQuery(query);
            user_list_view.DataSource = data;
        }

        private void phancong_btn_Click(object sender, EventArgs e)
        {
            feature_label.Text = "Thông tin phân công của nhân viên";
            string query = @"SELECT * FROM U_AD_QLNV.PHANCONG_SESSION";
            var data = DataProvider.Instance.ExcuteQuery(query);
            user_list_view.DataSource = data;
        }

        private void da_btn_Click(object sender, EventArgs e)
        {

            feature_label.Text = "Thông tin đề án";
            string query = @"SELECT * FROM U_AD_QLNV.DEAN";
            var data = DataProvider.Instance.ExcuteQuery(query);
            user_list_view.DataSource = data;
        }

        private void pb_btn_Click(object sender, EventArgs e)
        {
            feature_label.Text = "Thông tin phòng ban";
            string query = @"SELECT * FROM U_AD_QLNV.PHONGBAN";
            var data = DataProvider.Instance.ExcuteQuery(query);
            user_list_view.DataSource = data;
        }

        private void hideUpdate()
        {
            ngaysinh_label.Hide();
            ngaysinh_textbox.Hide();
            diachi_label.Hide();
            diachi_textbox.Hide();
            sdt_label.Hide();
            sdt_textbox.Hide();
            update_btn.Hide();
            isHideUpdate = true;
        }

        private void showUpdate()
        {
            ngaysinh_textbox.Text = String.Empty;
            diachi_textbox.Text = String.Empty;
            sdt_textbox.Text = String.Empty;
            ngaysinh_label.Show();
            ngaysinh_textbox.Show();
            diachi_label.Show();
            diachi_textbox.Show();
            sdt_label.Show();
            sdt_textbox.Show();
            update_btn.Show();
            isHideUpdate = false;
        }

        private void update_infor_btn_Click(object sender, EventArgs e)
        {
            if (isHideUpdate)
            {
                showUpdate();
            }
            else
            {
                hideUpdate();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (ngaysinh_textbox.Text == String.Empty || diachi_textbox.Text == String.Empty || sdt_textbox.Text == String.Empty)
            {
                MessageBox.Show("Data is not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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


                MessageBox.Show("Update success", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nhanvien_btn_Click(sender, e);
            }
        }
    }
}
