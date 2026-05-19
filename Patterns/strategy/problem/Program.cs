// See https://aka.ms/new-console-template for more information
using System;

if(args.Count() == 0 || string.IsNullOrEmpty(args[0])) throw new ArgumentException("No discount type provided");

var discountService = new DiscountService();
decimal totalAmount = 100m;

Console.WriteLine($"Total Amount: {totalAmount:C}");
Console.WriteLine($"Final Price: {discountService.ApplyDiscount(totalAmount, args[0]):C}");

public class DiscountService
{
    public decimal ApplyDiscount(decimal totalAmount, string discountType)
    {
        if(discountType == "none")
        {
            // No discount logic
            return totalAmount;
        }
        else if(discountType == "loyalty")
        {
            Console.WriteLine("Applying loyalty discount...");
            return totalAmount * 0.9m; // 10% discount
        }
        else if(discountType == "coupon")
        {
            Console.WriteLine("Applying coupon discount...");
            return totalAmount * 0.8m; // 20% discount
        }
        else if(discountType == "seasonal")
        {
            Console.WriteLine("Applying seasonal discount...");
            return totalAmount * 0.85m; // 15% discount
        }
        else
        {
            throw new ArgumentException($"Invalid discount type: {discountType}");
        }
    }
}
