using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUserRepo
    {
        bool DeleteDoctor(Doctor doc);
        Doctor GetDoctor(Doctor Did);
        bool InsertDoctor(Doctor doc);
        List<Doctor> GetDoctors();
        bool InsertUser(User user);
        User GetUser(User user);
        bool DeleteUser(User user);
        
        
    }
}
