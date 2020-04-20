using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    class Express:Product
    {
        public double index = 2;
        public Express(double productCost, double index) : base(productCost) { }

        public override double GetDeliveryCost(string destination)
        {
            return base.GetDeliveryCost(destination) * this.index;
        }
    }
}
