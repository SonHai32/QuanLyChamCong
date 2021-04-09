using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class BUS_Department
    {
        public bool insertData(DTO.DTO_Department dept)
        {
            return new DAL.DAL_Department().insertData(dept);
        }
        public bool updateData(DTO.DTO_Department dept)
        {
            return new DAL.DAL_Department().updateData(dept);
        }
        public bool deleteData(string deptID)
        {
            return new DAL.DAL_Department().deleteData(deptID);
        }
    }
}
