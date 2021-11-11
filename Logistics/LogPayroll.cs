using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
   public class LogPayroll
    {
        public List <Logistics> logDetails { get; set; }

        public double LogCost { get; set; }

        double GetTotalLogCost()
        {
            var log = new Logistics();
           var totalCost = log.GetLogCost();

            return totalCost;
             
        }
    }
}
