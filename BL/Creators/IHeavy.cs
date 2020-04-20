using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Creators
{
    interface IHeavy
    {
        Product Create(double productCost, double weight);    
    }
}
