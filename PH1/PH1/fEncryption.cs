using System.Data;
using System.Diagnostics;

namespace PH1
{
    public partial class fEncryption : Form
    {
        private bool _decrypted = false;

        public fEncryption()
        {
            InitializeComponent();
        }

        private enum SortOrder
        {
            Ascending,
            Descending
        }

        private void SortDataTable(DataTable table, string column, SortOrder order)
        {
            table.DefaultView.Sort = $"{column} {(order == SortOrder.Ascending ? "asc" : "desc")}";
            table = table.DefaultView.ToTable();
        }

        private void EncryptButton_OnClick(object sender, EventArgs e)
        {
            // ! Lấy dữ liệu từ bảng NHANVIEN$ để mã hóa.
            const string query = "select * from U_AD_QLNV.NHANVIEN$";
            var employeeList = DataProvider.Instance.ExcuteQuery(query);

            var encryptedTable = EmployeeServices.CreateDataTableFrom(employeeList);

            foreach (DataRow row in employeeList.Rows)
            {
                Encryption.EncryptEmployee(row, encryptedTable);
            }

            SortDataTable(encryptedTable, "MANV", SortOrder.Ascending);
            DataGridView.DataSource = encryptedTable;

            _decrypted = false;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.DataSource is not DataTable encryptedTable)
            {
                MessageBox.Show("No data to decrypt", "Message");
                return;
            }

            if (_decrypted) return;

            var decryptedTable = EmployeeServices.CreateDataTableFrom(encryptedTable);

            foreach (DataRow row in encryptedTable.Rows)
            {
                Encryption.DecryptEmployee(row, decryptedTable);
            }

            SortDataTable(decryptedTable, "MANV", SortOrder.Ascending);
            DataGridView.DataSource = decryptedTable;

            _decrypted = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.DataSource is not DataTable table)
            {
                MessageBox.Show("No data to save", "Message");
                return;
            }

            if (_decrypted)
            {
                MessageBox.Show("Please encrypt data before saving", "Message");
                return;
            }

            string dropQuery = $"delete from U_AD_QLNV.NHANVIEN_ENCRYPTED";
            DataProvider.Instance.ExcuteNonQuery(dropQuery);

            foreach (DataRow row in table.Rows)
            {
                var employee = EmployeeServices.GetEmployeeInfo(row);

                // ! Lưu dữ liệu mã hóa vào bảng NHANVIEN_ENCRYPTED
                string insertQuery = $"insert into U_AD_QLNV.NHANVIEN_ENCRYPTED values (" +
                                     $"'{employee.Id}'," +
                                     $"N'{employee.Name}'," +
                                     $"N'{employee.Gender}'," +
                                     $"to_date('{employee.Birthday:dd/MM/yyyy}','DD/MM/YY')," +
                                     $"N'{employee.Address}'," +
                                     $"'{employee.PhoneNumber}'," +
                                     $"'{employee.Salary[2..]}'," +
                                     $"'{employee.Allowance[2..]}'," +
                                     $"N'{employee.Role}'," +
                                     $"'{employee.ManagerId}'," +
                                     $"'{employee.Department}')";

                Debug.WriteLine(insertQuery);

                DataProvider.Instance.ExcuteNonQuery(insertQuery);
            }

            MessageBox.Show("Saved", "Message");
        }
    }
}