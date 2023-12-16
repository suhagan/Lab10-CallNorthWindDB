using System;
using Lab10_Call_NorthWindDB.Models;

namespace Lab10_Call_NorthWindDB.Functions;

public class customersDetails
{
    public static void ViewCustomersDetails(NorthwindContext context)
    {
        Console.Write("\t\tEnter the Customer's ID: ");
        var customerId = Console.ReadLine();

        var customerDetails = context.Customers
            .Where(c => c.CustomerId == customerId)
            .Select(c => new
            {
                c.CompanyName,
                c.ContactName,
                c.ContactTitle,
                c.Address,
                c.City,
                c.Region,
                c.PostalCode,
                c.Country,
                c.Phone,
                Orders = c.Orders.Select(o => new { o.OrderId, o.OrderDate, o.ShippedDate }).ToList()
            })
            .FirstOrDefault();

        if (customerDetails == null)
        {
            Console.WriteLine("Invalid Customer ID. Try again.");
            return;
        }

        Console.WriteLine($"Company: {customerDetails.CompanyName}");
        Console.WriteLine($"Contact: {customerDetails.ContactName}, {customerDetails.ContactTitle}");
        Console.WriteLine($"Address: {customerDetails.Address}");
        Console.WriteLine($"City: {customerDetails.City}, {customerDetails.Region}, {customerDetails.PostalCode}");
        Console.WriteLine($"Country: {customerDetails.Country}");
        Console.WriteLine($"Phone: {customerDetails.Phone}");
        Console.WriteLine("Orders:");

        foreach (var order in customerDetails.Orders)
        {
            Console.WriteLine($"  Order ID: {order.OrderId}, Order Date: {order.OrderDate}, Shipped Date: {(order.ShippedDate.HasValue ? order.ShippedDate.ToString() : "Not shipped yet")}");
        }
    }
}

