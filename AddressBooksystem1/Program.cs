using AddressBook;

namespace AddressBooksystem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.AddContact();
            addressBookMain.Display();
        }
       
    }
}