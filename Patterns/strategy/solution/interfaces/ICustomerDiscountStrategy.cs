using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solution.interfaces
{
    public interface ICustomerDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount);
    }
}