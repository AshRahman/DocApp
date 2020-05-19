using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public  class Doctor
    {

        private string docId;

        public string DocId {
            get { return docId; }
            set { docId = value; }
            
        }

        private string docName;

        public string DocName {
            get { return docName; }
            set { docName = value; }       
        }
        private string docEmail;

        public string DocEmail {
            get { return docEmail; }
            set { docEmail = value; }
        }

        private string specialist;

        public string Specialist {
            get { return specialist; }
            set { specialist = value; }
        }
        private string time;

        public string Time {
            get { return time; }
            set { time = value; }
        }
        

    }
}
