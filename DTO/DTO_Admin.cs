using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Admin
    {
        private string userID;
        private string userName;
        private string userPass;

        public DTO_Admin(string userID, string userName, string userPass)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.UserPass = userPass;
        }

        public string UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPass { get => userPass; set => userPass = value; }
    }
}
