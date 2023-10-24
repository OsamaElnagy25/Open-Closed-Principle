using OCP.Implementation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation.Services
{
    public class NewbieDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.05;
        }
    }
}
