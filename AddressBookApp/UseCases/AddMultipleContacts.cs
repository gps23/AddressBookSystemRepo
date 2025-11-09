using System;
using System.Collections.Generic;

namespace AddressBookApp.UseCases
{
    public class AddMultipleContacts
    {
        public List<Dictionary<string, string>> Execute()
        {
            List<Dictionary<string, string>> contacts = new List<Dictionary<string, string>>();

            while (true)
            {
                Console.WriteLine("=== Add New Contact ===");
                var contact = new Dictionary<string, string>();

                Console.Write("Enter First Name: ");
                contact["FirstName"] = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                contact["LastName"] = Console.ReadLine();

                Console.Write("Enter Address: ");
                contact["Address"] = Console.ReadLine();

                Console.Write("Enter City: ");
                contact["City"] = Console.ReadLine();

                Console.Write("Enter State: ");
                contact["State"] = Console.ReadLine();

                Console.Write("Enter Zip: ");
                contact["Zip"] = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                contact["Phone"] = Console.ReadLine();

                Console.Write("Enter Email: ");
                contact["Email"] = Console.ReadLine();

                contacts.Add(contact);

                Console.Write("Add another contact? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            Console.WriteLine($"\nTotal Contacts Added: {contacts.Count}");
            return contacts;
        }
    }
}
