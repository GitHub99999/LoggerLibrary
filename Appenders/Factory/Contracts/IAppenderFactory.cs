using SolidLogg.Appenders.Contracts;
using SolidLogg.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLogg.Appenders.Factory.Contracts
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
