using Oracle.ManagedDataAccess.Client;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PH1
{
    public partial class fTruongPhong : Form
    {
        public fTruongPhong()
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
            infoView.Size = new Size(960, 100);

            string query = "SELECT * from U_AD_QLNV.NHANVIEN_SESSION";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
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

            infoView.Size = new Size(960, 329);

            string query = "SELECT * from U_AD_QLNV.TRUONGPHONG_THONGTIN_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from U_AD_QLNV.TRUONGPHONG_PHANCONG_VIEW";
            infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);
            UpdateBtn.Visible = true;
            AddBtn.Visible = true;
            DeleteBtn.Visible = true;
            label4.Text = "";
            infoView.Size = new Size(400, 329);
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

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string MANV = manvTb.Text;
            string MADA = madaTb.Text;
            string THOIGIAN = thoigianTb.Text;

            if (MANV == "" || MADA == "" || THOIGIAN == "")
            {
                label4.ForeColor = Color.Red;
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
                    label4.Text = $"Phân công không tồn tại!!";
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


                    label4.Text = $"Cập nhật thành công!!";
                }
                manvTb.Text = "";
                madaTb.Text = "";
                thoigianTb.Text = "";
                conn.Close();
            }
        }

        private void AddOkBtn_Click(object sender, EventArgs e)
        {
            string MANV = manvTb.Text;
            string MADA = madaTb.Text;
            string THOIGIAN = thoigianTb.Text;

            if (MANV == "" || MADA == "" || THOIGIAN == "")
            {
                label4.ForeColor = Color.Red;
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

                    //Cập nhật lại bảng phân công
                    //string query = "SELECT * from U_AD_QLNV.TRUONGPHONG_PHANCONG_VIEW";
                    //infoView.DataSource = DataProvider.Instance.ExcuteQuery(query);


                    label4.Text = $"Thêm vào thành công!!";
                }
                manvTb.Text = "";
                madaTb.Text = "";
                thoigianTb.Text = "";
                conn.Close();
            }
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
                    label4.Text = $"Phân công không tồn tại!!";
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


                    label4.Text = $"Đã xóa thành công!!";
                }
                manvTb.Text = "";
                madaTb.Text = "";
                thoigianTb.Text = "";
                conn.Close();
            }
        }
    }
}
