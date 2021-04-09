using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_FingerPrint
    {
        private SqlCommand getCommand(string commandText)
        {
            SqlConnection con = DAL.DAL_DB_Connect.connection;
            return  new SqlCommand(commandText, con);
        }
        public bool insertData(DTO.DTO_FingerPrint fing)
        {
            try
            {
                SqlCommand command = getCommand("insertFinger");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@fingID", System.Data.SqlDbType.VarChar).Value = fing.FigID;
                command.Parameters.Add("@staffID", System.Data.SqlDbType.VarChar).Value = fing.StaffID;
                command.Parameters.Add("@finger", System.Data.SqlDbType.VarChar).Value = fing.FingerPrint;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool updateData(DTO.DTO_FingerPrint fing)
        {
            try
            {
                SqlCommand command = getCommand("updateFinger");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@fingID", System.Data.SqlDbType.VarChar).Value = fing.FigID;
                command.Parameters.Add("@staffID", System.Data.SqlDbType.VarChar).Value = fing.StaffID;
                command.Parameters.Add("@finger", System.Data.SqlDbType.VarChar).Value = fing.FingerPrint;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteData(string fingID)
        {
            try
            {
                SqlCommand command = getCommand("DeleteFinger");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@fingID", System.Data.SqlDbType.VarChar).Value = fingID;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
