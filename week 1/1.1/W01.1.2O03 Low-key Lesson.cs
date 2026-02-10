static class Program
{
    static void Main()
    {
        string answer1 = "";
        string answer2 = "";
        int score = 0;

        Console.WriteLine("Answer the following MCQs:");
        Console.WriteLine("Which of the following is NOT a valid type in C#?");
        Console.WriteLine("A: bool\nB: int\nC: var\nD: string");
        answer1 = Console.ReadLine().ToLower();

        if (answer1 == "c")
        {
            score += 1;
        }

        Console.WriteLine("What happens if you execute the following line C#?\nint x = 1.23;");
        Console.WriteLine("A: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error");
        answer1 = Console.ReadLine().ToLower();

        if (answer1 == "d")
        {
            score += 1;
        }

        Console.WriteLine("Consider the following line:\ndouble d = 1.23;\nWhat are TWO ways to convert variable d to an int?");
        Console.WriteLine("A: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)");
        
        Console.WriteLine("Your first answer:");
        answer1 = Console.ReadLine().ToLower();
        
        Console.WriteLine("Your second answer:");
        answer2 = Console.ReadLine().ToLower();

        if ((answer1 == "a" && answer2 == "d") || (answer1 == "d" && answer2 == "a"))
        {
            score += 1;
        }
        if (score != 3)
        {
            Console.WriteLine($"Your score: {score} out of 3");
        }
        else
        {
            Console.WriteLine($"Your score: {score} out of 3. Well done!");
        }
    }
}
