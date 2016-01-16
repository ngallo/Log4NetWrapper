using System;

namespace Log4NetWrapper
{
    public interface ILoggerFactory
    {
        //Methods

        ILogger GetLogger(Type type);
    }
}
