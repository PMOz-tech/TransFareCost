using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SolidPrinciple
{
   
        public class PremiumRider : Rider, IBaseFare, IDiscountFare
        {
            public double GetBaseFare()
            {
              var fares = new RideCost();
               fares.Fare = 25.00 * 4;
                return fares.Fare;
            }

            public double GetDiscountFare()
            {
                var farePrice = GetBaseFare();
                var discount = farePrice - 10.00;


                 return discount ;
            }

            
        }
    
}
