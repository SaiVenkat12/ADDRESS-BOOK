using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Address Book Program");
            AddressBooks obj = new AddressBooks();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1.Create Contact \n2.Add Contact \n3.Display Contact \n4.Edit Contact \n5.Delete Contact \n6.Add Multiple Contact \n7.Create Address Book \n8.Display AddressBooks \n9.Check for Duplicate Entry \n10.Search Person by City or State \n11.View Person by City or State \n12.Count Contacts by City or State \n13.Sort Contacts \n14.Read and Write AddressBook Contacts to a File \n15.Read and Write Contacts to a CSV File \n16.Read and Write Contacts to a JSON File \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        obj.CreateContact();
                        break;
                    case 2:
                        obj.AddContact();
                        break;
                    case 3:
                        obj.DisplayContact();
                        break; 
                    case 4:
                        obj.EditContact();
                        break; 
                    case 5:
                        obj.DeleteContact();
                        break; 
                    case 6:
                        obj.AddMultipleContact();
                        break;              
                    case 7:
                        obj.CreateAddressBooks();
                        break;
                    case 8:
                        obj.DisplayAddressBooks();
                        break;
                    case 9:
                        obj.CheckDuplicateEntry();
                        break;
                    case 10:
                        obj.SearchPersonByCityOrState();
                        break; 
                    case 11:
                        obj.SearchPersonByCityOrState();
                        break;
                    case 12:
                        obj.CountContactsByCityOrState();
                        break;
                    case 13:
                        obj.SortContacts();
                        break;
                    case 14:
                        obj.ReadAndWriteAddressBookContactsToFile();
                        break;
                    case 15:
                        obj.ReadAndWriteCSVFile();
                        break;
                    case 16:
                        obj.ReadWritePersonContactsToJSONFile();
                        break;
                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
