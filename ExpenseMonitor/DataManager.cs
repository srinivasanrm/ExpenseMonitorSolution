using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace ExpenseMonitor
{
    public class DataManager
    {
        private static DataManager _instance = null;
        private static string _connstring = "Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=exp.sdf";
        private OleDbConnection _conn   = null;

        private DataManager(): this(_connstring)
        {
        }

        private DataManager(string connectionString)
        {
            if (connectionString != null || connectionString.Trim().Length > 0)
            {
                _connstring = connectionString;
            }
            _conn = new OleDbConnection(_connstring);
        }

        public static DataManager Instance()
        {
            if (_instance == null)
            {
                _instance = new DataManager();
            }
            return _instance;
        }


        private OleDbConnection getConnection()
        {
            return _conn;
        }
        
        private void closeConnection()
        {
            Logger.LogInfo("Closing DB connection");
            _conn.Close();
            _conn.Dispose();
        }
        
        public static OleDbDataReader getReaderByExecQuery(string sql)
        {
            try
            {                
                Instance().connOpen();
                OleDbCommand cmd = new OleDbCommand(sql, Instance().getConnection());
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw ex;
            }
        }

        public static DataTable getDatatableByExecQuery(string sql)
        {
            try
            {
                DataTable table = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, Instance().getConnection());
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw ex;
            }
        }

        public static bool doesRowExists(string sql)
        {
            return (getDatatableByExecQuery(sql).Rows.Count!=0);
        }

        public static int execNonQuery(string sql)
        {
            try
            {
                Instance().connOpen();
                OleDbCommand cmd = new OleDbCommand(sql, Instance().getConnection());
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
                throw ex;
            }
        }
        
        public static void close()
        {
            try
            {
                Instance().closeConnection();
            }
            catch (Exception ex)
            {
                Logger.LogException(ex);
            }
        }

        private void connOpen()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                Logger.LogInfo("Opening DB connection");
                _conn.Open();
            }
        }
    }
}
