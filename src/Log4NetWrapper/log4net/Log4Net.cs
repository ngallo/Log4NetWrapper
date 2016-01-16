using System;
using log4net;

namespace Log4NetWrapper.log4net
{
    public class Log4Net : ILogger
    {
        //Fields

        private readonly ILog _log;

        //Constructors

        public Log4Net(ILog log)
        {
            if (ReferenceEquals(log, null))
            {
                throw new ArgumentNullException();
            }
            _log = log;
        }

        //Methods

        public void Debug(string message, params object[] args)
        {
            if (!ReferenceEquals(args, null))
            {
                message = string.Format(message, args);
            }
            _log.Debug(message);
        }

        public void Debug(string message, Exception exception)
        {
            _log.Debug(message, exception);
        }

        public void Info(string message, params object[] args)
        {
            if (!ReferenceEquals(args, null))
            {
                message = string.Format(message, args);
            }
            _log.Info(message);
        }

        public void Info(string message, Exception exception)
        {
            _log.Info(message, exception);
        }

        public void Warn(string message, params object[] args)
        {
            if (!ReferenceEquals(args, null))
            {
                message = string.Format(message, args);
            }
            _log.Warn(message);
        }

        public void Warn(string message, Exception exception)
        {
            _log.Warn(message, exception);
        }

        public void Error(string message, params object[] args)
        {
            if (!ReferenceEquals(args, null))
            {
                message = string.Format(message, args);
            }
            _log.Error(message);
        }

        public void Error(string message, Exception exception)
        {
            _log.Error(message, exception);
        }

        public void Fatal(string message, params object[] args)
        {
            if (!ReferenceEquals(args, null))
            {
                message = string.Format(message, args);
            }
            _log.Fatal(message);
        }

        public void Fatal(string message, Exception exception)
        {
            _log.Fatal(message, exception);
        }
    }
}
