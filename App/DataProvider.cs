using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace App
{
    internal class DataProvider
    {
        private static DataProvider _instance;

        public static DataProvider Instance
        {
            get { if (_instance == null) _instance = new DataProvider(); return _instance; }
            private set { _instance = value; }
        }

        private DataProvider() {  }

        private OracleConnection connection;

        public void DisconnectDB()
        {
            connection.Close();
            connection.Dispose();
        }

        public string ConnectDB(string usr, string pwd)
        {
            String conn = @"Data Source=localhost:1521/xe; User ID=" + usr + ";Password=" + pwd + "";
            conn = string.Format(conn, usr, pwd);

            connection = new OracleConnection();
            connection.ConnectionString = conn;

            try
            {
                connection.Open();
                connection.Close();
                return "Success";
            }
            catch (OracleException ex)
            {
                connection = null;
                return ex.Message;
            }
        }

        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            
            connection.Open();

            OracleCommand cmd = new OracleCommand(query, connection);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            adapter.Fill(data);

            connection.Close();

            return data;
        }

        public int ExcuteNonQuery(string query)
        {
            int data = 0;

            connection.Open();

            OracleCommand cmd = new OracleCommand(query, connection);

            data = cmd.ExecuteNonQuery();

            connection.Close();

            return data;
        }

        public object ExcuteScalar(string query)
        {
            object data = 0;

            connection.Open();

            OracleCommand cmd = new OracleCommand(query, connection);

            data = cmd.ExecuteScalar();

            connection.Close();

            return data;
        }
    }
}
