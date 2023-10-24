using OCP.Implementation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation.Services
{
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;
        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
        public double CalculateDiscount(double price)
        {
            return _discountStrategy.CalculateDiscount(price);
        }
    }
}
