﻿using SolidLogg.Loggers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidLogg.Loggers
{
    public class LogFile : ILogFile
    {
        public int Size { get; private set; }

        public void Write(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}
