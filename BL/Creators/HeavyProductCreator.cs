using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Creators
{
    public class HeavyProductCreator:IHeavy
    {
        public Product Create(double productCost, double weight)
        {
            return new Heavy(productCost, weight);
        }
    }
}
