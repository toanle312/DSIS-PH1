using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PH1
{
    public partial class fTruongPhong : Form
    {
        public fTruongPhong(string username)
        {
            InitializeComponent();
            manvTb.Visible = false;
            madaTb.Visible = false;
            thoigianTb.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            UpdateBtn.Visible = false;
            AddBtn.Visible = false;
            DeleteBtn.Visible = false;
            SubmitBtn.Visible = false;
            label4.Visible = false;
            AddOkBtn.Visible = false;
            DeleteOkBtn.Visible = false;

            username_label.Text = username;

            infoView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            infoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void personalInfoBtn_Click(object sender, EventArgs e)
        {
            manvTb.Visible = false;
            madaTb.Visible = false;
            thoigianTb.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            UpdateBtn.Visible = false;
            AddBtn.Visible = false;
            DeleteBtn.Visible = false;
            SubmitBtn.Visible = false;
            label4.Visible = false;



            SubmitBtn.Visible = false;
            AddOkBtn.Visible = false;
            DeleteOkBtn.Visible = false;
            infoView.Size = new Size(960, 100);
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

        private void employeeInfoBtn_Click(object sender, EventArgs e)
        {

            manvTb.Visible = false;
            madaTb.Visible = false;
            thoigianTb.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            UpdateBtn.Visible = false;
            AddBtn.Visible = false;
            DeleteBtn.Visible = false;
            SubmitBtn.Visible = false;
            label4.Visible = false;



            SubmitBtn.Visible = false;
            AddOkBtn.Visible = false;
            DeleteOkBtn.Visible = false;
            infoView.Size = new Size(997, 456);

            string query = "SELECT * from U_AD_QLNV.TRUONGPHONG_THONGTIN_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void phancongbtn_Click(object sender, EventArgs e)
        {
            UpdateBtn.Visible = true;
            AddBtn.Visible = true;
            DeleteBtn.Visible = true;
            label4.Text = "";


            infoView.Size = new Size(400, 329);

            string query = "SELECT * from U_AD_QLNV.TRUONGPHONG_PHANCONG_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            manvTb.Visible = true;
            madaTb.Visible = true;
            label3.Visible = true;
            thoigianTb.Visible = true;
            label4.Visible = true;
            SubmitBtn.Visible = true;
            AddOkBtn.Visible = false;
            DeleteOkBtn.Visible = false;
            label4.Text = "";
            label3.Text = "Thời gian mới";

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label1.Visible = true;
            label2.Visible = true;
            manvTb.Visible = true;
            madaTb.Visible = true;
            label3.Visible = true;
            thoigianTb.Visible = true;
            label4.Visible = true;

            SubmitBtn.Visible = false;
            AddOkBtn.Visible = true;
            DeleteOkBtn.Visible = false;
            label3.Text = "Thời gian";

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label1.Visible = true;
            label2.Visible = true;
            manvTb.Visible = true;
            madaTb.Visible = true;
            label3.Visible = false;
            thoigianTb.Visible = false;
            label4.Visible = true;

            SubmitBtn.Visible = false;
            AddOkBtn.Visible = false;
            DeleteOkBtn.Visible = true;

        }

        private void UpdateOKBtn(object sender, EventArgs e)
        {
            string MANV = manvTb.Text;
            string MADA = madaTb.Text;
            string THOIGIAN = thoigianTb.Text;

            if (MANV == "" || MADA == "" || THOIGIAN == "")
            {
                label4.Text = "Xin hãy điền đầy đủ!!";
            }

            string pattern = @"^[^\s]+$";
            bool isMatch = Regex.IsMatch(MANV, pattern);
            bool isMatch1 = Regex.IsMatch(MADA, pattern);
            bool isMatch2 = Regex.IsMatch(THOIGIAN, pattern);

            //neu password hoac username co khoang trang thi nhap lai
            if (!isMatch || !isMatch1 || !isMatch2)
            {
                label4.Text = "MANV or MADA or THOIGIAN is invalid!!";
            }
            else
            {
                OracleConnection conn = DataProvider.Instance.getConn();
                conn.Open();

                string functionName = "CHECK_PHANCONG_EXIST";
                OracleCommand cmd = new OracleCommand(functionName, conn);

                cmd.CommandText = $"SELECT U_AD_QLNV.{functionName}(:parameter1, :parameter2) FROM DUAL";
                cmd.Parameters.Add("parameter1", OracleDbType.Varchar2).Value = MANV;
                cmd.Parameters.Add("parameter2", OracleDbType.Varchar2).Value = MADA;


                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result == 0)
                {
                    MessageBox.Show("Phân công không tồn tại!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    functionName = "U_AD_QLNV.UPDATE_PHANCONG";

                    cmd = new OracleCommand(functionName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("MANV_IN", OracleDbType.Varchar2).Value = MANV;
                    cmd.Parameters.Add("MADA_IN", OracleDbType.Varchar2).Value = MADA;
                    cmd.Parameters.Add("THOIGIAN_IN", OracleDbType.Varchar2).Value = THOIGIAN;


                    cmd.ExecuteNonQuery();

                    //Cập nhật lại bảng phân công
                    //string query = "SELECT * from U_AD_QLNV.TRUONGPHONG_PHANCONG_VIEW";
                    //infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);

                    MessageBox.Show("Cập nhật thành công!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                manvTb.Text = "";
                madaTb.Text = "";
                thoigianTb.Text = "";
                conn.Close();
            }
            phancongbtn_Click(sender, e);
        }

        private void AddOkBtn_Click(object sender, EventArgs e)
        {
            string MANV = manvTb.Text;
            string MADA = madaTb.Text;
            string THOIGIAN = thoigianTb.Text;

            if (MANV == "" || MADA == "" || THOIGIAN == "")
            {
                label4.Text = "Xin hãy điền đầy đủ!!";
            }

            string pattern = @"^[^\s]+$";
            bool isMatch = Regex.IsMatch(MANV, pattern);
            bool isMatch1 = Regex.IsMatch(MADA, pattern);
            bool isMatch2 = Regex.IsMatch(THOIGIAN, pattern);

            //neu password hoac username co khoang trang thi nhap lai
            if (!isMatch || !isMatch1 || !isMatch2)
            {
                label4.Text = "MANV or MADA or THOIGIAN is invalid!!";
            }
            else
            {
                OracleConnection conn = DataProvider.Instance.getConn();
                conn.Open();

                string functionName = "CHECK_INSERT_PC_VALID";
                OracleCommand cmd = new OracleCommand(functionName, conn);

                cmd.CommandText = $"SELECT U_AD_QLNV.{functionName}(:parameter1) FROM DUAL";
                cmd.Parameters.Add("parameter1", OracleDbType.Varchar2).Value = MANV;


                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result == 0)
                {
                    label4.Text = $"Nhân viên này không thuộc phòng ban của bạn!!";
                }
                else
                {
                    functionName = "U_AD_QLNV.INSERT_PHANCONG";

                    cmd = new OracleCommand(functionName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("MANV_IN", OracleDbType.Varchar2).Value = MANV;
                    cmd.Parameters.Add("MADA_IN", OracleDbType.Varchar2).Value = MADA;
                    cmd.Parameters.Add("THOIGIAN_IN", OracleDbType.Varchar2).Value = THOIGIAN;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                manvTb.Text = "";
                madaTb.Text = "";
                thoigianTb.Text = "";
                conn.Close();
            }
            phancongbtn_Click(sender, e);
        }

        private void DeleteOkBtn_Click(object sender, EventArgs e)
        {
            string MANV = manvTb.Text;
            string MADA = madaTb.Text;

            if (MANV == "" || MADA == "")
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Xin hãy điền đầy đủ!!";
            }

            string pattern = @"^[^\s]+$";
            bool isMatch = Regex.IsMatch(MANV, pattern);
            bool isMatch1 = Regex.IsMatch(MADA, pattern);

            //neu password hoac username co khoang trang thi nhap lai
            if (!isMatch || !isMatch1)
            {
                label4.Text = "MANV or MADA is invalid!!";
            }
            else
            {
                OracleConnection conn = DataProvider.Instance.getConn();
                conn.Open();

                string functionName = "CHECK_PHANCONG_EXIST";
                OracleCommand cmd = new OracleCommand(functionName, conn);

                cmd.CommandText = $"SELECT U_AD_QLNV.{functionName}(:parameter1, :parameter2) FROM DUAL";
                cmd.Parameters.Add("parameter1", OracleDbType.Varchar2).Value = MANV;
                cmd.Parameters.Add("parameter2", OracleDbType.Varchar2).Value = MADA;



                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result == 0)
                {
                    MessageBox.Show("Phân công không tồn tại!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    functionName = "U_AD_QLNV.DELETE_PHANCONG";

                    cmd = new OracleCommand(functionName, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("MANV_IN", OracleDbType.Varchar2).Value = MANV;
                    cmd.Parameters.Add("MADA_IN", OracleDbType.Varchar2).Value = MADA;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa phân công thành công!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                manvTb.Text = "";
                madaTb.Text = "";
                thoigianTb.Text = "";
                conn.Close();
            }
            phancongbtn_Click(sender, e);
        }

        //private void edtiInfoBtn_Click(object sender, EventArgs e)
        //{
        //    string pattern = @"^[1-9]\d*$";
        //    bool isMatch = Regex.IsMatch(sdt_textbox.Text, pattern);
        //    if (!isMatch)
        //    {
        //        Noti_label.Text = "Số điện thoại không hợp lệ, mời nhập lại!!";
        //    }
        //    else
        //    {
        //        if (ngaysinh_textbox.Text == String.Empty || diachi_textbox.Text == String.Empty || sdt_textbox.Text == String.Empty)
        //        {
        //            Noti_label.Text = "Hãy điền đầy đủ thông tin!!";
        //        }
        //        else
        //        {
        //            var date = ngaysinh_textbox.Text;
        //            var dob = date.Split(' ')[0];
        //            dob = dob.Replace('/', '-');

        //            string query = @"BEGIN
        //                            UPDATE 
        //                                U_AD_QLNV.NHANVIEN 
        //                             SET
        //                                DIACHI = '{0}', 
        //                                SODT = '{1}',
        //                                NGAYSINH = TO_DATE('{2}','MM-DD-YYYY')
        //                             WHERE MANV = SYS_CONTEXT('USERENV', 'SESSION_USER');
        //                             COMMIT;
        //                         END;";

        //            query = String.Format(query, diachi_textbox.Text, sdt_textbox.Text, dob.ToString());
        //            DataProvider.Instance.ExcuteNonQuery(query);

        //            ngaysinh_textbox.Text = string.Empty;
        //            sdt_textbox.Text = string.Empty;
        //            diachi_textbox.Text = string.Empty;

        //            MessageBox.Show("Chỉnh sửa thông tin thành công!!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            personalInfoBtn_Click(sender, e);
        //        }
        //    }
        //}

        private void phongbanBtn_Click(object sender, EventArgs e)
        {
            manvTb.Visible = false;
            madaTb.Visible = false;
            thoigianTb.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            UpdateBtn.Visible = false;
            AddBtn.Visible = false;
            DeleteBtn.Visible = false;
            SubmitBtn.Visible = false;
            label4.Visible = false;

            SubmitBtn.Visible = false;
            AddOkBtn.Visible = false;
            DeleteOkBtn.Visible = false;

            infoView.Size = new Size(400, 329);

            string query = "SELECT * from U_AD_QLNV.PHONGBAN";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void deanBtn_Click(object sender, EventArgs e)
        {

            manvTb.Visible = false;
            madaTb.Visible = false;
            thoigianTb.Visible = false;
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            UpdateBtn.Visible = false;
            AddBtn.Visible = false;
            DeleteBtn.Visible = false;
            SubmitBtn.Visible = false;
            label4.Visible = false;

            SubmitBtn.Visible = false;
            AddOkBtn.Visible = false;
            DeleteOkBtn.Visible = false;

            infoView.Size = new Size(400, 329);

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

        private void infoView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void manvTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void madaTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void thoigianTb_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void EmployeeInterfaceButton_Click(object sender, EventArgs e)
        {
            Hide();

            var screen = new fNhanVien(username_label.Text, "Trưởng phòng");
            var result = screen.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                var newScreen = new fTruongPhong(username_label.Text);
                DialogResult = newScreen.ShowDialog();
            }
            else
            {
                DialogResult = DialogResult.OK;

            }
        }
    }
}
