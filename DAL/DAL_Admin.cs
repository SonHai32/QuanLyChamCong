using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
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
        public DataTable login(DTO.DTO_Admin user)
        {

            DataTable datatable = new DataTable();
            try
            {
                SqlCommand command = getCommand("adminLogin");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter sda = new SqlDataAdapter(command);

                sda.Fill(datatable);
                return datatable;
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
