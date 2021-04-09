using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO; 
namespace DAL
{
    public class DAL_Office
    {
        private SqlCommand getCommand(string commandText)
        {
            SqlConnection con = DAL.DAL_DB_Connect.connection;
            return  new SqlCommand(commandText, con);
        }
        public bool insertData(DTO.DTO_Office newOffice)
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

        public bool updateData(DTO.DTO_Office office)
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

        

        public bool deleteData(string officeID)
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
