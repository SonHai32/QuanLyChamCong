using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Department
    {
        private string deptID;
        private string deptName;

        public DTO_Department(string deptID, string deptName)
        {
            this.DeptID = deptID;
            this.DeptName = deptName;
        }

        public string DeptID { get => deptID; set => deptID = value; }
        public string DeptName { get => deptName; set => deptName = value; }
    }
}
