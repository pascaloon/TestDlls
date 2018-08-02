using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestDlls_Base;
using TestDlls_DependencyA;
using TestDlls_DependencyB;

namespace TestDlls_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            SetupLogger();

            TestWorkers();

            FindLoggerInstances();

            TestWorkers();

            Console.ReadLine();
        }

        private static void FindLoggerInstances()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            

            foreach (var assembly in assemblies)
            {
                LogManager.Logger.Write($"Looking at assembly: {assembly.FullName}.");
                Type logManager = assembly.GetType(typeof(LogManager).FullName);
                if (logManager == null)
                    continue;
                LogManager.Logger.Write($"\tLooking at type: {logManager.FullName}.");
                PropertyInfo loggerProperty = logManager.GetProperty("Logger");
                if (loggerProperty == null)
                    continue;
                LogManager.Logger.Write($"\tLooking at property: {loggerProperty.Name}.");
                loggerProperty.SetValue(null, new DumbLogger());

            }
        }

        private static void TestWorkers()
        {
            AbstractWorker WA = new WorkerA();
            AbstractWorker WB = new WorkerB();

            WA.Work();
            WB.Work();
        }

        private static void SetupLogger()
        {
            LogManager.Logger = new ConsoleLogger();
        }
    }
}