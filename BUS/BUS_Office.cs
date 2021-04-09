using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Office
    {
        public bool insertData(DTO.DTO_Office office)
        {
            return new DAL.DAL_Office().insertData(office);
        }
        public bool updateData(DTO.DTO_Office office)
        {
            return new DAL.DAL_Office().updateData(office);
        }
        public bool deleteData(string offID)
        {
            return new DAL.DAL_Office().deleteData(offID);
        }
    }
}
