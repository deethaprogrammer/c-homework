static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the initial balance in whole Euros?");
        double balance = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the interest rate in percent?");
        double interestPct = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Calculate over how many years?");
        int years = Convert.ToInt32(Console.ReadLine());
        double taxesPaid = 0.0;

        // Your tax code goes here
        for (int i = years; i > 0; i--)
        {
            balance = balance * ((interestPct / 100) + 1);
            if (balance > 100000)
            {
                double taxes = (50000 * 0.015) + ((balance - 100000) * 0.03);
                taxesPaid = taxesPaid + taxes;
                balance -= taxes;
            }
            else if (balance > 50000 && balance < 100000)
            {
                double taxes = ((balance - 50000) * 0.015);
                taxesPaid = taxesPaid + taxes;
                balance -= taxes;
            }
        }

        balance = (int)balance;
        taxesPaid = (int)(taxesPaid);
        Console.WriteLine($"Balance after {years} years: {balance}");
        Console.WriteLine($"Amount of taxes paid: {taxesPaid}");
    }
}
