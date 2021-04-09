using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class BUS_FingerPrint
    {
        public bool insertData(DTO.DTO_FingerPrint fing)
        {
            return new DAL.DAL_FingerPrint().insertData(fing);
        }
        public bool updateData(DTO.DTO_FingerPrint fing)
        {
            return new DAL.DAL_FingerPrint().updateData(fing);
        }
        public bool deleteData(string fingID)
        {
            return new DAL.DAL_FingerPrint().deleteData(fingID);
        }
    }
}
