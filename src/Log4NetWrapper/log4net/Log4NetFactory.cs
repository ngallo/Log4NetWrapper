using System;
using System.Collections.Generic;
using log4net;

namespace Log4NetWrapper.log4net
{
    public class Log4NetFactory : ILoggerFactory
    {
        //Constants

        public const string DefaultName = "Log4Net";

        //Fields

        private readonly Dictionary<string, ILog> _loggers = new Dictionary<string, ILog>();

        //Methods

        public ILogger GetLogger(Type type)
        {
            var name = (!ReferenceEquals(type, null)) ? type.AssemblyQualifiedName : DefaultName;

            if (ReferenceEquals(name, null)) return null;
            if (!_loggers.ContainsKey(name))
            {
                var newLog = LogManager.GetLogger(type);
                _loggers.Add(name, newLog);
            }
            var log = _loggers[name];
            var logger = new Log4Net(log);
            return logger;
        }

    }
}
