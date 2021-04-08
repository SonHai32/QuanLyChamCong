using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO; 
namespace DAL
{
    class DAL_Office
    {

        public bool insertOffice(DTO.DTO_Office newOffice)
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

        public bool updateOffice(DTO.DTO_Office office)
        {
            try
            {
              
                SqlConnection con = DAL.DAL_DB_Connect.connection;
                SqlCommand command = new SqlCommand("updateOffice", con);

                command.Parameters.Add("@officeID", System.Data.SqlDbType.VarChar).Value = office.OfficeID;
                command.Parameters.Add("@officeName", System.Data.SqlDbType.VarChar).Value = office.OfficeName;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
