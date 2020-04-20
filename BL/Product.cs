using System;
using System.Collections.Generic;

namespace BL
{
    public abstract class Product
    {
        public Dictionary<string, double> destinations;
        public double productCost;
    
        public Product(double productCost) 
        {
            this.productCost = productCost;
            this.destinations = new Dictionary<string, double>(3);
            this.destinations.Add("Столичный город", 100);
            this.destinations.Add("Обычный город", 150);
            this.destinations.Add("Районный населенный пункт", 300);
        }

        public virtual double GetDeliveryCost(string destination) 
        {
            double deliveryCost;
            this.destinations.TryGetValue(destination, out deliveryCost);
            return this.productCost + deliveryCost;
        }
    }

    
}
