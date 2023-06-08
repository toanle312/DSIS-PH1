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
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            ngaysinh_textbox.Visible = false;
            sdt_textbox.Visible = false;
            diachi_textbox.Visible = false;

            username_label.Text = username;
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

            var data = DataProvider.Instance.ExcuteQuery(query);

            var decryptedTable = EmployeeServices.CreateDataTableFrom(data);

            foreach (DataRow row in data.Rows)
            {
                if (row["MANV"].ToString() == username_label.Text && row["VAITRO"].ToString() == rolename_label.Text)
                {
                    Encryption.DecryptEmployee(row, decryptedTable);
                }
                else
                {
                    decryptedTable.ImportRow(row);
                }
            }

            DataProvider.Instance.SortDataTable(decryptedTable, "MANV", SortOrder.Ascending);
            infoView.DataSource = decryptedTable;
        }

        private void employeeInfo_Click(object sender, EventArgs e)
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

        private void phancong_Click(object sender, EventArgs e)
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
            infoView.Size = new Size(400, 329);
            label5.Text = string.Empty;

            string query = "SELECT * from U_AD_QLNV.QUANLI_PHANCONG_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void editInfo_Click(object sender, EventArgs e)
        {
            string pattern = @"^[1-9]\d*$";
            bool isMatch = Regex.IsMatch(sdt_textbox.Text, pattern);
            if (!isMatch)
            {
                label5.Text = "Số điện thoại không hợp lệ, mời nhập lại!!";
            }
            else
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

                    MessageBox.Show("Chỉnh sửa thông tin thành công!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    personalInfoBtn_Click(sender, e);
                    ngaysinh_textbox.Text = string.Empty;
                    sdt_textbox.Text = string.Empty;
                    diachi_textbox.Text = string.Empty;
                }
            }
        }

        private void phongbanBtn_Click(object sender, EventArgs e)
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
            infoView.Size = new Size(400, 329);
            label5.Text = string.Empty;

            string query = "SELECT * from U_AD_QLNV.PHONGBAN";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void deanBtn_Click(object sender, EventArgs e)
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
            infoView.Size = new Size(400, 329);
            label5.Text = string.Empty;

            string query = @"SELECT * FROM U_AD_QLNV.DEAN";
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

    }
}
