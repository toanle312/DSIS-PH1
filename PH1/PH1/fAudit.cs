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
    public partial class fAudit : Form
    {
        public fAudit()
        {
            InitializeComponent();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            comboBox1.SelectedIndex = 2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // bang phan cong
            if (comboBox1.SelectedIndex == 0)
            {
                string query = "SELECT SESSION_ID, TIMESTAMP, DB_USER, OS_USER, USERHOST, OBJECT_SCHEMA, OBJECT_NAME, POLICY_NAME, SQL_TEXT, STATEMENT_TYPE, EXTENDED_TIMESTAMP FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_NAME='PHANCONG$'";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
            // bang nhan vien
            else if (comboBox1.SelectedIndex == 1)
            {
                string query = "SELECT SESSION_ID, TIMESTAMP, DB_USER, OS_USER, USERHOST, OBJECT_SCHEMA, OBJECT_NAME, POLICY_NAME, SQL_TEXT, STATEMENT_TYPE, EXTENDED_TIMESTAMP FROM DBA_FGA_AUDIT_TRAIL WHERE OBJECT_NAME='NHANVIEN$'";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
            else
            {
                string query = "SELECT SESSION_ID, TIMESTAMP, DB_USER, OS_USER, USERHOST, OBJECT_SCHEMA, OBJECT_NAME, POLICY_NAME, SQL_TEXT, STATEMENT_TYPE, EXTENDED_TIMESTAMP FROM DBA_FGA_AUDIT_TRAIL";
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery(query);
            }
        }
    }
}
