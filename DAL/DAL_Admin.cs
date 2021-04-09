using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_Admin
    {
        private SqlCommand getCommand(string commandText)
        {
            SqlConnection con = DAL.DAL_DB_Connect.connection;
            return  new SqlCommand(commandText, con);
        }
        public SqlDataReader login(DTO.DTO_Admin user)
        {
            try
            {
                SqlCommand command = getCommand("adminLogin");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("username", System.Data.SqlDbType.VarChar).Value = user.UserName;
                command.Parameters.Add("password", System.Data.SqlDbType.VarChar).Value = user.UserPass;

                return command.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }
        public bool changeAdminPass(DTO.DTO_Admin user)
        {
            try
            {
                SqlCommand command = getCommand("adminChangePass");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("userID", System.Data.SqlDbType.VarChar).Value = user.UserID;
                command.Parameters.Add("newPassword", System.Data.SqlDbType.VarChar).Value = user.UserPass;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
