namespace MyClassLibrary
{
    public class Customer
    {
        //Properties
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
       
        //the following properties have ? with datatypes which shows that they are nullable, it is ok if they dont have information
        public string?  Address { get; set; }
        public int? PostNumber { get; set; }
        public string? City { get; set; }
        public int? IsVIP { get; set; }


        //constructor
        public Customer(int id, string name, string email)
        {
            CustomerId = id;
            Name = name;
            Email = email;

        }
    }

}
