using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public class BasicRider : Rider, IBaseFare
    {
        public double GetBaseFare()
        {

            var fares = new RideCost();
            fares.Fare = 25.00 * 7;
            return fares.Fare;
        }
    }
}
