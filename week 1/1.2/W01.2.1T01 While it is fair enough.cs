static class Program
{
    static void Main()
    {
        int Euro = 4;
        while(Euro != 0)
        {
            Console.WriteLine($"Money left: {Euro}");
            Console.WriteLine("Look around (1) or go in a ride (2)?");
            string answer = Console.ReadLine();
            if (answer == "2")
            {
                Euro --;
            }
            string Action = answer switch
            {
                "1" => "Yay!",
                "2" => "Wheee!",
                _ => ""
            };
            if (Action != "")
            {
                Console.WriteLine(Action);
            }
        }
        Console.WriteLine("Time to go home");
    }
}
