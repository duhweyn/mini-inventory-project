using System.Threading.Channels;

namespace mini_inventory_project
{
    internal class Program
    {
        static List<string> names = new List<string>();
        static List<int> quantities = new List<int>();
        static List<double> prices = new List<double>();

        static void Main(string[] args)
        {
            loadSampleData();

            bool running = true;
            while (running)
            {
                showMenu();
                int choice = readInt("Choose: ");
                switch (choice)
                {
                    case 1:
                        viewItems();
                        break;
                    case 2:
                        addItem();
                        break;
                    case 7:
                        running = false;
                        break;
                }
            }
        }

        static void loadSampleData()
        {
            names.Add("Coffee Beans");
            quantities.Add(12);
            prices.Add(450);

            names.Add("Milk");
            quantities.Add(3);
            prices.Add(320);
        }

        static void showMenu()
        {
            Console.WriteLine("" +
                "1. View Items\n" +
                "2. Add Item\n" +
                "3. Update Item Quantity\n" +
                "4. Remove Item\n" +
                "5. Search\n" +
                "6. Show Low-Stock\n" +
                "7. Exit");
        }

        static int readInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                Console.WriteLine("Please enter a whole number.");
            }
        }

        static double readDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    return number;
                }
                Console.WriteLine("Please enter a whole number.");
            }
        }

        static void viewItems()
        {
            if (names.Count == 0)
            {
                Console.WriteLine("\nNo items yet.\n");
                return;
            }
            Console.WriteLine();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]}, {quantities[i]}, {prices[i]}");
            }
            Console.WriteLine();
        }

        static void addItem()
        {
            Console.Write("Item name: ");
            string name = Console.ReadLine();
            int quantity = readInt("Item quantity: ");
            if (quantity < 0)
            {
                Console.WriteLine("\nValue cannot be negative.\n");
                return;
            }
            double price = readDouble("Item price: ");
            if (price < 0)
            {
                Console.WriteLine("\nValue cannot be negative.\n");
                return;
            }
            Console.WriteLine("\nAdded.\n");

            names.Add(name);
            quantities.Add(quantity);
            prices.Add(price);
        }

    }
}
