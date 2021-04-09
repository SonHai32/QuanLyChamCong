using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_DB_Connect
    {
        public static SqlConnection connection ;
        
        public static bool DatabaseConnect(DTO.DTO_SQL_Config DB_CONFIG)
        {
            try
            {
                connection = new SqlConnection(
                    "Data Source=" + DB_CONFIG.DB_NAME +
                    "; Initial Catalog=" + DB_CONFIG.DB_NAME +
                    "; User Id=" + DB_CONFIG.DB_USER +
                    "; Password=" + DB_CONFIG.DB_PASS);

                connection.Open();
                return true;
            }catch
            {
                return false;
            }
            
        }

        public static bool DatabaseClose()
        {
            try
            {
                connection.Close();
                return true;
            }catch
            {
                return false; 
            }
        }

    }
}
