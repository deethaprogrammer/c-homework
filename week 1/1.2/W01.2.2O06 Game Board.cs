static class chess
{
    static void Main()
    {
        Console.WriteLine("What size is the board (at least 2) its a sqaure.");
        int WidthHeight = 0;
        do
        {
            WidthHeight = Convert.ToInt32(Console.ReadLine());
        }while (WidthHeight < 2);
        for (int i = 1; i < (WidthHeight + 1); i++)
        {
            for (int j = 1; j <(WidthHeight + 1); j++)
            {
                if ((i % 2 == WidthHeight % 2 && j % 2 == 1) || (i % 2 != WidthHeight % 2 && j % 2 == 0))
                {
                    Console.Write("B");
                }
                else
                {
                    Console.Write("W");
                }
            }
            Console.WriteLine();
        }
    }
}