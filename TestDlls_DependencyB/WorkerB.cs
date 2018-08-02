using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDlls_Base;

namespace TestDlls_DependencyB
{
    public class WorkerB : AbstractWorker
    {
        public override void Work()
        {
            LogManager.Logger.Write("WorkerB: Working...");
        }
    }
}
