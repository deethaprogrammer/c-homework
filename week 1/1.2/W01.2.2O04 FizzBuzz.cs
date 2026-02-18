static class FizzBuzz
{
    static void Main()
    {
        Console.WriteLine("Enter a start number");
        int start = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter an end number");
        int end = Convert.ToInt32(Console.ReadLine());
        for (; start < (end + 1); start++)
        {
            if (start % 3 != 0 && start % 5 != 0)
            {
                Console.WriteLine(start);
            }
            else if (start % 3 == 0 && start % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (start % 3 == 0 && start % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine("Buzz");
            }
        }
    }
}