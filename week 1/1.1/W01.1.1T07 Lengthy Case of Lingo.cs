static class Program
{
    static void Main()
    {
        string word = "Length";
        Console.WriteLine("You have one chance to guess this six letter word:");
        Console.WriteLine("Le..th");
        
        string answer = Console.ReadLine();
        string control = answer switch
        {
            var a when a == word => "Correct !",
            var a when a.Length != 6 => "Incorrect! That is not even a six-letter word!",
            var a when a.ToLower() == word.ToLower() => "Kind of correct; the case was just wrong",
            _ => "Incorrect !"
        };
        Console.WriteLine(control);
    }
}
