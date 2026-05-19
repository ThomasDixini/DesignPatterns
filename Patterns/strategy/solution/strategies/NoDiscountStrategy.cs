using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces;

namespace solution.strategies
{
    public class NoDiscountStrategy : ICustomerDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return 0m; // No discount
        }
    }
}