using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    class Light:Product
    {

        public Light(double productCost) : base(productCost) { }

        public override double GetDeliveryCost(string destination)
        {
            return base.GetDeliveryCost(destination);
        }
        
    }
}
