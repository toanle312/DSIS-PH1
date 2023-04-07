using System.Data;
using System.Linq;

namespace App
{
    public partial class fGrantPrivs : Form
    {
        public fGrantPrivs()
        {
            InitializeComponent();

            // Thiết lập dữ liệu ban đầu cho danh sách các bảng/view
            objectList.Items.AddRange(getObjectNames().ToArray());
            objectList.SelectedIndex = 0;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string granteeName = granteeTxtBox.Text;
            string query = $"SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE='{granteeName.ToUpper()}'";
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
            // Lấy danh sách các quyền
            string[] privs = new string[] {
                selectPrivCheckBox.Checked ? selectPrivCheckBox.Text : "",
                insertPrivCheckBox.Checked ? insertPrivCheckBox.Text : "",
                updatePrivCheckBox.Checked ? updatePrivCheckBox.Text : "",
                deletePrivCheckBox.Checked ? deletePrivCheckBox.Text : "",
            };
            string withGrantPriv = withGrantCheckBox.Checked ? "TRUE" : "FALSE";

            // Tạo chuỗi các quyền
            string privQuery = "";
            for (int i = 0; i < privs.Length; i++)
            {
                string priv = privs[i];
                if (priv != "")
                {
                    privQuery += $"{priv},";
                }
            }
            privQuery = privQuery.Remove(privQuery.Length - 1, 1);

            // Lấy tên schema hiện tại
            string schemaQuery = "SELECT USER FROM DUAL";
            string currentSchema = DataProvider.Instance.ExcuteQuery(schemaQuery).Rows[0]["USER"].ToString();

            // Lấy tên của user/role
            string grantee = granteeTxtBox.Text.ToUpper();

            // Tạo query để gọi thủ tục
            string procQuery = $"BEGIN\n\tusp_GrantObjPrivs('{privQuery}', '{currentSchema}', '{objectName}', '{grantee}', {withGrantPriv});\nEND;";

            return procQuery;
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            // Lấy tên các bảng/view được chọn
            var selectedObject = objectList.CheckedItems;

            // Gọi thủ tục cho từng bảng/view
            foreach (var objectName in selectedObject)
            {
                string procQuery = buildGrantQuery(objectName.ToString());
                MessageBox.Show(procQuery);

                try
                {
                    DataProvider.Instance.ExcuteQuery(procQuery);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}