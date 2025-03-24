using MyClassLibrary;

namespace LibraryAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of a customer
            var firstCustomer = new Customer(1, "Obed Samuel", "obed@gmail.com");
            Console.WriteLine(firstCustomer.Name);

            //an instance with a list of 4 customers
            var customers = new List<Customer>
            {
                new Customer(1, "Sabrina Obed", "sabrina@gmail.com"),
                new Customer(2, "Verdha Yousaf", "verdha@gmail.com"),
                new Customer(3, "Sadrick John", "sadrick@gmail.com"),
                new Customer(4, "Eliza John", "eliza@gmail.com")
            };


        }

    }
}

