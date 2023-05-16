using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PH1.Program;

namespace PH1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
          
        }

        public class Role
        {
            public static int Admin = 0;
            public static int NhanVien = 1;
            public static int QLTrucTiep = 2;
            public static int TruongPhong = 3;
            public static int TaiChinh = 4;
            public static int NhanSu = 5;
            public static int TruongDA = 6;
            public static int GiamDoc = 7;

        }

        private int check_Login()
        {
            int result = 0;

            var data = DataProvider.Instance.ExcuteQuery("SELECT * FROM U_AD_QLNV.NHANVIEN_SESSION");

            foreach (DataRow row in data.Rows) 
            {
                string vaitro = (string)row["VAITRO"];
                if (vaitro == "Nhân viên")
                {
                    return Role.NhanVien;
                }
                else if (vaitro == "QL trực tiếp")
                {
                    return Role.QLTrucTiep;
                }
                else if (vaitro == "Trưởng phòng")
                {
                    return Role.TruongPhong;
                }
                else if (vaitro == "Tài chính")
                {
                    return Role.TaiChinh;
                }
                else if (vaitro == "Nhân sự")
                {
                    return Role.NhanSu;
                }
                else if (vaitro == "Trưởng đề án")
                {
                    return Role.TruongDA;
                }
                else if (vaitro == "Giám đốc")
                {
                    return Role.GiamDoc;
                }
            }

            return result;
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            
            var role = new Role();

            string checkLogin = DataProvider.Instance.ConnectDB(username, password);

            if (checkLogin == "Success")
            {
                var result = check_Login();

                if(result == Role.Admin)
                {
                    this.Hide();

                    Main screen = new Main(username);
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }  
                else if (result == Role.NhanVien)
                {
                    this.Hide();

                    fNhanVien screen = new fNhanVien(username, "Nhân viên");
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else if (result == Role.QLTrucTiep)
                {
                    this.Hide();

                    fQLTrucTiep screen = new fQLTrucTiep();
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else if (result == Role.TruongPhong)
                {
                    this.Hide();

                    fTruongPhong screen = new fTruongPhong();
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else if (result == Role.NhanSu)
                {
                    this.Hide();

                    fNhanSu screen = new fNhanSu();
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else if (result == Role.TaiChinh)
                {
                    this.Hide();

                    fTaiChinh screen = new fTaiChinh();
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else if (result == Role.TruongDA)
                {
                    this.Hide();

                    fTruongDA screen = new fTruongDA();
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else if (result == Role.GiamDoc)
                {
                    this.Hide();

                    fGiamDoc screen = new fGiamDoc();
                    screen.ShowDialog();

                    if (screen.DialogResult == DialogResult.Cancel)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }

            }
            else
            {
                MessageBox.Show(checkLogin, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}