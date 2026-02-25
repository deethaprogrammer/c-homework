static class Program
{
    static void Main()
    {
        /*Create a List of Pets here:
         *- a Dog named Nugent
         *- a Cat named Steve
         *- a Goldfish named Brutus
         */
        Person p1 = new("John", new List<Pet>(
            [
                 new Pet("Dog", "Nugent"),
                 new Pet("Cat", "Steve"),
                 new Pet("Goldfish", "Brutus"),
            ]
        ));

    }
}
