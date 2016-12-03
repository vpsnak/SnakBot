using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Data.SQLite;
using System.IO;

namespace SnakBot
{
    public class SQLFile
    {
        public SQLiteConnection conn;
        private SQLiteCommand cmd;
        private Timer ConnectionTimer = new Timer(30000);
        public bool ConnectionState { set; get; } = false;
        public SQLFile(string fileName)
        {
            if (!File.Exists(fileName))
                SQLiteConnection.CreateFile(fileName);

            conn = new SQLiteConnection("data source=" + fileName);
            cmd = new SQLiteCommand(conn);
            ConnectionTimer.Elapsed += ConnectionTimerTick;
        }
        public void openSqlConnection()
        {
            if (ConnectionState == false)
            {
                conn.Open();
                ConnectionState = true;
                ConnectionTimer.Start();
            }
            else
            {
                RefreshConnection();
            }
        }
        public void closeSqlConnection()
        {
            if (ConnectionState == true)
            {
                ConnectionTimer.Stop();
                ConnectionState = false;
                conn.Close();
            }
        }
        public void runSQL(string command)
        {
            RefreshConnection();
            cmd.CommandText = command;
            cmd.ExecuteNonQuery();
        }
        public SQLiteDataReader readSQL(string command)
        {
            RefreshConnection();
            cmd.CommandText = command;
            return cmd.ExecuteReader();
        }
        private void ConnectionTimerTick(object sender, ElapsedEventArgs e)
        {
            if (ConnectionState == true)
            {
                closeSqlConnection();
                ConnectionState = false;
            }
        }
        public void RefreshConnection()
        {
            ConnectionTimer.Interval = ConnectionTimer.Interval;
        }
    }
}
