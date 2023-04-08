using System.Data;

namespace App
{
    public partial class fGrantPrivs : Form
    {
        private bool _grantColumnPrivsMode = false;
        private string _selectedObject = "";

        public fGrantPrivs()
        {
            InitializeComponent();

            InitDefaultData();
        }

        private void InitDefaultData()
        {
            // Thiết lập các biến toàn cục
            _grantColumnPrivsMode = false;
            _selectedObject = "";

            // Thiết lập dữ liệu ban đầu cho danh sách bảng/view
            targetList.Items.Clear();
            targetList.Items.AddRange(getObjectNames().ToArray());
            if (targetList.Items.Count > 0)
                targetList.SelectedIndex = 0;

            // Thiết lập các quyền
            string[] privs = { "SELECT", "INSERT", "UPDATE", "DELETE", "WITH GRANT OPTION" };
            privList.Items.Clear();
            privList.Items.AddRange(privs);
        }

        private string[] getObjectNames()
        {
            var tables = DataProvider.Instance.ExcuteQuery("SELECT * FROM USER_TABLES");
            var views = DataProvider.Instance.ExcuteQuery("SELECT * FROM USER_VIEWS");

            List<string> objectNames = new();

            foreach (DataRow row in tables.Rows)
            {
                objectNames.Add(row["TABLE_NAME"].ToString() ?? "");
            }
            foreach (DataRow row in views.Rows)
            {
                objectNames.Add(row["VIEW_NAME"].ToString() ?? "");
            }

            return objectNames.ToArray();
        }

        private void CheckPrivsButton_Click(object sender, EventArgs e)
        {
            string grantee = GetGrantee();
            string table = _grantColumnPrivsMode ? "DBA_COL_PRIVS" : "DBA_TAB_PRIVS";

            string query = $"SELECT * FROM {table} WHERE GRANTEE='{grantee}'";
            var queryData = DataProvider.Instance.ExcuteQuery(query);

            grantedPrivileges.DataSource = queryData;
        }

        private string GetGrantee()
        {
            return granteeTextBox.Text.ToUpper();
        }

        private void GrantPrivsButton_Click(object sender, EventArgs e)
        {
            var queries = BuildQueries();
            try
            {
                foreach (var query in queries)
                {
                    DataProvider.Instance.ExcuteQuery(query);
                    //MessageBox.Show(query);
                }
                MessageBox.Show("Grant successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Grant unsuccessfully! Error:\n\n{ex.Message}");
            }
        }

        private List<string> BuildQueries()
        {
            var queries = new List<string>();

            if (_grantColumnPrivsMode == false)
            {
                // Lấy tên các bảng/view được chọn
                var selectedObjects = targetList.CheckedItems;

                // Tạo chuỗi thực thi thủ tục cho từng bảng/view
                foreach (var obj in selectedObjects)
                {
                    string objectName = obj.ToString() ?? "";
                    queries.Add(BuildGrantPrivsQuery(objectName));
                }
            }
            else
            {
                // Tạo các chuỗi thực thi thủ tục cho các cột
                queries.AddRange(BuildGrantColumnPrivsQueries(_selectedObject));
            }

            return queries;
        }

        private string BuildGrantPrivsQuery(string objectName)
        {
            // Tạo chuỗi các quyền
            string privs = BuildPrivsString();

            // Lấy tên schema hiện tại
            string schema = GetCurrentSchema();

            // Lấy tên của user/role
            string grantee = GetGrantee();

            // Kiểm tra with grant option
            bool withGrantOption = privList.CheckedItems.Contains("WITH GRANT OPTION");

            // Tạo chuỗi thực thi
            string query = $"BEGIN\n\tusp_GrantObjPrivs('{privs}', '{schema}', '{objectName}', '{grantee}', {withGrantOption});\nEND;";

            return query;
        }

        private string BuildPrivsString()
        {
            string privs = "";

            foreach (var priv in privList.CheckedItems)
            {
                if (priv.ToString() != "WITH GRANT OPTION")
                {
                    privs += $"{priv},";
                }
            }
            if (privs.Length > 0)
                privs = privs.Remove(privs.Length - 1, 1);

            return privs;
        }

        private string GetCurrentSchema()
        {
            string query = "SELECT USER FROM DUAL";
            var user = DataProvider.Instance.ExcuteQuery(query);
            string currentSchema = user.Rows[0]["USER"].ToString() ?? "";

            return currentSchema;
        }

        private void GrantColPrivsButton_Click(object sender, EventArgs e)
        {
            if (_grantColumnPrivsMode == false)
            {
                if (targetList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please choose one table or view for granting privileges on column!", "Message");
                }
                else if (targetList.CheckedItems.Count > 1)
                {
                    MessageBox.Show("Can choose only one table or view!", "Message");
                }
                else if (privList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please choose privilege(s) that you want to grant!", "Message");
                }
                else if (privList.CheckedItems.Contains("INSERT") || privList.CheckedItems.Contains("DELETE"))
                {
                    MessageBox.Show("Can not grant INSERT or DELETE privilege on column!", "Message");
                }
                else
                {
                    ChangeToGrantColumnPrivsMode();
                }
            }
            else
            {
                ChangeToGrantObjectPrivsMode();
            }
        }

        private void ChangeToGrantColumnPrivsMode()
        {
            _grantColumnPrivsMode = true;

            // Thay đổi nhãn của các controls
            targetLabel.Text = "Choose column";
            grantColPrivsBtn.Text = "Exit Grant Privileges For Column";

            // Disable các controls không được phép chọn
            privList.Enabled = false;

            // Lưu lại object được chọn để cấp quyền trên cột
            _selectedObject = targetList.CheckedItems[0]?.ToString() ?? "";

            // Đổi danh sách object trước đó thành danh sách các cột
            targetList.Items.Clear();
            targetList.Items.AddRange(GetColumns(_selectedObject));
        }

        private string[] GetColumns(string objectName)
        {
            string currentSchema = GetCurrentSchema();
            string query = $"SELECT DISTINCT(COLUMN_NAME) FROM ALL_TAB_COLUMNS WHERE TABLE_NAME='{objectName}' AND OWNER='{currentSchema}'";
            var columns = DataProvider.Instance.ExcuteQuery(query);

            List<string> columnNames = new();

            foreach (DataRow row in columns.Rows)
            {
                columnNames.Add(row["COLUMN_NAME"].ToString() ?? "");
            }

            return columnNames.ToArray();
        }

        private void ChangeToGrantObjectPrivsMode()
        {
            // Thay đổi nhãn của các controls
            targetLabel.Text = "Choose table / view";
            grantColPrivsBtn.Text = "Grant Privileges For Column";

            // Enable các controls được phép chọn
            privList.Enabled = true;

            // Reset về dữ liệu mặc định
            InitDefaultData();
        }

        private List<string> BuildGrantColumnPrivsQueries(string objectName)
        {
            // Kiểm tra các quyền được chọn
            bool selectPriv = privList.CheckedItems.Contains("SELECT");
            bool updatePriv = privList.CheckedItems.Contains("UPDATE");
            bool withGrantOption = privList.CheckedItems.Contains("WITH GRANT OPTION");

            // Tạo chuỗi các cột
            string columns = BuildColsString();

            // Lấy tên schema hiện tại
            string schema = GetCurrentSchema();

            // Lấy tên của user/role
            string grantee = GetGrantee();

            // Tạo các chuỗi thực thi
            var queries = new List<string>();

            if (selectPriv)
            {
                queries.Add($"BEGIN\n\tusp_GrantSelectOnCol('{schema}', '{objectName}', '{columns}','{grantee}', {withGrantOption});\nEND;");
            }
            if (updatePriv)
            {
                queries.Add($"BEGIN\n\tusp_GrantUpdateOnCol('{objectName}', '{columns}','{grantee}', {withGrantOption});\nEND;");
            }

            return queries;
        }

        private string BuildColsString()
        {
            string columns = "";

            foreach (var col in targetList.CheckedItems)
            {
                columns += $"{col},";
            }
            if (columns.Length > 0)
                columns = columns.Remove(columns.Length - 1, 1);

            return columns;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}