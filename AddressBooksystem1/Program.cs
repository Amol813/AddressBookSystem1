using AddressBook;

namespace AddressBooksystem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book System!");
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            contact.ZIP = Console.ReadLine();
            Console.WriteLine("Enter Phonenumber");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();
           
        }
    }
}