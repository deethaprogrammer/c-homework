static class Program
{
    static void Main()
    {
        // Settings > Debug > Console: Collapse Identical Lines
        // https://learn.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0
        // "console": "integratedTerminal",
        Console.WriteLine("For each direction, input Y/N if it is valid.");
        bool AllowNorth = AskForallowedDirection("North");
        bool AllowEast = AskForallowedDirection("East");
        bool AllowSouth = AskForallowedDirection("South");
        bool AllowWest = AskForallowedDirection("West");

        Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");
        int angleInput = Convert.ToInt32(Console.ReadLine());

        int angle = ((angleInput % 360) + 360) % 360; //this is so that if you type -1000 it wil go to the correct degree between 0 and 360

        Console.WriteLine("From here you can go:");
        DrawDirection(AllowNorth, AllowEast, AllowSouth, AllowWest);

        string direction = angle switch
        {
            var a when (a > 315 || a <= 45) => "North",
            var a when (a > 45 && a <= 135) => "East",
            var a when (a > 135 && a <= 225) => "South",
            var a when (a > 225 && a <= 315) => "West"
        };
        bool AllowedDirection = direction switch
        {
            "North" => AllowNorth,
            "East" => AllowEast,
            "South" => AllowSouth,
            "West" => AllowWest
        };
        if (AllowedDirection)
        {
            Console.WriteLine($"\nYou are going {direction}");
        }
        else
        {
            Console.WriteLine($"\nYou can't go {direction}");
        }
    }
    static bool AskForallowedDirection(string dir)
    {
        Console.WriteLine($"{dir}? Y/N");
        string input = Console.ReadLine().ToUpper();
        return input == "Y";
    }
    static void DrawDirection(bool north, bool east, bool south, bool west)
    {
        if (north)
        {
            Console.WriteLine("    N\n    |");
        }
        Console.WriteLine((west ? "W---": "    ") + "|" + (east ? "---E": ""));
        if (south)
        {
            Console.WriteLine("    |\n    S");
        }
        
    }
}
