static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the temperature in Celsius?");
        string TempCels = Console.ReadLine();
        double temp = Convert.ToDouble(TempCels);
        temp = temp * 1.8 + 32;
        int Temp = (int)temp;
        Console.WriteLine(TempCels + " C = " + temp + " F");
        Console.WriteLine("Truncated that is " + Temp + " F");
    }
}
