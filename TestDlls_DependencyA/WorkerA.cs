using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDlls_Base;

namespace TestDlls_DependencyA
{
    public class WorkerA : AbstractWorker
    {
        public override void Work()
        {
            LogManager.Logger.Write("WorkerA: Working...");
        }
    }
}
