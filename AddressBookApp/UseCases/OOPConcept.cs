using System;

namespace AddressBookApp.UseCases
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} — {City}");
        }
    }

    public class OOPConcept
    {
        public void Execute()
        {
            Console.WriteLine("=== Demonstrating OOP ===");
            Contact c1 = new Contact
            {
                FirstName = "Praja",
                LastName = "Sree",
                City = "Chennai"
            };

            c1.Display();
        }
    }
}
