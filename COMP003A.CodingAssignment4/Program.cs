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
            // Empty collections for product names and quantities 
            List<string> productNames = new List<string>();
            List<int> productQuantities = new List<int>();

            // Welcome message 
            Console.WriteLine("Welcome to the Inventory Management System!");

            // Main loop for the menu 
            while (true)
            {
                // Display menu options 
                Console.WriteLine("\nInventory Management System Menu:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;

                }

                // Perform based on choice 
                if (choice == 1)
                {
                    AddProduct(productNames, productQuantities);

                }
                else if (choice == 3)
                {
                    ViewInventorySummary(productNames, productQuantities);

                }
                else if (choice == 4)
                {
                    Console.WriteLine("Thank you for using the Inventory Management System. Goodbye!");
                    break; // Exit the loop and terminate the program 

                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");

                }
            }
        }

        /// <summary> 
        /// Adds a product to the inventory. 
        /// </summary> 
        /// <param name="productNames">List of product names.</param> 
        /// <param name="productQuantities">List of product quantities.</param> 
        static void AddProduct(List<string> productNames, List<int> productQuantities)
        {
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product quantity: ");
            int quantity;

            if (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Invalid quantity. Please enter a number.");
                return;

            }
            // Add product to the lists 
            productNames.Add(name);
            productQuantities.Add(quantity);

            Console.WriteLine("Product added successfully!");
        }

        /// <summary> 
        /// Displays the inventory summary. 
        /// </summary> 
        /// <param name="productNames">List of product names.</param> 
        /// <param name="productQuantities">List of product quantities.</param> 
        static void ViewInventorySummary(List<string> productNames, List<int> productQuantities)
        {
            Console.WriteLine("\nInventory Summary:");
            int totalQuantity = 0;

            // Display product and quantity 
            for (int i = 0; i < productNames.Count; i++)
            {
                Console.WriteLine($"- {productNames[i]}: {productQuantities[i]}");
                totalQuantity += productQuantities[i];

            }
            // Calculate and display totals 
            Console.WriteLine($"\nTotal Products: {productNames.Count}");
            Console.WriteLine($"Total Quantity: {totalQuantity}");

        }
    }
}
