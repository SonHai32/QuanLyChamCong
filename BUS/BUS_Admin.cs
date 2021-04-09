using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class BUS_Admin
    {
        public DataTable login(DTO.DTO_Admin user)
        {
            return new DAL.DAL_Admin().login(user);
        }

        public bool changePassword(DTO.DTO_Admin user)
        {
            return new DAL.DAL_Admin().changeAdminPass(user);
        }
    }
}
