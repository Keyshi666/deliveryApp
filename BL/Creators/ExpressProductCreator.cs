using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Creators
{
    public class ExpressProductCreator:IExpress
    {
        public Product Create(double productCost, double index) 
        {
            return new Express(productCost, index);
        }
    }
}
