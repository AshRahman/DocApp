using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public  class DatabaseConnectionClass
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        public DatabaseConnectionClass() {
            string conncectionString = @"Data Source=DESKTOP-R82RENG\SQLEXPRESS;Initial Catalog=DocApp;Integrated Security=True;Connect Timeout=30";
            myConnection = new SqlConnection(conncectionString);
        }
        public void ConnectWithDB() {
            myConnection.Open();
        }
        public void CloseConnection() {
            myConnection.Close();
        }

        public SqlDataReader GetData(string query) {
            myCommand = new SqlCommand(query,myConnection);
            return myCommand.ExecuteReader();
        }

        public int ExecuteSQL(string query) {
            myCommand = new SqlCommand(query, myConnection);
            return myCommand.ExecuteNonQuery();
        }


    }
}
