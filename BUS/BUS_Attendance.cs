using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class BUS_Attendance
    {
        public bool insertData(DTO.DTO_Attendance attd)
        {
            return new DAL.DAL_Attendance().insertData(attd);
        }
        public bool updateData(DTO.DTO_Attendance attd)
        {
            return new DAL.DAL_Attendance().updateData(attd);
        }
        public bool deleteData(string attdID)
        {
            return new DAL.DAL_Attendance().deleteData(attdID);
        }
    }
}
