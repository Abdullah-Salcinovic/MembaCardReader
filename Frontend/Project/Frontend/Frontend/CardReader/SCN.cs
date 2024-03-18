using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.CardReader
{
    public static class SCN
    {       
        public static List<int>BaudRates = new List<int>(){

                9600,
                115200,
                4800,
                57600,
                2400,
                38400,
                1200,
                19200,
                14400,        
                           
        };

        public static int ID_DELAY = 100;
        public static int SCAN_DELAY = 5000;

        public static string ID = "SCN_ID\0";
        public static string SCAN = "SCN_CRD\0";

        public static string RESPONSE = "SCN_ACC";
    }
}
