using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDlls_Base
{
    public class ConsoleLogger : ILogger
    {

        public void Write(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        public void Reset()
        {
            Console.WriteLine($"Reset!");
        }
    }
}
