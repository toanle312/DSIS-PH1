using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace PH1
{
    public partial class fAddUser : Form
    {
        public fAddUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DataProvider.Instance.getConn();

            string username = username_textbox.Text.ToUpper();
            string password = password_textbox.Text;

            //neu password hoac username trong thi thong bao
            if (password == "" || username == "")
            {
                resultLabel.Text = "Password or username can't be empty!!";
            }
            else
            {
                string pattern = @"^[^\s]+$";

                bool isMatch = Regex.IsMatch(username, pattern);
                bool isMatch1 = Regex.IsMatch(password, pattern);
                //neu password hoac username co khoang trang thi nhap lai
                if (!isMatch || !isMatch1)
                {
                    resultLabel.Text = "Password or username is invalid!!";
                }
                else
                {
                    conn.Open();
                    string functionName = "CHECK_USER_ROLE_EXIST";
                    OracleCommand cmd = new OracleCommand(functionName, conn);

                    cmd.CommandText = $"SELECT {functionName}(:parameter1) FROM DUAL";
                    cmd.Parameters.Add("parameter1", OracleDbType.Varchar2).Value = username;

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result == 1 || result == 2)
                    {
                        resultLabel.Text = $"User {username} conflicts with another user or rolename!!";
                    }
                    else
                    {
                        functionName = "CREATE_USER_SP";

                        cmd = new OracleCommand(functionName, conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("in_username", OracleDbType.Varchar2).Value = username;
                        cmd.Parameters.Add("in_password", OracleDbType.Varchar2).Value = password;


                        cmd.ExecuteNonQuery();

                        resultLabel.Text = $"User {username} created!!";

                    }
                }
            }
            username_textbox.Text = "";
            password_textbox.Text = "";
            conn.Close();
        }
    }
}


