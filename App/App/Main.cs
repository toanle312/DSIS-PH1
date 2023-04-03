using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace App
{
    public partial class Main : Form
    {
        public Main(string username)
        {
            InitializeComponent();
            username_label.Text = username;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void active_form(Form f)
        {
            control.Controls.Clear();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Height = 500;
            f.Width = 950;
            f.Dock = DockStyle.Fill;
            control.Controls.Add(f);
            control.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void user_list_btn_Click(object sender, EventArgs e)
        {
            var f = new fUsersList();
            active_form(f);
        }

        private void check_privs_btn_Click(object sender, EventArgs e)
        {
            var f = new fCheckPrivs();
            active_form(f);
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            var f = new fAddUser();
            active_form(f);
        }

        private void del_user_btn_Click(object sender, EventArgs e)
        {
            var f = new fDelUser();
            active_form(f);
        }

        private void edit_user_btn_Click(object sender, EventArgs e)
        {
            var f = new fEditUser();
            active_form(f);
        }

        private void add_role_btn_Click(object sender, EventArgs e)
        {
            var f = new fAddRole();
            active_form(f);

        }

        private void del_role_btn_Click(object sender, EventArgs e)
        {
            var f = new fDelRole();
            active_form(f);
        }

        private void grant_privs_btn_Click(object sender, EventArgs e)
        {
            var f = new fGrantPrivs();
            active_form(f);
        }

        private void grant_role_btn_Click(object sender, EventArgs e)
        {
            var f = new fGrantRole();
            active_form(f);
        }

        private void revoke_privs_btn_Click(object sender, EventArgs e)
        {
            var f = new fRevokePrivs();
            active_form(f);
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
