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
    public partial class fUsersList : Form
    {
        public fUsersList()
        {
            InitializeComponent();
            string query = "SELECT username, user_id, account_status, created FROM DBA_USERS where account_status = 'OPEN' ORDER BY CREATED DESC";
            user_list_view.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT username, user_id, account_status, created FROM DBA_USERS where account_status = 'OPEN' ORDER BY CREATED DESC";
            user_list_view.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
