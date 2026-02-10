static class Program
{
    static void Main()
    {
        double discount = 0.1;
        int price = 55;
        double discountPrice = price - (price * discount);

        var message = "";
        message = $"The discount price is {discountPrice}";
        Console.WriteLine(message);
    }
}
