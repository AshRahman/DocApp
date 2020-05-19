using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public  interface ILoginRepo
    { 
        Login GetUser(string email,string password);

        

    }
}
