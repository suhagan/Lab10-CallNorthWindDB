# About the task

Task is to download the northwind database and retrieve data from it using both entity framework and SQL.

# What have done

**C# & Entity Framework**
- [ ] Created a new console program in C#
- [ ] Connected the program to the northwind database using Entity framework
- [ ] Created a simple navigation in the program that allows the user to choose between the following functions:

    - [ ] Show the List of Customers: Show customer ID, company name, country, region, phone number and number of orders they have. List is sorted by company name. The user is able to choose ascending or descending order.    
    - [ ] Show Customer's Details: The user is able to select a customer from the list. All fields for the customer are displayed as well as a list of all orders the customer has made.
    - [ ] Add a New Customer: The user is able to add a customer and fill in values for all columns except the ID. ID is generated as a random string for (5 characters long). If the user does not fill in a value, ********null******** should be sent to the database, not an empty string.


**SQL : Management Studio (SSMS) (Query file)**
I have also written query file in SSMS for the following outputs or results:

- [ ] Select all customers and number of orders they made. Should be sorted descending by number of orders.
- [ ] Select all products with their name, price and category name. Should be sorted by category name and then product name
- [ ] Select all employees together with the territory they are in charge of (EmployeeTerritories and Territories tables)
