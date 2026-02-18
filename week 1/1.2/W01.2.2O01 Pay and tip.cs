static class PayTip
{
    static void Main()
    {
        Console.WriteLine("What is the amount to pay?");
        int amount = Convert.ToInt32(Console.ReadLine());
        int left = amount;
        string answer = "";
        do
        {
            Console.WriteLine($"{left} left to pay\nPay how much?");
            Console.WriteLine("1: 5\n2: 10\n3: 20\n4: 50");
            int input = Convert.ToInt32(Console.ReadLine());
            left -= input switch
            {
                1 => 5,
                2 => 10,
                3 => 20,
                4 => 50,
                _ => 0
            };
        }while(left > 0);
        if (left == 0)
        {
            Console.WriteLine($"You have paid {amount}");
        }
        else
        {
            do
            {
                left = -left;
                Console.WriteLine($"You paid {left} too much. Give a tip? y/n");
                answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine($"You have paid {amount + left}");
                }
                else if (answer == "n")
                {
                    Console.WriteLine($"You have paid {amount}");
                }
            }while(answer != "n" && answer != "y");
        }
    }
}