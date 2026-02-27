static class Program
{
    static void Main()
    {
        List<DNA> DNAList = new(
            [
                new DNA("ACGT"),
                new DNA("GCTTAC"),
                new DNA("CGTTAGCTT"),
                new DNA("TACA"),
            ]
        );
        Console.WriteLine("What is the minimum sequence length?");
        int MinimumSequence = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The filtered list:");
        foreach (DNA dna in DNAList)
        {
            int StringLength = dna.Seq.Length;
            if (StringLength >= MinimumSequence)
            {
                Console.WriteLine(dna.Seq);
            }
        }
    }
}
