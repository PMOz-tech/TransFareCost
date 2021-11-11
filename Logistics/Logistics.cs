using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
   public class Logistics : Transport
    {
        public int LogId { get; set; }
        public string ReceiverName { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }

        public string ReceiverAddress { get; set; }

       


       public double GetLogCost()
        {
            var cost = new LogPayroll();
            cost.LogCost = 2000;
            return cost.LogCost;
        }
    }
}
