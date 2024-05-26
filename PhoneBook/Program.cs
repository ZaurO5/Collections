using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class Program
    {
        public static void Main()
        {
            PhoneBook phonebook = new PhoneBook();
            phonebook.AddContact("Zaur", "0502739237");
            phonebook.AddContact("Ali", "0551328765");

            Console.WriteLine("All Contacts:");
            foreach (var contact in phonebook.GetAllContacts())
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }

            Console.WriteLine($"Find Zaur: {phonebook.FindContactName("Zaur")}");
            phonebook.RemoveContact("Zaur");
            Console.WriteLine($"Find Zaur: {phonebook.FindContactName("Zaur")}");
        }
    }
}