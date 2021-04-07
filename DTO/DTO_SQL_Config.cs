using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_SQL_Config
    {

        public DTO_SQL_Config(string sV_NAME, string dB_NAME, string dB_USER, string dB_PASS)
        {
            SV_NAME = sV_NAME;
            DB_NAME = dB_NAME;
            DB_USER = dB_USER;
            DB_PASS = dB_PASS;
        }

        public string SV_NAME{ get => SV_NAME; set => SV_NAME = value; }
        public string DB_NAME { get => DB_NAME; set => DB_NAME = value; }
        public string DB_USER { get => DB_USER; set => DB_USER = value; }
        public string DB_PASS { get => DB_PASS; set => DB_PASS = value; }
    }
}
