using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Appointment
    {
        private string appId;

        public string AppId {
            get { return appId; }
            set { appId = value; }
        }
        private string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }


        private string docId;

        public string DocId
        {
            get { return docId; }
            set { docId = value; }

        }

        private string docName;

        public string DocName
        {
            get { return docName; }
            set { docName = value; }
        }
        
        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string serial;

        public string Serial {
            get { return serial; }
            set { serial = value; }
        
        }




    }
}
