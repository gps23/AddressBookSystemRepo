using System;
using AddressBookApp.UseCases;

namespace AddressBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Address Book System ===");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. Edit Contact");
            Console.WriteLine("3. Delete Contact");
            Console.WriteLine("4. Add Multiple Contacts");
            Console.WriteLine("5. Manage Multiple Address Books");
            Console.WriteLine("6. Demonstrate OOP Concepts");
            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            var addMultiple = new AddMultipleContacts();
            List<Dictionary<string, string>> contacts = new();

            switch (choice)
            {
                case 1:
                    new AddNewContact().Execute();
                    break;
                case 2:
                    new EditContact().Execute(contacts);
                    break;
                case 3:
                    new DeleteContact().Execute(contacts);
                    break;
                case 4:
                    contacts = addMultiple.Execute();
                    break;
                case 5:
                    new MultipleAddressBooks().Execute();
                    break;
                case 6:
                    new OOPConcept().Execute();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
