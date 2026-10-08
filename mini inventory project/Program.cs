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
            }
        }

        static void viewItems()
        {
            Console.WriteLine($"Item Count: {names.Count}");
            Console.WriteLine($"First Item: {names[0]}, {quantities[1]}, {prices[1]}");
        }

        static void addItem()
        {

        }

    }
}
