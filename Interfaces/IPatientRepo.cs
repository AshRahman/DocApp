using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPatientRepo
    {
        List<Doctor> GetDoctors();
        List<Appointment> GetAppointments();
        bool MakeAppointment(Appointment app);

    }
}
