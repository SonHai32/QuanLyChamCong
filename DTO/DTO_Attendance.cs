using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Attendance
    {
        private string attdID;
        private string attdDate;
        private string staffID;
        private string attdCount;
        private string fingerSprintID;

        public DTO_Attendance(string attdID, string attdDate, string staffID, string attdCount, string fingerSprintID)
        {
            this.AttdID = attdID;
            this.AttdDate = attdDate;
            this.StaffID = staffID;
            this.AttdCount = attdCount;
            this.FingerSprintID = fingerSprintID;
        }

        public string AttdID { get => attdID; set => attdID = value; }
        public string AttdDate { get => attdDate; set => attdDate = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public string AttdCount { get => attdCount; set => attdCount = value; }
        public string FingerSprintID { get => fingerSprintID; set => fingerSprintID = value; }
    }
}
