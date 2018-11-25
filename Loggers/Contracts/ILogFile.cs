using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLogg.Loggers.Contracts
{
    public interface ILogFile
    {
        void Write(string message);

        int Size { get; }
    }
}
