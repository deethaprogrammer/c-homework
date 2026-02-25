static class Program
{
    static void Main()
    {
        List<double> StudentGrades = new() {7, 5.5, 3.2, 10, 4.5};
        int passed = 0;
        foreach (double Grade in StudentGrades)
        {
            if (Grade >= 5.5)
            {
                passed ++;
            }
        }
        Console.WriteLine($"{passed} out of {StudentGrades.Count} students passed");
    }
}
