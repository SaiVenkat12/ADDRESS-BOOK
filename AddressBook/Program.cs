﻿using System;
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
                Console.WriteLine("1.Create Contact \n2.Add Contact \n3.Display Contact \n4.Edit Contact \n5.Delete Contact \n6.Add Multiple Contact \n7.Create Address Books \n8.Display AddressBooks \n22.Exit");
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
