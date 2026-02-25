public class DNA
{
    public string Seq;

    public DNA(string seq)
    {
        this.Seq = seq;
    }

    public DNA Replicate1()
    {
        DNA dna = new(this.Seq);
        return dna;
    }
    public DNA Replicate2()
    {
        return this;
    }
    public void Mutate(string seq)
    {
        this.Seq = seq;
    }
}
