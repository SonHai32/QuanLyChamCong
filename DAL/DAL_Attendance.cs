using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Attendance
    {
        private SqlCommand getCommand(string commandText)
        {
            SqlConnection con = DAL.DAL_DB_Connect.connection;
            return  new SqlCommand(commandText, con);
        }

        public bool insertData(DTO.DTO_Attendance attd)
        {
            try
            {
                SqlCommand command = getCommand("insertAttendace");
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@attdID", System.Data.SqlDbType.VarChar).Value = attd.AttdID;
                command.Parameters.Add("@attdDate", System.Data.SqlDbType.VarChar).Value = attd.AttdDate;
                command.Parameters.Add("@staffID", System.Data.SqlDbType.VarChar).Value = attd.StaffID;
                command.Parameters.Add("@attdCount", System.Data.SqlDbType.VarChar).Value = attd.AttdCount;
                command.Parameters.Add("@fingerSprintID", System.Data.SqlDbType.VarChar).Value = attd.FingerSprintID;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }

        public bool updateData(DTO.DTO_Attendance attd)
        {
            try
            {
                SqlCommand command = getCommand("updateAttendace");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@attdID", System.Data.SqlDbType.VarChar).Value = attd.AttdID;
                command.Parameters.Add("@attdDate", System.Data.SqlDbType.VarChar).Value = attd.AttdDate;
                command.Parameters.Add("@staffID", System.Data.SqlDbType.VarChar).Value = attd.StaffID;
                command.Parameters.Add("@attdCount", System.Data.SqlDbType.VarChar).Value = attd.AttdCount;
                command.Parameters.Add("@fingerSprintID", System.Data.SqlDbType.VarChar).Value = attd.FingerSprintID;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteData(string attdID)
        {
            try
            {
                SqlCommand command = getCommand("deleteAttendace");
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@attdID", System.Data.SqlDbType.VarChar).Value = attdID;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }

        }
    }
}
