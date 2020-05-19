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
    public class UserRepo : IUserRepo
    {
        DatabaseConnectionClass dcc;
        

        public UserRepo()
        {
            dcc = new DatabaseConnectionClass();
        }

        public List<Doctor> GetDoctors()
        {
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


        public bool InsertDoctor(Doctor doc) {

            string query = "INSERT into Doctor VALUES('" + doc.DocName + "','" + doc.DocEmail + "','" + doc.Specialist + "','" + doc.Time + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp) { return false; }

        }
        public bool DeleteDoctor(Doctor doc) {
            string query = "DELETE from Doctor WHERE Did='"+doc.DocId+"'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp) {
                return false;
            }
        
        }

        public Doctor GetDoctor(Doctor Did) {
            Doctor doc = null;
            string query = "SELECT * from Doctor WHERE Did ='"+Did+"'";
            dcc.CloseConnection();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read()) {
                doc = new Doctor();
                doc.DocId = Did.ToString();
                doc.DocName = sdr["Dname"].ToString();
                doc.DocEmail = sdr["Demail"].ToString();
                doc.Specialist = sdr["Speciality"].ToString();
                doc.Time = sdr["Time"].ToString();
            }
            dcc.CloseConnection();
            return doc;


        }
        public bool InsertUser(User user)
        {
            string query = "INSERT into Actors VALUES('" + user.UserPass + "','" + user.UserName + "','" + user.UserEmail + "','" + user.PhnNumber + "','0')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp) { return false; }


        }
        public bool DeleteUser(User user) 
        {
            string query = "DELETE from Actors where Aid='" + user.UserId + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.ExecuteSQL(query);
                dcc.CloseConnection();
                return true;

            }
            catch (Exception exp) {
                return false;
            }
        }
        public User GetUser(User userId) {
            User user = null;
            string query ="SELECT * from Actors WHERE Aid='"+userId+"'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                user = new User();
                user.UserId = userId.ToString();
                user.UserPass = sdr["Apass"].ToString();
                user.UserName = sdr["Aname"].ToString();
                user.UserEmail = sdr["Aemail"].ToString();
                user.PhnNumber = sdr["Aphone"].ToString();
                user.IsAdmin = Convert.ToInt32(sdr["IsAdmin"]);
            
            }
            dcc.CloseConnection();
            return user;
        }
        public List<User> GetUsers()
        {
            List<User> listofUsers = new List<User>();
            string query = "SELECT * FROM Actors";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                User user = new User();
                user.UserId = sdr["Aid"].ToString();
                user.UserName = sdr["Aname"].ToString();
                user.UserPass = sdr["Apass"].ToString();
                user.UserEmail = sdr["Aemail"].ToString();
                user.PhnNumber = sdr["Aphone"].ToString();
                user.IsAdmin = Convert.ToInt32(sdr["IsAdmin"]);
                listofUsers.Add(user);

            }
            dcc.CloseConnection();
            return listofUsers;
        }





    }
}
