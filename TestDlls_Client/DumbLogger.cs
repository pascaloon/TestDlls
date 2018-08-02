using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDlls_Base;

namespace TestDlls_Client
{
    class DumbLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine($"Dumb Log: {message}");
        }
    }
}
