using SolidLogg.Appenders;
using SolidLogg.Appenders.Contracts;
using SolidLogg.Core;
using SolidLogg.Core.Contracts;
using SolidLogg.Layouts;
using SolidLogg.Layouts.Contracts;
using SolidLogg.Loggers;
using SolidLogg.Loggers.Contracts;
using SolidLogg.Loggers.Enums;
using System;

namespace SolidLogg
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            IEngine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
