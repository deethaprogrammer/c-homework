static class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        string PersonalAge = Console.ReadLine();
        double PA = Convert.ToInt32(PersonalAge);
        Console.WriteLine("What is the age of the student next to you?");
        string OtherAge = Console.ReadLine();
        double OA = Convert.ToInt32(OtherAge);

        if (PA < OA)
        {
            Console.WriteLine("You are younger");
        }
        else if (PA == OA)
        {
            Console.WriteLine("Your ages are equal");
        }
        else
        {
            Console.WriteLine("You are older");
        }
    }
}
