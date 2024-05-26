using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneBook
    {
        public Dictionary<string, string> 
        Contacts { get; private set; }

        public PhoneBook()
        {
            Contacts = new Dictionary<string, string>();
        }

        public void AddContact(string name, string number)
        {
            if (Contacts.ContainsKey(name))
            {
                Console.WriteLine($"Contact {name} already exists");
            }
            Contacts[name] = number;
            Console.WriteLine($"Contact {name} added (number {number})");
        }

        public void RemoveContact(string name)
        {
            if (Contacts.ContainsKey(name))
            {
                Contacts.Remove(name);
                Console.WriteLine($"Contact {name} removed");
            }
            else
            {
                Console.WriteLine($"Contact {name} not found");
            }
        }

        public Dictionary<string, string> GetAllContacts()
        {
            return Contacts;
        }

        public string FindContactName(string name)
        {
            if (Contacts.TryGetValue(name, out string number))
            {
                return number;
            }
            else
            {
                return "Contact not found";
            }
        }
    }
}