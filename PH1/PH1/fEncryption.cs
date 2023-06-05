using System.Data;

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

        private DataTable CreateDataViewFrom(DataTable sourceTable)
        {
            var viewTable = new DataTable();

            foreach (DataColumn column in sourceTable.Columns)
            {
                viewTable.Columns.Add(column.ColumnName, typeof(string));
            }

            return viewTable;
        }

        private void EncryptButton_OnClick(object sender, EventArgs e)
        {
            const string query = "select * from U_AD_QLNV.NHANVIEN$";
            var employeeList = DataProvider.Instance.ExcuteQuery(query);

            // Create new DataTable to store encrypted data
            var encryptedTable = CreateDataViewFrom(employeeList);

            foreach (DataRow row in employeeList.Rows)
            {
                Encryption.EncryptSalaryAndAllowance(row, encryptedTable);
            }

            SortDataTable(encryptedTable, "MANV", SortOrder.Ascending);
            DataGridView.DataSource = encryptedTable;

            _decrypted = false;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.DataSource is not DataTable encryptedTable)
            {
                MessageBox.Show("No data to decrypt");
                return;
            }

            if (_decrypted) return;

            // Create new DataTable to store decrypted data
            var decryptedTable = CreateDataViewFrom(encryptedTable);

            foreach (DataRow row in encryptedTable.Rows)
            {
                Encryption.DecryptSalaryAndAllowance(row, decryptedTable);
            }

            SortDataTable(decryptedTable, "MANV", SortOrder.Ascending);
            DataGridView.DataSource = decryptedTable;

            _decrypted = true;
        }
    }
}