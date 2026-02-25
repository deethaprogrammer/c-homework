class DNA
{
    public DNA Ancestor;
    public string Seq;
    private static Random _rand = new(0); // Seeded Random

    public DNA(DNA ancestor, string seq)
    {
        this.Ancestor = ancestor;
        this.Seq = seq.ToUpper();
    }

    private string MutateTransition()
    {
        int indexToMutate = _rand.Next(0, Seq.Length);
        string mutatedSeq = Seq[0 .. indexToMutate] // Left of mutation
            + MutateTransitionTable(Seq[indexToMutate]) // Mutation
            + Seq[(indexToMutate+1) .. Seq.Length]; // Right of mutation
        return mutatedSeq;
    }

    private static char MutateTransitionTable(char nucleotide) => nucleotide switch
    {
        'A' => 'G',
        'G' => 'A',
        'C' => 'T',
        'T' => 'C',
        _ => throw new ArgumentOutOfRangeException($"{nucleotide}", $"Unexpected nucleotide value: {nucleotide}"),
    };

    public DNA Replicate()
    {
        return new DNA(this, MutateTransition());
    }
}
