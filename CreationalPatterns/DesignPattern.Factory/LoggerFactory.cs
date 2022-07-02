using DesignPattern.Factory.Models;

namespace DesignPattern.Factory
{
    internal class LoggerFactory
    {
        public static ILogger CreateLogger(LoggerType loggerType)
        {
            ILogger logger;
            switch (loggerType)
            {
                case LoggerType.Console:
                    logger = new ConsoleLogger();
                    break;
                case LoggerType.File:
                    logger = new FileLogger();
                    break;
                case LoggerType.Database:
                    logger = new DataBaseLogger();
                    break;
                default:
                    logger = new ConsoleLogger();
                    break;
            }
            return logger;
        }
    }
}
