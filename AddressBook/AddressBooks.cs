using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBooks
    {
        List<Contact> addressBookList = new List<Contact>();
        Dictionary<string, List<Contact>> books = new Dictionary<string, List<Contact>>();
        Dictionary<string, List<Contact>> cityBook = new Dictionary<string, List<Contact>>();
        Dictionary<string, List<Contact>> stateBook = new Dictionary<string, List<Contact>>();
        List<Contact> cityList = new List<Contact>();
        List<Contact> stateList = new List<Contact>();
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
            contacts.phoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Address : ");
            contacts.address = Console.ReadLine();
            Console.WriteLine("Enter State Name : ");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            contacts.city = Console.ReadLine();
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
            Console.WriteLine("Enter State Name : ");
            addContact.state = Console.ReadLine();
            Console.WriteLine("Enter the City Name : ");
            addContact.city = Console.ReadLine();
            Console.WriteLine("Enter the Address : ");
            addContact.address = Console.ReadLine();
            Console.WriteLine("Enter Zip Code : ");
            addContact.zipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number : ");
            addContact.phoneNo = Convert.ToInt32(Console.ReadLine());

            addressBookList.Add(addContact);
            Console.WriteLine("Contact Added Successfully!");
        }
        public void EditContact()
        {
            Console.WriteLine("Enter the First Name to Check : ");
            string firstName = Console.ReadLine();
            int count = 0;
            foreach (Contact data in addressBookList)
            {
                if (data.firstName == firstName)
                {
                    count++;
                    Console.WriteLine("Edit Contact details");
                    Console.WriteLine("\n1.First Name \n2.Last Name \n3.Address \n4.city \n5.state \n6.zip Code \n7.Phone Number \n8.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name : ");
                            data.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name");
                            data.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter Address");
                            data.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter City");
                            data.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter State");
                            data.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter Zip Code");
                            data.zipCode = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter Phone Number");
                            data.phoneNo = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter Email");
                            data.email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Select Correct number");
                            break;
                    }
                    Console.WriteLine("Contact Edited Successfully");
                    break;
                }
            }
            if (count < 1)
            {
                Console.WriteLine("No Contact Exists with this First Name : " + firstName);
            }
        }
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter the Number of Contacts to Add : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    AddContact();
                }
            }
            else
            {
                Console.WriteLine("Enter the correct Number");
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the First Name to Check : ");
            string firstName = Console.ReadLine();
            int count = 0;
            foreach (Contact data in addressBookList)
            {
                if (data.firstName == firstName)
                {
                    addressBookList.Remove(data);
                    Console.WriteLine("Contact delete Scccessfully");
                    count++;
                    break;
                }
            }
            if (count < 1)
            {
                Console.WriteLine("No Contact Exists with this First Name : " + firstName);
            }

        }
        public void CreateAddressBooks()
        {

            Console.WriteLine("Enter the Name of Address Book : ");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter the Number of Contacts Needed : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                AddContact();
                n--;
            }
            books.Add(bookName, addressBookList);
            Console.WriteLine("Address Book Created Suceessfully !");
        }
        public void DisplayAddressBooks()
        {
            if (books.Count > 0)
            {
                foreach (var displayBook in books.Keys)
                {
                    Console.WriteLine("Address Book Name : " + displayBook);
                    foreach (Contact display in books[displayBook])
                    {
                        Console.WriteLine("Contact Details");
                        Console.WriteLine("Name : {0} {1}", display.firstName, display.lastName);
                        Console.WriteLine("Email :" + display.email);
                        Console.WriteLine("Phone Number : " + display.phoneNo);
                        Console.WriteLine("Address : " + display.address);
                        Console.WriteLine("State : " + display.state);
                        Console.WriteLine("City : " + display.city);
                        Console.WriteLine("ZipCode : " + display.zipCode);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Address Books Exists !");
            }

        }
        public void DisplayContact()
        {

            if (addressBookList.Count > 0)
            {
                foreach (Contact display in addressBookList)
                {
                    Console.WriteLine("Contact Details");
                    Console.WriteLine("Name : {0} {1}", display.firstName, display.lastName);
                    Console.WriteLine("Email : " + display.email);
                    Console.WriteLine("Phone Number : " + display.phoneNo);
                    Console.WriteLine("Address : " + display.address);
                    Console.WriteLine("State : " + display.state);
                    Console.WriteLine("City : " + display.city);
                    Console.WriteLine("ZipCode : " + display.zipCode);
                }
            }
            else
            {
                Console.WriteLine("No Contacts Exists !");
            }
        }
        public void CheckDuplicateEntry()
        {
            Console.WriteLine("Enter the First Name to Check : ");
            string fName = Console.ReadLine();
            bool fCheck = addressBookList.Any(e => e.firstName.ToLower() == fName.ToLower());
            if (fCheck)
            {
                Console.WriteLine("Enter the Last Name to Check : ");
                string lName = Console.ReadLine();
                bool lCheck = addressBookList.Any(e => e.lastName.ToLower() == lName.ToLower());
                if (lCheck)
                {
                    Console.WriteLine("Contact Already Exists\n");
                }
                else
                {
                    Console.WriteLine("Contact doesn't Exists");
                    Console.WriteLine("Create New Contact");
                    AddContact();
                }
            }
            else
            {
                Console.WriteLine("Contact doesn't Exists");
                Console.WriteLine("Create New Contact");
                AddContact();
            }
        }
        public void SearchPersonByCityOrState()
        {
            Console.WriteLine("1.Search Person By State\n2.Search Person By City");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the State Name : ");
                    string state = Console.ReadLine();
                    int Count = 0;
                    foreach (var key in books.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + key);
                        foreach (var data in addressBookList.FindAll(e => e.state.ToLower() == state.ToLower()))
                        {
                            stateList.Add(data);
                            Console.WriteLine("The Contacts in the State -" + data.state + "\nName: " + data.firstName + " " + data.lastName + " " + "\nEmail: " + data.email + " " + "\nPhoneNumber: " + data.phoneNo);
                            Count++;
                        }
                    }
                    if (Count <= 0)
                        Console.WriteLine("No Contacts Exists in the State- " + state);
                    else
                        stateBook.Add(state, stateList);
                    break;
                case 2:
                    Console.Write("Enter the city Name : ");
                    string City = Console.ReadLine();
                    int count = 0;
                    foreach (var key in books.Keys)
                    {
                        Console.WriteLine("Address Book Name: " + key);
                        foreach (var data in addressBookList.FindAll(e => e.city.ToLower() == City.ToLower()))
                        {
                            cityList.Add(data);
                            Console.WriteLine("The Contacts in the City -" + data.city + " are" + "\nName: " + data.firstName + " " + data.lastName + " " + "\nEmail: " + data.email + " " + "\nPhoneNumber: " + data.phoneNo);
                            count++;
                            return;
                        }
                    }
                    if (count <= 0)
                        Console.WriteLine("No Contacts Exists in the City- " + City);
                    else
                        cityBook.Add(City, cityList);
                    break;
            }
        }
        public void CountContactsByCityOrState()
        {
            List<Contact> cityList = new List<Contact>();
            List<Contact> stateList = new List<Contact>();
            Console.WriteLine("1.Select Whether to Count Contacts by\n1.City\n2.State");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter the City Name : ");
                    string City = Console.ReadLine();
                    foreach (var Key in books)
                    {
                        foreach (var Data in Key.Value.FindAll(e => e.city.ToLower() == City.ToLower()))
                        {
                            cityList.Add(Data);
                        }
                        Console.WriteLine("Number of Contacts in City- {0} are {1}", City, cityList.Count);
                    }
                    break;
                case 2:
                    Console.Write("Enter the City Name : ");
                    string State = Console.ReadLine();
                    foreach (var Key in books)
                    {
                        foreach (var Data in Key.Value.FindAll(e => e.state.ToLower() == State.ToLower()))
                        {
                            cityList.Add(Data);
                        }
                        Console.WriteLine("Number of Contacts in City- {0} are {1}", State, stateList.Count);
                    }
                    break;
            }
        }
        public void SortContacts()
        {
            Console.WriteLine("Sort Contacts using \n1.First Name \n2.City \n3.State \n4.Zip");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    foreach (var book in books)
                    {
                        Console.WriteLine("AddressBook Name is: " + book.Key);
                        foreach (var contact in book.Value.OrderBy(e => e.firstName))
                        {
                            Console.WriteLine("Contact Details:" + "\nFirstName: " + contact.firstName + "\nLastName: " + contact.lastName + "\nAddress: " + contact.address + "\n" + "City: " + contact.city + "\n" + "State: " + contact.state + "\nZip Code: " + contact.zipCode + "\n" + "Phone Number: " + contact.phoneNo + "\n" + "Email: " + contact.email);
                        }
                    }
                    break;
                case 2:
                    foreach (var book in books)
                    {
                        Console.WriteLine("AddressBook Name is: " + book.Key);
                        foreach (var contact in book.Value.OrderBy(e => e.city))
                        {
                            Console.WriteLine("Contact Details:" + "\nFirstName: " + contact.firstName + "\nLastName: " + contact.lastName + "\nAddress: " + contact.address + "\n" + "City: " + contact.city + "\n" + "State: " + contact.state + "\nZip Code: " + contact.zipCode + "\n" + "Phone Number: " + contact.phoneNo + "\n" + "Email: " + contact.email);
                        }
                    }
                    break;
                case 3:
                    foreach (var book in books)
                    {
                        Console.WriteLine("AddressBook Name is: " + book.Key);
                        foreach (var contact in book.Value.OrderBy(e => e.state))
                        {
                            Console.WriteLine("Contact Details:" + "\nFirstName: " + contact.firstName + "\nLastName: " + contact.lastName + "\nAddress: " + contact.address + "\n" + "City: " + contact.city + "\n" + "State: " + contact.state + "\nZip Code: " + contact.zipCode + "\n" + "Phone Number: " + contact.phoneNo + "\n" + "Email: " + contact.email);
                        }
                    }
                    break;
                case 4:
                    foreach (var book in books)
                    {
                        Console.WriteLine("AddressBook Name is: " + book.Key);
                        foreach (var contact in book.Value.OrderBy(e => e.zipCode))
                        {
                            Console.WriteLine("Contact Details:" + "\nFirstName: " + contact.firstName + "\nLastName: " + contact.lastName + "\nAddress: " + contact.address + "\n" + "City: " + contact.city + "\n" + "State: " + contact.state + "\nZip Code: " + contact.zipCode + "\n" + "Phone Number: " + contact.phoneNo + "\n" + "Email: " + contact.email);
                        }
                    }
                    break;
            }
        }
        public void ReadAndWriteAddressBookContactsToFile()
        {
            string filePath = @"C:\Users\venky\source\Repos2\ADDRESS-BOOK\AddressBook\Files\AddressBookTextFile.txt";
            StreamWriter write = new StreamWriter(filePath);
            foreach (var book in books)
            {
                write.WriteLine("AddressBook Name : " + book.Key);
                foreach (var contact in book.Value)
                {
                    write.WriteLine("Contact Details:" + "\nName: " + contact.firstName + " " + contact.lastName + "\nAddress: " + contact.address + "\n" + "City: " + contact.city + "\n" + "State: " + contact.state + "\nZip Code: " + contact.zipCode + "\n" + "Phone Number: " + contact.phoneNo + "\n" + "Email: " + contact.email);
                }
            }
            write.Close();
            StreamReader reader = new StreamReader(filePath);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            Console.WriteLine("Contacts Added to file");
        }
        public void ReadAndWriteCSVFile()
        {
            string filepath = @"C:\Users\venky\source\Repos2\ADDRESS-BOOK\AddressBook\Files\ContactsCSVFile.csv";
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                using (CsvWriter csvImport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvImport.WriteRecords<Contact>(addressBookList);
                }
                writer.Close();
            }
            using (StreamReader record = new StreamReader(filepath))
            using (CsvReader csv = new CsvReader(record, CultureInfo.InvariantCulture))
            {
                var item = csv.GetRecords<Contact>();
                foreach (Contact contact in item)
                {
                    Console.WriteLine("Contact Details:" + "\nFirst Name: " + contact.firstName + "\nLast Name: " + contact.lastName + "\nAddress: " + contact.address + "\n" + "City: " + contact.city + "\n" + "State: " + contact.state + "\nZip Code: " + contact.zipCode + "\n" + "Phone Number: " + contact.phoneNo + "\n" + "Email: " + contact.email);
                }
            }
        }
        public  void ReadWritePersonContactsToJSONFile()
        {
            //Write
            string jsonFilePath = @"C:\Users\venky\source\Repos2\ADDRESS-BOOK\AddressBook\Files\ContactsJsonFile.json";
            string jsonObject = JsonConvert.SerializeObject(addressBookList);
            File.WriteAllText(jsonFilePath, jsonObject);
            //Read
            string jsonContact = File.ReadAllText(jsonFilePath);
            List<Contact> jsonList = JsonConvert.DeserializeObject<List<Contact>>(jsonContact);
            foreach (Contact contact in jsonList)
            {
                Console.WriteLine("Contact Details:" + "\nFirst Name: " + contact.firstName + "\nLast Name: " + contact.lastName + "\nAddress: " + contact.address + "\n" + "City: " + contact.city + "\n" + "State: " + contact.state + "\nZip Code: " + contact.zipCode + "\n" + "Phone Number: " + contact.phoneNo + "\n" + "Email: " + contact.email);
            }
        }
    }
}
