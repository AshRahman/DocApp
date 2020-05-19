using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SignUpRepo: ISignUpRepo
    {
        DatabaseConnectionClass dcc;

        public SignUpRepo() {
            dcc = new DatabaseConnectionClass();
        }

        public bool InsertUser(User user) {
            string query = "INSERT into Actors VALUES('" + user.UserPass + "','" + user.UserName + "','" + user.UserEmail + "','" + user.PhnNumber + "','1')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp) { return false; }


        }
    }
}
