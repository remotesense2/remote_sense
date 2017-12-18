using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Data.SQLite;

namespace phoenix
{
    class DBExecutor
    {
        private SQLiteConnection m_dbConnection;
        public bool NewCreated = false;

        public DBExecutor(string strPath)
        {
            if (!File.Exists(strPath))
            {
                SQLiteConnection.CreateFile(strPath);
                NewCreated = true;
            }

            m_dbConnection = new SQLiteConnection("Data Source="+ strPath +";Version=3;");
            m_dbConnection.Open();
        }

        public bool ExecuteSQL(string sql)
        {
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public SQLiteDataReader QuerySQL(string sql)
        {
            SQLiteDataReader reader = null;
            try
            {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            reader = command.ExecuteReader();
            }
            catch (System.Exception)
            {
            }
            return reader;
        }
    }
}
