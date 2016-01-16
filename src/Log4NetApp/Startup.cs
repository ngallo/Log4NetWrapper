using System;
using System.Reflection;
using Log4NetWrapper;

namespace Log4NetApp
{
    public class Startup
    {
        //Fields

        private readonly ILogger _logger;

        //Constructors

        public Startup(ILoggerFactory logFactory)
        {
            if (logFactory == null)
            {
                throw new ArgumentNullException();
            }
            _logger = logFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        }

        //Methods

        public void Start()
        {
            _logger.Debug("This is my debug message...");
            _logger.Warn("This is my warn message...");
            _logger.Error("This is my error message...");
            _logger.Fatal("This is my fatal message...");
        }
    }
}
