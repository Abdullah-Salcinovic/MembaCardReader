using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.CodeReader
{
    public class COM_Scanner
    {
        public string? COM { get; set; }
        public string? DeviceName { get; set; }

        public override string ToString()
        {
            return $"{DeviceName} ({COM})";
        }

        public COM_Scanner(string name, string port)
        {
            this.COM = port;
            this.DeviceName = name;
        }

    }
}
