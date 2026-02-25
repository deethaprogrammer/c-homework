static class AppraisalTool
{
    public static Dictionary<string, double> Catalogue = new() {
        { "The Hope Diamond", 250_000_000 },
        { "The Mona Lisa", 50_000_000 },
        { "Tutankhamun's Mask", 5_000_000 },
        { "The Dead Sea Scrolls (Fragment)", 1_500_000 },
        { "A Roman Gladiator's Helmet", 1_000_000 },
        { "The Gutenberg Bible (Single Page)", 500_000 },
        { "A Viking Longship Fragment", 300_000 },
        { "An Ancient Greek Amphora", 200_000 },
        { "Rare stamp (1851 10c green)", 1_000 },
        { "A Samurai Katana from the Edo Period", 150_000 },
        { "A Pre-Columbian Gold Figurine", 100_000 },
    };

    static void Main()
    {
        Console.WriteLine("Appraising listed artifacts...");
        List<Artifact> listedArtifacts = [
            new("The Hope Diamond", 1),
            new("A Pre-Columbian Gold Figurine", 0),
            new("The Dead Sea Scrolls (Fragment)", 0.5),
            new("An Ancient Greek Amphora", 0.75),
        ];
        
        foreach (var artifact in listedArtifacts)
        {
            Appraise(artifact);
        }
        
        Console.WriteLine("\nAppraising unlisted artifacts...");
        List<Artifact> unlistedArtifacts = [
            new("Gom Jabbar", 1),
            new("Invisibility Cloak", 0.9),
            new("The Praetor Suit", 1),
            new("The Master Sword", 0),
        ];
        
        foreach (var artifact in unlistedArtifacts)
        {
            Appraise(artifact);
        }
        
        Console.WriteLine("\nAdding artifacts...");
        AddArtifact("Orb of Dragonkind", 2_000_000);
        AddArtifact("The Hope Diamond", 250_000_000);
        AddArtifact(" Leoric's Crown  ", 1_000_000);
        AddArtifact("  The Gutenberg Bible (Single Page) ", 500_000);
        
        Console.WriteLine("\nPrinting Catalogue...");
        PrintCatalogue();
    }
    
    // Your valuable code goes here
    public static string formatValue(double value)
    {
        if (value >= 1_000_000)
        {
            double millions = value / 1_000_000;
            return millions % 1 == 0 ? $"{millions:0}M" : $"{millions:0.#}M";
        }
        else if (value >= 1_000)
        {
            double thousands = value / 1_000;
            return thousands % 1 == 0 ? $"{thousands:0}k" : $"{thousands:0.#}k";
        }
        return value.ToString("0");
    }
    public static void Appraise(Artifact artifact)
    {
        if (!Catalogue.TryGetValue(artifact.Name, out double PerfectValue))
        {
            Console.WriteLine($"Artifact '{artifact.Name}' not in catalogue");
            return;
        }
        double finalValue = PerfectValue * artifact.ConditionRate;
        Console.WriteLine($"Value of artifact '{artifact.Name}': {formatValue(finalValue)}");
    }
    public static void AddArtifact(string artifactName, double Perfectvalue)
    {
        artifactName = artifactName.Trim();
        if (!Catalogue.ContainsKey(artifactName))
        {
            Catalogue.Add(artifactName, Perfectvalue);
            Console.WriteLine($"Added artifact '{artifactName}'");
            return;
        }
        Console.WriteLine($"Artifact '{artifactName}' already in catalogue");
    }
    public static void PrintCatalogue()
    {
        Console.WriteLine("Catalogue:");
        foreach (KeyValuePair<string, double> artifact in Catalogue)
        {
            Console.WriteLine($" - Artifact: '{artifact.Key}', Perfect Condition Value: {formatValue(artifact.Value)}");
        }
    }
}
