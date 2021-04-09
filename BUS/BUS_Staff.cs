using System;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Staff
    {
        public bool insertData(DTO.DTO_Staff staff)
        {
            return new DAL.DAL_Staff().insertData(staff);
        }
        public bool updateData(DTO.DTO_Staff staff)
        {
            return new DAL.DAL_Staff().updateData(staff);
        }
        public bool deleteData(string staffID)
        {
            return new DAL.DAL_Staff().DeleteStaffData(staffID);
        }
    }
}
