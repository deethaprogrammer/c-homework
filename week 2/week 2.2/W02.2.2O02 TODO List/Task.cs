public class Task
{
    public string Name;
    public bool IsDone;

    public Task(string name)
    {
        this.Name = name;
    }

    public void Done()
    {
        this.IsDone = true;
    }

    public string Info()
    {
        return $"Task: {this.Name}, Status: {(IsDone? "Done" : "Pending")}";
    }
}