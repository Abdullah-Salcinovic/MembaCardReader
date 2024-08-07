﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.CodeReader
{
    static class SCN
    {

        public static List<int> BaudRates = new List<int>() {

                115200,
                1200,
                57600,
                2400,
                38400,
                4800,
                19200,
                9600,
                14400,

        };


        public static int ID_DELAY = 125;
        public static int SCAN_DELAY = 3000;
        public static int TYPE_DELAY = 250;

        public static string ID = "SCN_ID\0";
        public static string SCAN = "SCN_GET\0";
        public static string TYPE = "SCN_TYP\0";
        public static string RESPONSE = "SCN_ACK";

    }
}
