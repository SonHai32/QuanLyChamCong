using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Office
    {
        private string officeName;
        private string officeID;

        public DTO_Office(string officeName, string officeID)
        {
            this.OfficeName = officeName;
            this.OfficeID = officeID;
        }

        public string OfficeName { get => officeName; set => officeName = value; }
        public string OfficeID { get => officeID; set => officeID = value; }
    }
}
