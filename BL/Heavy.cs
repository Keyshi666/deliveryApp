using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    class Heavy:Product
    {
        public double weight;
        public Heavy(double productCost, double weight) : base(productCost) 
        { 
            this.weight = weight;
        }

        public override double GetDeliveryCost(string destination)
        {
            return base.GetDeliveryCost(destination) + this.weight * 0.2;
        }
    }
}
