using Entity;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PatientRepo: IPatientRepo
    {
        DatabaseConnectionClass dcc;

        public PatientRepo() 
        {
            dcc = new DatabaseConnectionClass();
        }

        public List<Doctor> GetDoctors() {
            List<Doctor> listofDocs = new List<Doctor>();
            string query = "SELECT * FROM Doctor";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Doctor doc = new Doctor();
                doc.DocId = sdr["Did"].ToString();
                doc.DocName = sdr["Dname"].ToString();
                doc.DocEmail = sdr["Demail"].ToString();
                doc.Specialist = sdr["Speciality"].ToString();
                doc.Time = sdr["Time"].ToString();
                listofDocs.Add(doc);
                
            }
            dcc.CloseConnection();
            return listofDocs;
        
        }

        public bool MakeAppointment(Appointment app)
        {
            string query = "INSERT into Appointment VALUES('" + app.UserId + "','" + app.DocId + "','" + app.DocName + "','" + app.Time + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp) { return false; }


        }


        public List<Appointment> GetAppointments() {
            List<Appointment> listofapointments = new List<Appointment>();
            string query = "SELECT * FROM Appointment";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                Appointment app = new Appointment();
  
                app.UserId = sdr["Aid"].ToString();
                app.DocId = sdr["Did"].ToString();
                app.DocName = sdr["Dname"].ToString();
                app.Time = sdr["Time"].ToString();
                app.Serial = sdr["Serial"].ToString();
                listofapointments.Add(app);
            }
            dcc.CloseConnection();
            return listofapointments;
        
        }

    }
}
