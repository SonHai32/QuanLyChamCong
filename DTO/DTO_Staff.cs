using System;

namespace DTO
{
    public class DTO_Staff
    {
        private string staffName;
        private string staffID;
        private string staffPhoneNumber;
        private string staffGender;
        private string officeID;
        private string staffAddress;
        private string staffFingerprint;

        public DTO_Staff(string staffName, string staffID, string staffPhoneNumber, string staffGender, string officeID, string staffAddress, string staffFingerprint)
        {
            this.staffName = staffName;
            this.staffID = staffID;
            this.staffPhoneNumber = staffPhoneNumber;
            this.staffGender = staffGender;
            this.officeID = officeID;
            this.staffAddress = staffAddress;
            this.staffFingerprint = staffFingerprint;
        }

        public string StaffName { get => staffName; set => staffName = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public string StaffPhoneNumber { get => staffPhoneNumber; set => staffPhoneNumber = value; }
        public string StaffGender { get => staffGender; set => staffGender = value; }
        public string OfficeID { get => officeID; set => officeID = value; }
        public string StaffAddress { get => staffAddress; set => staffAddress = value; }
        public string StaffFingerprint { get => staffFingerprint; set => staffFingerprint = value; }
    }


}
