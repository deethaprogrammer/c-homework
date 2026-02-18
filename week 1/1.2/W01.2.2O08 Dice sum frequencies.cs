static class Program
{
    static void Main()
    {
        Random rand = new(0);
        int howManyTimes = 500;
        int dieSides = 6;

        // Your code goes here
        int[] counts = new int[13];
        for (int i = 0; i < howManyTimes; i++)
        {
            int die1 = rand.Next(1, (dieSides + 1));
            int die2 = rand.Next(1, (dieSides + 1));
            int sum = die1 + die2;
            counts[sum]++;
        }
        for (int sum = 2; sum <= 12; sum++)
        {
            if (sum < 10)
            {
                Console.Write(" " + sum + ": ");
            }
            else
            {
                Console.Write(sum + ": ");
            }
            Console.WriteLine(new string('|', counts[sum]));
        }
    }
}
