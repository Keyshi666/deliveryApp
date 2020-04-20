using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class Calculator
    {
        public double deliveryCost(Product product, string destination) 
        {
            return product.GetDeliveryCost(destination);
        }
    }
}
