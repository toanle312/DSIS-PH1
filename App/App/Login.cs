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
using static App.Program;

namespace App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            username_textbox.Text = "U_AD";
            password_textbox.Text = "123";
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            //string username = username_textbox.Text;
            //string password = password_textbox.Text;

            // Tạm thời bỏ qua quá trình login
            string username = "QLYTE";
            string password = "123";

            string checkLogin = DataProvider.Instance.ConnectDB(username, password);

            if (checkLogin == "Success")
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