using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Creators
{
    interface ILight
    {
        Product Create(double productCost);
    }
}
