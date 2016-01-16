using System;
using Log4NetWrapper.log4net;

namespace Log4NetApp
{
    public class Program
    {
        //Methods

        private static void Main()
        {
            var loggerFactory = new Log4NetFactory();
            var startup = new Startup(loggerFactory);
            startup.Start();
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();
        }
    }
}
