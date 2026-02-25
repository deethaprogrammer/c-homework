public class Person
{
    public string Name;
    public Job DayJob;

    public Person(string name, Job job)
    {
        this.Name = name;
        this.DayJob = job;
    }

    public string Info()
    {
        if (this.DayJob == null) {return $"{this.Name} is in between jobs";}
        return $"{this.Name} works as a {this.DayJob.Name}";
    }
}