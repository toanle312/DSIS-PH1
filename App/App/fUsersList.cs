using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fUsersList : Form
    {
        public fUsersList()
        {
            InitializeComponent();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DBA_USERS";
            user_list_view.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
