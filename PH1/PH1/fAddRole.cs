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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PH1
{
    public partial class fAddRole : Form
    {
        public fAddRole()
        {
            InitializeComponent();
        }

        private void fAddRole_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DataProvider.Instance.getConn();

            string rolename = rolename_textbox.Text.ToUpper();

            //rolename trong thi thong bao
            if (rolename == "")
            {
                ResultLabel.Text = "Rolename can't be empty!!";
            }
            else
            {
                string pattern = @"^[^\s]+$";

                bool isMatch = Regex.IsMatch(rolename, pattern);
                //neu username co khoang trang thi nhap lai
                if (!isMatch)
                {
                    ResultLabel.Text = "Rolename is invalid!!";
                }
                else
                {
                    conn.Open();
                    string functionName = "CHECK_USER_ROLE_EXIST";
                    OracleCommand cmd = new OracleCommand(functionName, conn);

                    cmd.CommandText = $"SELECT {functionName}(:parameter1) FROM DUAL";
                    cmd.Parameters.Add("parameter1", OracleDbType.Varchar2).Value = rolename;

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result == 1 || result == 2)
                    {
                        ResultLabel.Text = $"Role {rolename} conflicts with another user or role name!!";
                    }
                    else
                    {
                        functionName = "CREATE_ROLE_SP";

                        cmd = new OracleCommand(functionName, conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("in_rolename", OracleDbType.Varchar2).Value = rolename;

                        cmd.ExecuteNonQuery();

                        ResultLabel.Text = $"Role {rolename} created!!";
                    }
                }
            }
            rolename_textbox.Text = "";
            conn.Close();
        }
    }
}
