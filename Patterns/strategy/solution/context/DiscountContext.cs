using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using solution.interfaces;

namespace solution.context
{
    public class DiscountContext
    {
        private ICustomerDiscountStrategy _discountStrategy;
        public DiscountContext(ICustomerDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(ICustomerDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal ApplyDiscount(decimal totalAmount)
        {
            return _discountStrategy.CalculateDiscount(totalAmount);
        }
    }
}