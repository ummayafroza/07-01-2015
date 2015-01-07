using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeInformationApp.DAL.DAO;

namespace EmployeeInformationApp.DAL.DBGetway
{
    public class DesignationDbGetway
    {
        //public Employee AEmployee = new Employee();
        private string connectionString =
            @"Data Source=LAB2\SQLEXPRESS; Database=EmployeeDatabase; Integrated Security=true";

        private SqlConnection connection;
        private SqlCommand command;

        public DesignationDbGetway()
        {
            connection = new SqlConnection(connectionString);
        }

        public void Save(Designation aDesignation)
        {
            string query = "INSERT INTO t_Designation VALUES('" + aDesignation.Code + "','" + aDesignation.Title + "')";
            connection.Open();
            SqlCommand commmand = new SqlCommand(query, connection);
            commmand.ExecuteNonQuery();
            connection.Close();
        }

        public Designation Find(string code)
        {
            string query = "SELECT * FROM t_Deisgnation WHERE code = '" + code + "'";
            connection.Open();
            command = new SqlCommand(query, connection);
            SqlDataReader aDataReader = command.ExecuteReader();
            Designation aDesignation;

            if (aDataReader.HasRows)
            {
                aDesignation = new Designation();
                aDataReader.Read();
                aDesignation.Id = Convert.ToInt32(aDataReader["id"]);
                aDesignation.Code = aDataReader["code"].ToString();
                aDesignation.Title = aDataReader["title"].ToString();
                aDataReader.Close();
                connection.Close();
                return aDesignation;
            }
            else
            {
                connection.Close();
                return null;
            }
        }

        /*public void  LoadComboBox()
       {
           List<Designation> aList = new List<Designation>();
           string connectionString = @"Data Source=LAB2\SQLEXPRESS; Database=EmployeeDatabase; Integrated Security=true";
           SqlConnection aSqlConnection = new SqlConnection(connectionString);
           aSqlConnection.Open();

           string query = "SELECT * FROM t_Designation";

           SqlCommand command = new SqlCommand(query, aSqlConnection);

           SqlDataReader reader = command.ExecuteReader();

           while (reader.Read())
           {
               Designation aDesignation = new Designation();
               aDesignation.Code = reader["code"].ToString();
;               aDesignation.Title = reader["title"].ToString();
               
               aList.Add(aDesignation);
           }

           reader.Close();
           aSqlConnection.Close();
           
           
           foreach (var desig in aList)
           {
              // .Items.Add(depart);
           }
       }*/
    }
}
