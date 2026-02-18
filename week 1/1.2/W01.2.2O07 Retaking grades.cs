static class GradeRetake
{
    static void Main()
    {
        List<double> Grades = new() {6.5, 9.5, 4, 5, 4.5, 10, 7.1};
        for (int i = 0; i < Grades.Count; i++)
        {
            Console.WriteLine($"Grade: {Grades[i]}");

            if (Grades[i] < 5.5)
            {
                string answer = "";
                while (true)
                {
                    Console.WriteLine("Retake this course? y/n");
                    answer = Console.ReadLine().ToLower();
                    
                    if (answer == "y" || answer == "n")
                    {
                        break;
                    }
                }
                if (answer == "y")
                {
                    Grades[i] += 1;
                }
            }
        }
        Console.WriteLine("Final grades:");
        foreach (double grade in Grades)
        {
            Console.WriteLine(grade);
        }
    }
}