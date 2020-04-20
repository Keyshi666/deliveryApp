using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Creators
{
    public class LightProductCreator:ILight
    {
        public Product Create(double productCost)
        {
            return new Light(productCost);
        }
    }
}
