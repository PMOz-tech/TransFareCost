using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
   public class Transport
    {
        public  enum TypeTransport { 
            Rider,
            Logistics
        } 

       public  void SelectChoice()
       {
            var choice = new TypeTransport();


            
            if(choice is TypeTransport.Rider)
            {
                var w = new RideCost();
               
                
            }
       }   
    }
}
