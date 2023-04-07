using System.Data;

namespace App
{
    public partial class fGrantPrivs : Form
    {
        private bool _columnSelectionMode = false;
        private string _selectedObject = "";

        public fGrantPrivs()
        {
            InitializeComponent();

            initDefaultData();
        }

        private void initDefaultData()
        {
            // Thiết lập dữ liệu ban đầu cho danh sách các bảng/view
            objectList.Items.Clear();
            objectList.Items.AddRange(getObjectNames().ToArray());
            objectList.SelectedIndex = 0;

            // Thiết lập các quyền
            string[] privs = { "SELECT", "INSERT", "UPDATE", "DELETE", "WITH GRANT OPTION" };
            privListBox.Items.Clear();
            privListBox.Items.AddRange(privs);
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string granteeName = granteeTxtBox.Text;
            string table = _columnSelectionMode ? "DBA_COL_PRIVS" : "DBA_TAB_PRIVS";
            string query = $"SELECT * FROM {table} WHERE GRANTEE='{granteeName.ToUpper()}'";
            var queryData = DataProvider.Instance.ExcuteQuery(query);
            privileges.DataSource = queryData;
        }

        private List<string> getObjectNames()
        {
            var tables = DataProvider.Instance.ExcuteQuery("SELECT * FROM USER_TABLES");
            var views = DataProvider.Instance.ExcuteQuery("SELECT * FROM USER_VIEWS");

            List<string> objectNames = new List<string>();

            foreach (DataRow row in tables.Rows)
            {
                objectNames.Add(row["TABLE_NAME"].ToString());
            }
            foreach (DataRow row in views.Rows)
            {
                objectNames.Add(row["VIEW_NAME"].ToString());
            }

            return objectNames;
        }

        private string buildGrantQuery(string objectName)
        {
            // Tạo chuỗi các quyền
            string privQuery = "";
            foreach (var priv in privListBox.CheckedItems)
            {
                if (priv.ToString() != "WITH GRANT OPTION")
                {
                    privQuery += $"{priv},";
                }
            }
            if (privQuery.Length > 0)
                privQuery = privQuery.Remove(privQuery.Length - 1, 1);

            // Lấy tên schema hiện tại
            string schemaQuery = "SELECT USER FROM DUAL";
            string currentSchema = DataProvider.Instance.ExcuteQuery(schemaQuery).Rows[0]["USER"].ToString();

            // Lấy tên của user/role
            string grantee = granteeTxtBox.Text.ToUpper();

            // Tạo query để gọi thủ tục
            bool withGrantOption = privListBox.CheckedItems.Contains("WITH GRANT OPTION");
            string procQuery = $"BEGIN\n\tusp_GrantObjPrivs('{privQuery}', '{currentSchema}', '{objectName}', '{grantee}', {withGrantOption});\nEND;";

            return procQuery;
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            var procQueries = new List<string>();
            if (_columnSelectionMode == false)
            {
                // Lấy tên các bảng/view được chọn
                var selectedObjects = objectList.CheckedItems;

                // Gọi thủ tục cho từng bảng/view
                foreach (var objectName in selectedObjects)
                {
                    procQueries.Add(buildGrantQuery(objectName.ToString()));
                }
            }
            else
            {
                procQueries = buildGrantColumnQuery(_selectedObject);
            }

            try
            {
                foreach (var query in procQueries)
                {
                    DataProvider.Instance.ExcuteQuery(query);
                    MessageBox.Show(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void grantColPrivsBtn_Click(object sender, EventArgs e)
        {
            if (_columnSelectionMode == false)
            {
                if (objectList.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một bảng hoặc view để cấp quyền trên cột!");
                }
                else if (objectList.CheckedItems.Count > 1)
                {
                    MessageBox.Show("Chỉ được chọn 1 bảng hoặc view để cấp quyền trên cột!");
                }
                else if (privListBox.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn quyền cần cấp!");
                }
                else if (privListBox.CheckedItems.Contains("INSERT") || privListBox.CheckedItems.Contains("DELETE"))
                {
                    MessageBox.Show("Không thể cấp quyền INSERT hoặc DELETE trên cột!");
                }
                else if (objectList.CheckedItems.Count > 0)
                {
                    _columnSelectionMode = true;

                    // Thay đổi nhãn của các controls
                    objectLabel.Text = "Chọn cột";
                    grantColPrivsBtn.Text = "Thoát khỏi chế độ cấp quyền cho cột";

                    // Disable các controls không được phép
                    privListBox.Enabled = false;

                    // Thay đổi danh sách các bảng/view thành danh sách các cột
                    _selectedObject = objectList.CheckedItems[0].ToString();

                    List<string> columns = new(getColumns(_selectedObject));

                    // Reset danh sách
                    objectList.Items.Clear();
                    foreach (var col in columns.GroupBy(i => i))
                    {
                        objectList.Items.Add(col.Key);

                        // Giải quyết trường hợp cột bị trùng
                        if (col.Count() > 1)
                        {
                            var colIndex = objectList.Items.IndexOf(col.Key);

                            objectList.SetItemChecked(colIndex, true);
                        }
                    }
                }
            }
            else
            {
                _columnSelectionMode = false;
                _selectedObject = "";

                objectLabel.Text = "Chọn table/view";
                grantColPrivsBtn.Text = "Cấp quyền cho từng cột";
                privListBox.Enabled = true;

                initDefaultData();
            }
        }

        private List<string> getColumns(string objectName)
        {
            string query = $"SELECT * FROM ALL_TAB_COLUMNS WHERE TABLE_NAME='{objectName}'";
            var cols = DataProvider.Instance.ExcuteQuery(query);

            List<string> colNames = new List<string>();

            foreach (DataRow row in cols.Rows)
            {
                colNames.Add(row["COLUMN_NAME"].ToString());
            }

            return colNames;
        }

        private List<string> buildGrantColumnQuery(string objectName)
        {
            // Kiểm tra các quyền được chọn
            bool selectPriv = false;
            bool updatePriv = false;
            foreach (var priv in privListBox.CheckedItems)
            {
                if (priv == "SELECT")
                    selectPriv = true;
                if (priv == "UPDATE")
                    updatePriv = true;
            }
            // Tạo chuỗi các cột
            string colQuery = "";
            foreach (var col in objectList.CheckedItems)
            {
                colQuery += $"{col},";
            }
            if (colQuery.Length > 0)
                colQuery = colQuery.Remove(colQuery.Length - 1, 1);

            // Lấy tên schema hiện tại
            string schemaQuery = "SELECT USER FROM DUAL";
            string currentSchema = DataProvider.Instance.ExcuteQuery(schemaQuery).Rows[0]["USER"].ToString();

            // Lấy tên của user/role
            string grantee = granteeTxtBox.Text.ToUpper();

            // Tạo query để gọi thủ tục
            var procQueries = new List<string>();
            bool withGrantOption = privListBox.CheckedItems.Contains("WITH GRANT OPTION");
            if (selectPriv)
            {
                procQueries.Add($"BEGIN\n\tusp_GrantSelectOnCol('{currentSchema}', '{objectName}', '{colQuery}','{grantee}', {withGrantOption});\nEND;");
            }
            if (updatePriv)
            {
                procQueries.Add($"BEGIN\n\tusp_GrantUpdateOnCol('{objectName}', '{colQuery}','{grantee}', {withGrantOption});\nEND;");
            }
            return procQueries;
        }
    }
}