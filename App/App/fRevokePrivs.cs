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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace App
{
    public partial class fRevokePrivs : Form
    {
        public fRevokePrivs()
        {
            InitializeComponent();
        }
        private void Run_SP_RevokeRole_Priv()
        {
            string s_role_priv = role_priv.Text.ToString().Trim().ToUpper();
            string s_user_role = user_role.Text.ToString().Trim().ToUpper();

            if (!s_role_priv.Equals(s_user_role))
            {
                string query = "revoke " + s_role_priv + " from " + s_user_role;
                try
                {
                    DataProvider.Instance.ExcuteNonQuery(query);
                    MessageBox.Show("Revoke successfully!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Revoke fail!", "Masage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (role_priv.Text.Trim().Length == 0 | user_role.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please fill enough information!", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Run_SP_RevokeRole_Priv();
        }
    }
}
