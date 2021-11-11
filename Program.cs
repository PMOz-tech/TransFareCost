
using System;

namespace SolidPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            PremiumRider john = new PremiumRider();
            Console.WriteLine($"You are a premium rider and you amount is {john.GetDiscountFare()}");

            BasicRider basic = new BasicRider();
            Console.WriteLine($"You are a basic rider and your amount is {basic.GetBaseFare()}");
        }
    }
}
