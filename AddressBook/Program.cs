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
            obj.CreateContact();
            Console.ReadLine();
        }
    }
}
