using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
   public class RideCost
    {
        public List <Rider> eligibleRider {get; set;}
        public double Fare { get; set; }

        double GetTotalBaseFare(List<IBaseFare> baseFares)
        {
           

            var totalBaseFare = 0d;
            foreach(var rider in baseFares)
            {
                totalBaseFare += rider.GetBaseFare();
            }
            return totalBaseFare;
        }

        double GetTotalDiscountFare(List<IDiscountFare> discountFares)
        {
            var totalDiscountFare = 0d;
            foreach(var rider in discountFares)
            {
                totalDiscountFare += rider.GetDiscountFare();

            }
            return totalDiscountFare;
        }
        

    }

   

   

   


    
    

}
