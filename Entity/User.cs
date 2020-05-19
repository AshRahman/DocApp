using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class User
    {
        private string userId;

        public string UserId {
            get { return userId; }
            set { userId = value; }
        }
        
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

      
        private string userEmail;

        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }

        private string phnNumber;

        public string PhnNumber
        {
            get { return phnNumber; }
            set { phnNumber = value; }
        }


        private string userPass;

        public string UserPass {
            get { return userPass; }
            set { userPass = value; }
        }

        private int isAdmin;

        public int IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }



    }
}
