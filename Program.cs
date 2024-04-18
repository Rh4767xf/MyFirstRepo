namespace Module5Challenge
{
    class Program
    {
        //The main method is called when the program executes.
        public static void Main()
        {
            //The using keyword creates a block of limited scope and ensures that
            //When the click is exited, context.Dispose() is
            //called to close the database connection.
            using(var context = new NorthwindContext())
            {
                // Query the database to retrieve the customer with the ID BOTTM
                var customers = (from customer in context.Customers
                                 where customer.CustomerID.Equals("BOTTM")
                                 select customer).ToList();

                // Loop through the list of customers and display the customer ID and company
                foreach (var customer in customers)
                {
                    // The $ character before a string literal is used fo an
                    // interpolated string. This allows you to insert expressions
                    // directly into th string enclosed in {}
                    Console.WriteLine($"Customer ID: {customer.CustomerID}, Company Name: {customer.CompanyName}");
                }

                // Query the database to retrieve the customer with the specified phone number
                // using a lambda expression
                customers = context.Customers.Where(customer => customer.Phone.Equals("(206) 555-4112")).ToList();

                // Loop through the list of customers and display the customer ID and company name
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer ID: {customer.CustomerID}, Company Name: {customer.CompanyName}");
                }

                /*// Add a customer to the customers table
                // Create a new customer instance
                var newCustomer = new Customer
                {
                    CustomerID = "NEW01", //---------- Set the customer ID
                    CompanyName = "Anoka Grocery", //- Set the company name
                    ContactName = "Jose Garcia", //--- Set the contact name
                    ContactTitle = "SalesManager", //- Set the contact title
                    Address = "123 Main Street", //--- Set the address
                    City = "Anoka", //---------------- Set the city
                    Region = "MN", //----------------- Set the region
                    PostalCode = "55303", //---------- Set the postal code
                    Country = "USA", //--------------- Set the country
                    Phone = "(763) 555-5555", //------ Set the phone number
                    Fax = "(763) 555-5556" //--------- Set the fax number
                }; // End newCustomer

                // Add the new customer to the context
                context.Customers.Add(newCustomer);

                // Save changes to the database
                context.SaveChanges();
                Console.WriteLine($"New customer inserted successfully: {newCustomer.CompanyName}");*/

// Step 9 Optional
                /*// Query the database to retrieve all of the customers
                customers = context.Customers.ToList();

                // Loop through the list of customers
                foreach (var customer in customers)
                {
                    Console.WriteLine($"Customer ID: {customer.CustomerID}, Company Name: {customer.CompanyName}");
                }*/

                // Loop through the list of customers
            } // End NorthwindContext
        } // End Main
    } // End Class
} // End Namespace