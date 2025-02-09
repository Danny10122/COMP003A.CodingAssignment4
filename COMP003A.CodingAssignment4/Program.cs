// Author: Daniel Juarez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.
namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!");

            // Declare a list to product names
            List<string> productNames = new List<string>();

            Console.WriteLine("\nInventory Management System menu:");
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. Update Product Quantity");
            Console.WriteLine("3. View Inventory Summary");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            
            do
            {
                // Menu option 1
                if (choice == 1)
                {
                    Console.Write("\nEnter Product name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter quantity amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    productNames.Add(name);
                    Console.WriteLine("Product added successfully!");

                }
            }while (choice != 0);
            

           
        }

    }
}
