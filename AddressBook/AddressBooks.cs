using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBooks
    {
        List<Contact> addressBookList= new List<Contact>();
        public void CreateContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Enter First Name : ");
            contacts.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            contacts.lastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            contacts.email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            contacts.phoneNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Address : ");
            contacts.address=Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            contacts.city=Console.ReadLine();           
            Console.WriteLine("Enter Zip Code : ");
            contacts.zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contact created");
        }
        public void AddContact()
        {
            Contact addContact = new Contact();
            Console.WriteLine("Enter First Name : ");
            addContact.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            addContact.lastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            addContact.email = Console.ReadLine();
            Console.WriteLine("Enter Phone Number : ");
            addContact.phoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Address : ");
            addContact.address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            addContact.state = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            addContact.city = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            addContact.zipCode = Convert.ToInt32(Console.ReadLine());
            addressBookList.Add(addContact);
            Console.WriteLine("Contact Added Successfully!");
        }
        public void DisplayContact()
        {
            Console.WriteLine("Contact Details");
            foreach(Contact display in addressBookList)
            {
                Console.WriteLine(display.firstName);
                Console.WriteLine(display.lastName);
                Console.WriteLine(display.email);
                Console.WriteLine(display.phoneNo);
                Console.WriteLine(display.address);
                Console.WriteLine(display.state);
                Console.WriteLine(display.city);
                Console.WriteLine(display.zipCode);
            }
        }
    }
}
