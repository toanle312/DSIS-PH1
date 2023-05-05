using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PH1
{
    public partial class fNhanSu : Form
    {
        public fNhanSu()
        {
            InitializeComponent();
        }

        private void LoadDepartmentData()
        {
            string query = "SELECT * FROM U_AD_QLNV.PHONGBAN";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            DataGridView.DataSource = data;
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
            // Ensure user enter atleast two field, inclusingh the DeptIdTextBox
            if (DeptIdTextBox.Text == "" || (DeptNameTextBox.Text == "" && DeptLeaderTextBox.Text == ""))
            {
                MessageBox.Show("Vui lòng điền mã phòng ban và ít nhất một thông tin cần sửa (trừ mã phòng ban)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}