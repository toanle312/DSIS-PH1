using System.Data;

namespace PH1
{
    public partial class fEncryption : Form
    {
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
            const string query = "select * from U_AD_QLNV.NHANVIEN$";
            var employeeList = DataProvider.Instance.ExcuteQuery(query);

            // Create new DataTable to store encrypted data
            var encryptedTable = new DataTable();
            encryptedTable.Columns.Add("MANV", typeof(string));
            encryptedTable.Columns.Add("TENNV", typeof(string));
            encryptedTable.Columns.Add("LUONG", typeof(string));
            encryptedTable.Columns.Add("PHUCAP", typeof(string));

            foreach (DataRow row in employeeList.Rows)
            {
                Encryption.EncryptSalaryAndAllowance(row, encryptedTable);
            }

            SortDataTable(encryptedTable, "MANV", SortOrder.Ascending);
            DataGridView.DataSource = encryptedTable;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (DataGridView.DataSource is not DataTable encryptedTable)
            {
                MessageBox.Show("No data to decrypt");
                return;
            }

            // Create new DataTable to store decrypted data
            var decryptedTable = new DataTable();
            decryptedTable.Columns.Add("MANV", typeof(string));
            decryptedTable.Columns.Add("TENNV", typeof(string));
            decryptedTable.Columns.Add("LUONG", typeof(string));
            decryptedTable.Columns.Add("PHUCAP", typeof(string));

            foreach (DataRow row in encryptedTable.Rows)
            {
                Encryption.DecryptSalaryAndAllowance(row, decryptedTable);
            }

            SortDataTable(decryptedTable, "MANV", SortOrder.Ascending);
            DataGridView.DataSource = decryptedTable;
        }
    }
}