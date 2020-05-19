using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LoginRepo:ILoginRepo
    {
        DatabaseConnectionClass dcc;
        public LoginRepo() { dcc = new DatabaseConnectionClass(); }

        public Login GetUser(string id, string password) {
            Login log = null;
            string query ="SELECT * from Actors WHERE Aid =  '" +id + "' AND Apass ='" + password + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                log = new Login();
                log.Id = sdr["Aid"].ToString();
                log.Password = sdr["Apass"].ToString();
                log.IsAdmin = Convert.ToInt32(sdr["IsAdmin"]);

            }
            dcc.CloseConnection();
            return log;
        }
    }
}
