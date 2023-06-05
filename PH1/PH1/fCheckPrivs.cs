using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PH1
{
    public partial class fCheckPrivs : Form
    {
        public fCheckPrivs()
        {
            InitializeComponent();
        }

        private void c_table_priv_Click(object sender, EventArgs e)
        {
            if (name_init.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill a user name or a role name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = name_init.Text.Trim().ToString().ToUpper();
            string query = "";
            if (name[0] == 'R') // Ten role bat dau bang "R"
                query = "SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE = '" + name + "'";
            else if (name != "")
                query = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + name + "'";
            table_priv_view.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void c_column_priv_Click(object sender, EventArgs e)
        {
            if (name_init.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill a user name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = name_init.Text.Trim().ToString().ToUpper();
            string query = "";
            if (name != "")
                query = "SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE = '" + name + "'";
            table_priv_view.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void c_sys_priv_Click(object sender, EventArgs e)
        {
            if (name_init.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill a user name or a role name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = name_init.Text.Trim().ToString().ToUpper();
            string query = "";
            if (name[0] == 'R') // Ten role bat dau bang "R"
                query = "SELECT * FROM ROLE_SYS_PRIVS WHERE ROLE = '" + name + "'";
            else if (name != "")
                query = "SELECT * FROM dba_sys_privs WHERE GRANTEE = '" + name + "'";
            table_priv_view.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void c_role_user_Click(object sender, EventArgs e)
        {
            if (name_init.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill a user name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string name = name_init.Text.Trim().ToString().ToUpper();
            string query = "";
            if (name != "")
                query = "SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '" + name + "'";
            table_priv_view.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}