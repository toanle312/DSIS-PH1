using System.Data;

namespace PH1
{
    public partial class fTaiChinh : Form
    {
        public fTaiChinh()
        {
            InitializeComponent();
        }

        private void ViewEmpButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM U_AD_QLNV.NHANVIEN";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            DataGridView.DataSource = data;
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
    }
}