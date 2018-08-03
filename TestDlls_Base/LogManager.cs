using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDlls_Base
{
    static public class LogManager
    {
        static LogManager()
        {
            Console.WriteLine("LogManager: static ctor");
        }
        public static ILogger Logger { get; set; } = null;
    }
}
