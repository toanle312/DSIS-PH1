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

namespace PH1
{
    public partial class fDelUser : Form
    {
        public fDelUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DataProvider.Instance.getConn();

            string username = username_textbox.Text.ToUpper();

            //username trong thi thong bao
            if (username == "")
            {
                resultLabel.Text = "Username can't be empty!!";
            }
            else
            {
                string pattern = @"^[^\s]+$";

                bool isMatch = Regex.IsMatch(username, pattern);
                //neu username co khoang trang thi nhap lai
                if (!isMatch)
                {
                    resultLabel.Text = "Username is invalid!!";
                }
                else
                {
                    conn.Open();
                    string functionName = "CHECK_USER_ROLE_EXIST";
                    OracleCommand cmd = new OracleCommand(functionName, conn);

                    cmd.CommandText = $"SELECT {functionName}(:parameter1) FROM DUAL";
                    cmd.Parameters.Add("parameter1", OracleDbType.Varchar2).Value = username;

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result == 0 || result == 2)
                    {
                        resultLabel.Text = $"User {username} does not exist!!";
                    }
                    else
                    {
                        functionName = "DELETE_USER_SP";

                        cmd = new OracleCommand(functionName, conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("in_username", OracleDbType.Varchar2).Value = username;

                        cmd.ExecuteNonQuery();

                        resultLabel.Text = $"User {username} dropped!!";
                    }
                }
            }
            username_textbox.Text = "";
            conn.Close();
        }
    }
}
