using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces;

namespace solution.strategies
{
    public class CouponDiscountStrategy : ICustomerDiscountStrategy
    {
        public decimal CalculateDiscount(decimal totalAmount)
        {
            return totalAmount * 0.2m; // 20% discount for customers with a coupon
        }
    }
}