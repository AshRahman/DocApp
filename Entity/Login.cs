using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Login
    {
        
        private string id;

        public string Id {
            get { return id;}
            set { id = value; }
        }

        private string password;

        public string Password {
            get { return password; }
            set { password = value; }
        }

        private int isAdmin;

        public int IsAdmin {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
      


    }
}
