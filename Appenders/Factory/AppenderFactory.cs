using SolidLogg.Appenders.Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using SolidLogg.Appenders.Contracts;
using SolidLogg.Layouts.Contracts;
using SolidLogg.Loggers;

namespace SolidLogg.Appenders.Factory
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeAsLowerCase = type.ToLower();

            switch (typeAsLowerCase)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
