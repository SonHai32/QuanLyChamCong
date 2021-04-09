using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient; 
using DTO;
namespace DAL
{
    public class DAL_Department
    {
        private SqlCommand getCommand(string commandText)
        {
            SqlConnection con = DAL.DAL_DB_Connect.connection;
            return  new SqlCommand(commandText, con);
        }
        public bool insertData(DTO.DTO_Department dept)
        {
            try
            {
                SqlCommand command = getCommand("insertDept");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@deptID", System.Data.SqlDbType.VarChar).Value = dept.DeptID;
                command.Parameters.Add("@deptName", System.Data.SqlDbType.NVarChar).Value = dept.DeptName;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }

        public bool updateData(DTO.DTO_Department dept)
        {
            try
            {
                SqlCommand command = getCommand("updateDept");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@deptID", System.Data.SqlDbType.VarChar).Value = dept.DeptID;
                command.Parameters.Add("@deptName", System.Data.SqlDbType.NVarChar).Value = dept.DeptName;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteData(string deptID)
        {
            try
            {
                SqlCommand command = getCommand("deleteDept");
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@deptID", System.Data.SqlDbType.VarChar).Value = deptID;

                return command.ExecuteNonQuery() >= 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
