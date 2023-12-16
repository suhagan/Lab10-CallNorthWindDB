using System;
using Lab10_Call_NorthWindDB.Models;

namespace Lab10_Call_NorthWindDB.Functions;

public class customerList
{
        public static void ShowCustomersList(NorthwindContext context)
        {
            Console.WriteLine("Sort customer list by company name.");
            Console.Write("Press 'A' for ascending or 'D' for descending order: ");

            var sortOrder = Console.ReadLine();

            var customersQuery = context.Customers
                .Select(c => new
                {
                    c.CustomerId,
                    c.CompanyName,
                    c.Country,
                    c.Region,
                    c.Phone,
                    OrderCount = c.Orders.Count
                });

            var customers = sortOrder.ToUpper() == "A"
                ? customersQuery.OrderBy(c => c.CompanyName).ToList()
                : customersQuery.OrderByDescending(c => c.CompanyName).ToList();

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer's ID: {customer.CustomerId} " + $"Company: {customer.CompanyName} " + $"Country: {customer.Country} " +
                                  $"Region: {customer.Region} " + $"Phone: {customer.Phone} " +
                                  $"Orders: {customer.OrderCount}");
            }
        }
}

