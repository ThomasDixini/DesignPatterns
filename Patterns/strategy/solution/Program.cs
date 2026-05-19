// See https://aka.ms/new-console-template for more information
using solution.context;
using solution.strategies;

DiscountContext discountContext = new DiscountContext(new NoDiscountStrategy());
decimal totalAmount = 100m;
Console.WriteLine($"Total Amount: {totalAmount:C}");
Console.WriteLine($"Discount: {discountContext.ApplyDiscount(totalAmount):C}");

var loyaltyDiscountStrategy = new LoyaltyDiscountStrategy();
discountContext.SetDiscountStrategy(loyaltyDiscountStrategy);
Console.WriteLine($"Loyalty Discount: {discountContext.ApplyDiscount(totalAmount):C}");

var couponDiscountStrategy = new CouponDiscountStrategy();
discountContext.SetDiscountStrategy(couponDiscountStrategy);
Console.WriteLine($"Coupon Discount: {discountContext.ApplyDiscount(totalAmount):C}");
