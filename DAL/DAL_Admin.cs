using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
<<<<<<< HEAD
using System.Data;
=======
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
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
<<<<<<< HEAD
        public DataTable login(DTO.DTO_Admin user)
        {

            DataTable datatable = new DataTable();
=======
        public SqlDataReader login(DTO.DTO_Admin user)
        {
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
            try
            {
                SqlCommand command = getCommand("adminLogin");
                command.CommandType = System.Data.CommandType.StoredProcedure;

<<<<<<< HEAD
                SqlDataAdapter sda = new SqlDataAdapter(command);

                sda.Fill(datatable);
                return datatable;
=======
                command.Parameters.Add("username", System.Data.SqlDbType.VarChar).Value = user.UserName;
                command.Parameters.Add("password", System.Data.SqlDbType.VarChar).Value = user.UserPass;

                return command.ExecuteReader();
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
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
