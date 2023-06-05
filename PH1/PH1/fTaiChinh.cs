using System.Data;

namespace PH1
{
    public partial class fTaiChinh : Form
    {
        private readonly string _username;

        public fTaiChinh(string username)
        {
            InitializeComponent();

            _username = username;

            IDLabel.Text = _username;
            RoleLabel.Text = "Tài chính";
        }

        private void ViewEmpButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.NHANVIEN";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

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

        private void ViewAllocationButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.PHANCONG";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DataGridView.DataSource = data;
        }

        public static void RestrictNumeric(KeyPressEventArgs e)
        {
            // Only allow number to be entered
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictNumeric(e);
        }

        private void AllowanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictNumeric(e);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Ensure that the user enter all the information
            if (EmpIdTextBox.Text == "" || SalaryTextBox.Text == "" || AllowanceTextBox.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string id = EmpIdTextBox.Text;
                string salary = SalaryTextBox.Text;
                string allowance = AllowanceTextBox.Text;

                // Update the salary and allowance of the employee
                string query = $"UPDATE U_AD_QLNV.NHANVIEN SET LUONG='{salary}', PHUCAP='{allowance}' WHERE MANV='{id}'";

                DataProvider.Instance.ExcuteScalar(query);

                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Get the updated data
                query = $"SELECT * FROM U_AD_QLNV.NHANVIEN WHERE MANV='{id}'";

                DataTable data = DataProvider.Instance.ExcuteQuery(query);

                // Display the updated data
                DataGridView.DataSource = data;
            }
        }

        private void EmployeeInterfaceButton_Click(object sender, EventArgs e)
        {
            Hide();

            var screen = new fNhanVien(_username, "Tài chính");
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