using SolidLogg.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLogg.Layouts.Factory.Contracts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
   
    }
}
