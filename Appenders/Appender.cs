using SolidLogg.Appenders.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using SolidLogg.Loggers.Enums;
using SolidLogg.Layouts.Contracts;

namespace SolidLogg.Appenders
{
    public abstract class Appender : IAppender
    {
        private readonly ILayout layout;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
        }

        protected ILayout Layout => this.layout;

        public ReportLevel ReportLevel { get; set; }

        public int MessagesCount { get; protected set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        

    }
}
