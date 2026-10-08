namespace mini_inventory_project
{
    internal class Program
    {
        static int stock = 10;

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                showMenu();
                int choice = readInt("Choose: ");

                switch (choice)
                {
                    case 1:
                        addStock();
                        break;
                    case 2:
                        removeStock();
                        break;
                    case 3:
                        Console.WriteLine($"Current Stock: {stock}");
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("no idea how this was triggered");
                        break;
                }
            }
        }

        static void showMenu()
        {
            Console.WriteLine("1. Add Stock\n2. Remove Stock\n3. Show Stock\n4. Exit");
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

        static void addStock()
        {
            int amount = readInt("Amount to add: ");
            if (amount < 0)
            {
                Console.WriteLine("Amount cannot be negative.");
                return;
            }
            stock += amount;
            Console.WriteLine($"You added: {amount}. Current stock: {stock}");
        }

        static void removeStock()
        {
            int amount = readInt("Amount to remove: ");
            if (amount > stock)
            {
                Console.WriteLine("Amount cannot be greater than remaining stock.");
                return;
            } else if (amount < 0)
            {
                Console.WriteLine("Amount cannot be negative.");
            }
            stock -= amount;
            Console.WriteLine($"You deducted: {amount}. Current stock: {stock}");
        }

    }
}
