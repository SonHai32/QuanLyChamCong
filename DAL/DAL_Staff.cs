using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
<<<<<<< HEAD
    public class DAL_Staff
    {
        SqlConnection con = DAL.DAL_DB_Connect.connection;
        
        public bool insertData(DTO.DTO_Staff staff)
=======
    class DAL_Staff
    {
        SqlConnection con = DAL.DAL_DB_Connect.connection;
        
        public bool InsertStaffData(DTO.DTO_Staff staff)
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_addStaff", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@staffID", SqlDbType.VarChar).Value = staff.StaffID;
                command.Parameters.Add("@staffName", SqlDbType.VarChar).Value = staff.StaffName;
                command.Parameters.Add("@staffGender", SqlDbType.VarChar).Value = staff.StaffGender;
                command.Parameters.Add("@staffFingerprint", SqlDbType.VarChar).Value = staff.StaffFingerprint;
                command.Parameters.Add("@staffAddress", SqlDbType.VarChar).Value = staff.StaffAddress;
                command.Parameters.Add("@staffPhoneNumber", SqlDbType.VarChar).Value = staff.StaffPhoneNumber;
                command.Parameters.Add("@staffOfficeID", SqlDbType.VarChar).Value = staff.OfficeID;

                int result = command.ExecuteNonQuery();
                command.Parameters.Clear();
                return result >= 0;
            }
            catch
            {
                return false;
            }
        }

<<<<<<< HEAD
        public bool updateData(DTO.DTO_Staff staff)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_updateStaff", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@staffID", SqlDbType.VarChar).Value = staff.StaffID;
                command.Parameters.Add("@staffName", SqlDbType.VarChar).Value = staff.StaffName;
                command.Parameters.Add("@staffGender", SqlDbType.VarChar).Value = staff.StaffGender;
                command.Parameters.Add("@staffFingerprint", SqlDbType.VarChar).Value = staff.StaffFingerprint;
                command.Parameters.Add("@staffAddress", SqlDbType.VarChar).Value = staff.StaffAddress;
                command.Parameters.Add("@staffPhoneNumber", SqlDbType.VarChar).Value = staff.StaffPhoneNumber;
                command.Parameters.Add("@staffOfficeID", SqlDbType.VarChar).Value = staff.OfficeID;

                int result = command.ExecuteNonQuery();
                command.Parameters.Clear();
                return result >= 0;
            }
            catch
            {
                return false;
            }
        }
=======
>>>>>>> ddb07760feef69e7a82cd2372d5dad16c9fc6145
        public bool DeleteStaffData(string staffID)
        {
            try
            {
                SqlCommand command = new SqlCommand("pr_delStaff", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@staffID", SqlDbType.VarChar).Value = staffID;
                int result = command.ExecuteNonQuery();

                return result >= 0;
            }
            catch
            {
                return false;
            }

        }
    }
}
