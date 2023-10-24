using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Implementation.Interfaces
{
    //Implement this interface for each discount type
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double price);
    }
}
