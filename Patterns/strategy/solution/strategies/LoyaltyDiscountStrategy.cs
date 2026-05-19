using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces;

namespace solution.strategies
{
    public class LoyaltyDiscountStrategy : ICustomerDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.1m; // 10% discount for loyal customers
        }
    }
}