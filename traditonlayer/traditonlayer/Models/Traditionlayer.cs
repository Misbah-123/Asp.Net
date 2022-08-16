using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace traditonlayer.Models
{
    public class Traditionlayer
    {
        public IEnumerable<Teachers> Teachers
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
                List<Teachers> teachers = new List<Teachers>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    SqlCommand command = new SqlCommand("select * from info ", con);
                    con.Open();
                    SqlDataReader dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Teachers teacher = new Teachers();

                        teacher.Id = Convert.ToInt32(dataReader["Id"]);
                        teacher.name = dataReader["Name"].ToString();
                        teacher.des = dataReader["Des"].ToString();
                        teacher.salary = Convert.ToInt32(dataReader["Salary"]);
                        teachers.Add(teacher);


                    }
                }

                return teachers;



            }



        }
    }
}