using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fGrantRole : Form
    {
        public fGrantRole()
        {
            InitializeComponent();
            roleList.Items.AddRange(getRoles().ToArray());
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string granteeName = granteeTextBox.Text;
            string query = $"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE='{granteeName.ToUpper()}'";
            var queryData = DataProvider.Instance.ExcuteQuery(query);
            privileges.DataSource = queryData;
        }

        private List<string> getRoles()
        {
            var roles = DataProvider.Instance.ExcuteQuery("SELECT * FROM DBA_ROLES");

            List<string> roleNames = new List<string>();

            foreach (DataRow row in roles.Rows)
            {
                roleNames.Add(row["ROLE"].ToString());
            }

            return roleNames;
        }

        private string buildGrantQuery(string role)
        {
            // Lấy tên của user/role
            string grantee = granteeTextBox.Text.ToUpper();

            // Tạo query để gọi thủ tục
            string procQuery = $"BEGIN\n\tusp_GrantRole('{role}', '{grantee}');\nEND;";

            return procQuery;
        }

        private void grantRole_Click(object sender, EventArgs e)
        {
            // Lấy tên các bảng/view được chọn
            var selectedRoles = roleList.CheckedItems;
            foreach (var role in selectedRoles)
            {
                string procQuery = buildGrantQuery(role.ToString());
                MessageBox.Show(procQuery);

                try
                {
                    DataProvider.Instance.ExcuteQuery(procQuery);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}