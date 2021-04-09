using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_FingerPrint
    {
        private string figID;
        private string fingerPrint;
        private string staffID;

        public DTO_FingerPrint(string figID, string fingerPrint, string staffID)
        {
            this.FigID = figID;
            this.FingerPrint = fingerPrint;
            this.StaffID = staffID;
        }

        public string FigID { get => figID; set => figID = value; }
        public string FingerPrint { get => fingerPrint; set => fingerPrint = value; }
        public string StaffID { get => staffID; set => staffID = value; }
    }
}
