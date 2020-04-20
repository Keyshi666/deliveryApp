using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Creators
{
    interface IExpress
    {
        Product Create(double productCost, double index);
    }
}
