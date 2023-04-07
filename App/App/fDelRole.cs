using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class fDelRole : Form
    {
        public fDelRole()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DataProvider.Instance.getConn();

            string rolename = rolename_textbox.Text.ToUpper();

            //username trong thi thong bao
            if (rolename == "")
            {
                resultLabel.Text = "Rolename can't be empty!!";
            }
            else
            {
                string pattern = @"^[^\s]+$";

                bool isMatch = Regex.IsMatch(rolename, pattern);
                //neu username co khoang trang thi nhap lai
                if (!isMatch)
                {
                    resultLabel.Text = "Rolename is invalid!!";
                }
                else
                {
                    conn.Open();
                    string functionName = "CHECK_USER_ROLE_EXIST";
                    OracleCommand cmd = new OracleCommand(functionName, conn);

                    cmd.CommandText = $"SELECT {functionName}(:parameter1) FROM DUAL";
                    cmd.Parameters.Add("parameter1", OracleDbType.Varchar2).Value = rolename;

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result == 0 || result == 1)
                    {
                        resultLabel.Text = $"Role {rolename} does not exist!!";
                    }
                    else
                    {
                        functionName = "DELETE_ROLE_SP";

                        cmd = new OracleCommand(functionName, conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("in_rolename", OracleDbType.Varchar2).Value = rolename;

                        cmd.ExecuteNonQuery();

                        resultLabel.Text = $"Role {rolename} dropped!!";
                    }
                }
            }
            rolename_textbox.Text = "";
            conn.Close();
        }
    }
}
