using System;

using Lab10_Call_NorthWindDB.Models;
using Lab10_Call_NorthWindDB.Functions;

namespace Lab10_Call_NorthWindDB;
class Program
{
    static void Main(string[] args)
    {
          char userInput;
            using (var context = new NorthwindContext())
            {
                while (true)
                {
                    Console.WriteLine("Welcome to database access and data retrieve lab session.");
                    Console.WriteLine("Please choose your option below: (press l, d, n, e to navigate the menu.)");
                    Console.WriteLine("\t\t(l) Show the List of Customers");
                    Console.WriteLine("\t\t(d) Show Customer's Details");
                    Console.WriteLine("\t\t(n) Add a new customer");
                    Console.WriteLine("\t\t(e) Exit");
                    Console.Write("\nEnter your choice: ");
                    switch (Console.ReadLine())
                    {
                        case "l":
                            customerList.ShowCustomersList(context);
                            break;
                        case "d":
                            customersDetails.ViewCustomersDetails(context);
                            break;
                        case "n":
                            addCustomer.AddnewCustomers(context);
                            break;
                        case "e":
                            Environment.Exit(0); // 0 indicates a successful exit
                            break;
                                
                        default:
                            Console.WriteLine("Invalid option, try again.");
                            break;
                    }
                }
            }
        
    }
}

