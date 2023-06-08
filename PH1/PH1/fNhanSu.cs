using System.Data;
using System.Text;

namespace PH1
{
    public partial class fNhanSu : Form
    {
        private readonly string _username;

        public fNhanSu(string username)
        {
            InitializeComponent();

            _username = username;

            IDLabel.Text = _username;
            RoleLabel.Text = "Nhân sự";
        }

        private void LoadDepartmentData()
        {
            string query = "SELECT * FROM U_AD_QLNV.PHONGBAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DataGridView.DataSource = data;
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT * FROM U_AD_QLNV.NHANVIEN_NHANSU";

            var data = DataProvider.Instance.ExcuteQuery(query);

            var decryptedTable = EmployeeServices.CreateDataTableFrom(data);

            foreach (DataRow row in data.Rows)
            {
                if (row["MANV"].ToString() == IDLabel.Text && row["VAITRO"].ToString() == RoleLabel.Text)
                {
                    Encryption.DecryptEmployee(row, decryptedTable);
                }
                else
                {
                    decryptedTable.ImportRow(row);
                }
            }

            DataProvider.Instance.SortDataTable(decryptedTable, "MANV", SortOrder.Ascending);
            DataGridView.DataSource = decryptedTable;
        }

        private void AddDeptButton_Click(object sender, EventArgs e)
        {
            // Ensure user enter all required information
            if (DeptIdTextBox.Text == "" || DeptNameTextBox.Text == "" || DeptLeaderTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build the query
            string query = $"INSERT INTO U_AD_QLNV.PHONGBAN VALUES ('{DeptIdTextBox.Text}', '{DeptNameTextBox.Text}', '{DeptLeaderTextBox.Text}')";

            // Execute the query
            DataProvider.Instance.ExcuteNonQuery(query);

            // Notify the user
            MessageBox.Show("Thêm phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update the DataGridView
            LoadDepartmentData();
        }

        private void UpdateDeptButton_Click(object sender, EventArgs e)
        {
            if (DeptIdTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã của phòng ban cần chỉnh sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Ensure user enter atleast two field, inclusingh the DeptIdTextBox
            if (DeptNameTextBox.Text == "" && DeptLeaderTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng điền ít nhất một thông tin ngoài mã phòng ban cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build the query
            string query;
            if (DeptNameTextBox.Text == "")
            {
                query = $"UPDATE U_AD_QLNV.PHONGBAN SET TRGPHG = '{DeptLeaderTextBox.Text}' WHERE MAPB = '{DeptIdTextBox.Text}'";
            }
            else
            {
                query = $"UPDATE U_AD_QLNV.PHONGBAN SET TENPB = '{DeptNameTextBox.Text}' WHERE MAPB = '{DeptIdTextBox.Text}'";
            }

            // Execute the query
            DataProvider.Instance.ExcuteNonQuery(query);

            // Notify the user
            MessageBox.Show("Cập nhật phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update the DataGridView
            LoadDepartmentData();
        }

        private void ViewDeptButton_Click(object sender, EventArgs e)
        {
            LoadDepartmentData();
        }

        private void EmpPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            fTaiChinh.RestrictNumeric(e);
        }

        private void ViewEmpButton_Click(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void UpdateEmpButton_Click(object sender, EventArgs e)
        {
            if (EmpIdTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng điền mã của nhân viên cần chỉnh sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Build the query
            var queryBuilder = new StringBuilder("UPDATE U_AD_QLNV.NHANVIEN_NHANSU SET");
            foreach (Control control in EmpGroupBox.Controls)
            {
                // Ensure that the user enter employee Id
                if (control.Name == "EmpIdTextBox") continue;

                // Check if the user enters the information
                if (string.IsNullOrEmpty(control.Text.Trim())) continue;

                // Get the control name
                var controlName = control.Name;

                // Build the query
                switch (control)
                {
                    case TextBox textBox when controlName == "EmpNameTextBox":
                        queryBuilder.Append($" TENNV = N'{textBox.Text}',");
                        break;

                    case TextBox textBox when controlName == "EmpPhoneTextBox":
                        queryBuilder.Append($" SODT = '{textBox.Text}',");
                        break;

                    case TextBox textBox when controlName == "EmpRoleTextBox":
                        queryBuilder.Append($" VAITRO = N'{textBox.Text}',");
                        break;

                    case TextBox textBox when controlName == "EmpManagerIdTextBox":
                        queryBuilder.Append($" MANQL = '{textBox.Text}',");
                        break;

                    case TextBox textBox when controlName == "EmpDeptTextBox":
                        queryBuilder.Append($" PHG = '{textBox.Text}',");
                        break;

                    case ComboBox comboBox:
                        queryBuilder.Append($" PHAI = N'{comboBox.Text}',");
                        break;

                    case DateTimePicker dateTimePicker:
                        queryBuilder.Append($" NGAYSINH = TO_DATE('{dateTimePicker.Text}', 'DD/MM/YYYY'),");
                        break;

                    case RichTextBox richTextBox:
                        queryBuilder.Append($" DIACHI = N'{richTextBox.Text}',");
                        break;

                    default:
                        break;
                }
            }

            // Remove the last comma
            var query = queryBuilder.ToString().TrimEnd(',');

            // Add the condition
            query += $" WHERE MANV = '{EmpIdTextBox.Text}'";
            //MessageBox.Show(query);

            // Execute the query
            DataProvider.Instance.ExcuteNonQuery(query);

            // Notify the user
            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update the DataGridView
            LoadEmployeeData();
        }

        private void EmployeeInterfaceButton_Click(object sender, EventArgs e)
        {
            Hide();

            var screen = new fNhanVien(_username, "Nhân sự");
            screen.ShowDialog();

            DialogResult = DialogResult.OK;
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.DisconnectDB();

            DialogResult = DialogResult.OK;

            Close();

            var f = new Login();
            f.Show();
        }
    }
}