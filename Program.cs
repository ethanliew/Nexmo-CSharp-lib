using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logging;

namespace Nexmo_CSharp_lib
{
    class Program
    {
        protected static ILog Log = LogManager.GetLogger(typeof(Program));


        static void Main(string[] args)
        {
            Log.Info("::Nexmo::");
            Log.Info("Logging Test");
            Console.ReadLine();
        }
    }
}
