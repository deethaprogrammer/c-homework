public class ToDo
{
    public List<Task> TaskList = [];

    public void AddTask(string name)
    {
        this.TaskList.Add(new Task(name));
    }

    public Task GetTask(string name)
    {
        foreach(Task task in TaskList)
        {
            if (task.Name == name)
            {
                return task;
            }
        }
        return null;
    }

    public string Report()
    {
        string tasks = "";
        foreach (Task task in TaskList)
        {
            tasks += task.Info() + "\n";
        }
        return tasks;
    }
}