namespace LibraryAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object 
            var firstCustomer = new Customer(1, "Sabrina", "Sabr@gmail.com");
            Console.WriteLine(firstCustomer.Name);
    }
}
