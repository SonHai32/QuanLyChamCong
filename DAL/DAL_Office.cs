using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO; 
namespace DAL
{
<<<<<<< HEAD
    public class DAL_Office
=======
    class DAL_Office
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
    {
        private SqlCommand getCommand(string commandText)
        {
            SqlConnection con = DAL.DAL_DB_Connect.connection;
            return  new SqlCommand(commandText, con);
        }
<<<<<<< HEAD
        public bool insertData(DTO.DTO_Office newOffice)
=======
        public bool insertOffice(DTO.DTO_Office newOffice)
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
        {
            try
            {
                SqlConnection con = DAL.DAL_DB_Connect.connection;
                SqlCommand command = new SqlCommand("insertOffice", con);

                command.Parameters.Add("@officeID", System.Data.SqlDbType.VarChar).Value = newOffice.OfficeID;
                command.Parameters.Add("@officeName", System.Data.SqlDbType.VarChar).Value = newOffice.OfficeName;
                command.CommandType = System.Data.CommandType.StoredProcedure;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }

<<<<<<< HEAD
        public bool updateData(DTO.DTO_Office office)
=======
        public bool updateOffice(DTO.DTO_Office office)
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
        {
            try
            {

                SqlCommand command = getCommand("updateOffice");
                command.Parameters.Add("@officeID", System.Data.SqlDbType.VarChar).Value = office.OfficeID;
                command.Parameters.Add("@officeName", System.Data.SqlDbType.VarChar).Value = office.OfficeName;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }

        

<<<<<<< HEAD
        public bool deleteData(string officeID)
=======
        public bool deleteOffice(string officeID)
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
        {
            try
            {
                SqlCommand command = getCommand("deleteOffice");
                command.Parameters.Add("@officeID", System.Data.SqlDbType.VarChar).Value = officeID;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
