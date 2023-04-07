using System.Data;

namespace App
{
    public partial class fGrantRole : Form
    {
        public fGrantRole()
        {
            InitializeComponent();

            InitDefaultData();
        }

        private void InitDefaultData()
        {
            roleList.Items.AddRange(GetRoles().ToArray());
            roleList.SelectedIndex = 0;
        }

        private void CheckRoleButton_Click(object sender, EventArgs e)
        {
            string grantee = GetGrantee();
            string query = $"SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE='{grantee.ToUpper()}'";

            var queryData = DataProvider.Instance.ExcuteQuery(query);
            grantedRoles.DataSource = queryData;
        }

        private string GetGrantee()
        {
            return granteeTextBox.Text.ToUpper();
        }

        private string[] GetRoles()
        {
            string query = "SELECT * FROM DBA_ROLES";
            var roles = DataProvider.Instance.ExcuteQuery(query);

            List<string> roleNames = new();

            foreach (DataRow row in roles.Rows)
            {
                roleNames.Add(row["ROLE"].ToString() ?? "");
            }

            return roleNames.ToArray();
        }

        private void GrantRoleButton_Click(object sender, EventArgs e)
        {
            // Lấy grantee cần cấp role
            string grantee = GetGrantee();

            // Lấy tên vai trò được chọn
            var selectedRoles = roleList.CheckedItems;

            foreach (var role in selectedRoles)
            {
                string query = $"BEGIN\n\tusp_GrantRole('{role}', '{grantee}');\nEND;";
                MessageBox.Show(query);

                try
                {
                    DataProvider.Instance.ExcuteQuery(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}