using System;
using System.Collections.Generic;

namespace ContactBookWithModules
{
    class Program
    {
        static List<Contact> contacts = new List<Contact>();

        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();

                int choice = GetChoice();

                switch (choice)
                {
                    case 1:
                        ShowContacts();
                        break;
                    case 2:
                        AddContact();
                        break;
                    case 3:
                        EditContact();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the Contact Book. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nContact Book Menu:");
            Console.WriteLine("1. Show Contacts");
            Console.WriteLine("2. Add Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");
        }

        static int GetChoice()
        {
            Console.Write("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void ShowContacts()
        {
            Console.WriteLine("\nContacts:");
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }

        static void AddContact()
        {
            Console.Write("Enter contact name: ");
            string name = Console.ReadLine();
            Console.Write("Enter contact number: ");
            string number = Console.ReadLine();

            Contact newContact = new Contact(name, number);
            contacts.Add(newContact);

            Console.WriteLine("Contact added successfully!");
        }

        static void EditContact()
        {
            ShowContacts();
            Console.Write("Enter the index of the contact you want to edit: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < contacts.Count)
            {
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();
                Console.Write("Enter new number: ");
                string newNumber = Console.ReadLine();

                contacts[index].Name = newName;
                contacts[index].Number = newNumber;

                Console.WriteLine("Contact edited successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }
        }

        static void DeleteContact()
        {
            ShowContacts();
            Console.Write("Enter the index of the contact you want to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index. Please try again.");
            }
        }
    }

    class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number: {Number}";
        }
    }
}
