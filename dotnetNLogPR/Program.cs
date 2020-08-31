using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetNLogPR
{
    class Program
    {
        //Trace Debug Info Warn Error Fatal
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
                Logger.Trace("Hello world Trace");
                Logger.Debug("Hello world Debug");
                Logger.Info("Hello world Info");
                Logger.Warn("Hello world Warn");
                Logger.Error("Hello world Error");
                Logger.Fatal("Hello world Fatal");
                Console.ReadKey();
          
        }
    }
}
