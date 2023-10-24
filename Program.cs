using OCP.Implementation.Services;
using System;
namespace OCP
{
    //Testing the Open-Closed Principle
    public class Program
    {
        public static void Main()
        {
            var regularDiscount = new RegularDiscount();
            var calculator = new DiscountCalculator(regularDiscount);
            double discountedPrice = calculator.CalculateDiscount(100); 
            Console.WriteLine(discountedPrice);         // 10% discount applied
            var premiumDiscount = new PremiumDiscount();
            calculator = new DiscountCalculator(premiumDiscount);
            discountedPrice = calculator.CalculateDiscount(100); 
            Console.WriteLine(discountedPrice);         // 30% discount applied
        }
    }
}