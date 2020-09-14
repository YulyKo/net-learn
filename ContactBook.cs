using System;
using System.Collections.Generic;

namespace net_learn {
    class ContactBook
    {
        static private Dictionary<string, long> contactBook = new Dictionary<string, long>();
        static private Contact contact;

        static void Main(string[] args)
        {
            setMenu();
        }

        static void createContact() {
            contact = new Contact();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            contact.ContactName = name;
            Console.Write("Enter phone number: ");
            contact.PhoneNumber = long.Parse(Console.ReadLine());
            contactBook.Add(contact.ContactName, contact.PhoneNumber);
            showContactsFromBook();
            setMenu();
        }

        static void setMenu() {
            Console.Write("\nWelcome to menu of Contact Book \n *-*-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.Write("Chouse action:\n1. Add contact\n2. Watch contact book\n");
            int actionId = int.Parse(Console.ReadLine());
            if (actionId == 1)
            {
                createContact();
            } else if(actionId == 2) {
                showContactsFromBook();
            }
        }

        static void showContactsFromBook() {
            Console.Write("\n======================\n");
            foreach (var contact in contactBook)
            {
                 Console.Write(contact.Key + " | " + contact.Value + "\n");
            }
            Console.Write("\n======================\n");
        }
    }

    
    class Contact
    {
        private string contactName;
        private long phoneNumber;

        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

    }

}