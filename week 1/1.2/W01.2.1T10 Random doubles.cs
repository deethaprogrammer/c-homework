static class Program
{
    static void Main()
    {
        Random rng = new Random();
        int attack = 50;
        double critChance = 0.33;

        int bossHP = 500;

        // Your code goes here. Fight the boss until he's dead!
        while (bossHP > 0)
        {
            Console.WriteLine($"Boss HP: {bossHP}");
            if (rng.NextDouble() <= 0.33)
            {
                bossHP -= attack * 2;
                Console.WriteLine($"Damage: {attack * 2}");
            }
            else
            {
                bossHP -= attack;
                Console.WriteLine($"Damage: {attack}");
            }
        }
        Console.WriteLine("Boss defeated");
    }
}
