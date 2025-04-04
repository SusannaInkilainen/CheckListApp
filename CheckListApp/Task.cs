namespace CheckListApp;

public class Task()
{
    static List<TaskItem> tasks = new List<TaskItem>();
    static int nextId = 1;

    public void AddTask(string description)
    {
        tasks.Add(new TaskItem { Id = nextId++, Description = description, IsCompleted = false });
    }

    public void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Ei tehtäviä.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    public void RemoveTask(int id)
    {
        var task = tasks.Find(t => t.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
            Console.WriteLine("Tehtävä poistettu.");
        }
        else
        {
            Console.WriteLine("Tehtävää ei löytynyt.");
        }
    }

    public void CompleteTask(int id)
    {
        
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine("Tehtävä merkitty tehdyksi!");
            }
            else
            {
                Console.WriteLine("Tehtävää ei löytynyt.");
            }
        
    }
}