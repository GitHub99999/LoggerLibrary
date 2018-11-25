

namespace SolidLogg.Appenders
{
    using Contracts;
    using SolidLogg.Layouts.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using SolidLogg.Loggers.Contracts;
    using SolidLogg.Loggers.Enums;

    public class FileAppender : Appender
    {
        private const string path = "file.txt";
        private readonly ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            :base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesCount++;
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message) + "\n";
                this.logFile.Write(content);
                File.AppendAllText(path, content);
            }  
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.ReportLevel.ToString().ToUpper()}," +
                $" Messages appended: {this.MessagesCount}, File size: {this.logFile.Size}";
        }
    }
}
