namespace CheckListApp;

public class Task()
{
    static List<TaskItem> tasks = new List<TaskItem>();
    static int nextId = 1;

    public static void AddTask()
    {
        Console.Write("Anna tehtävän kuvaus: ");
        string description = Console.ReadLine();
        tasks.Add(new TaskItem { Id = nextId++, Description = description, IsCompleted = false });
        Console.WriteLine("Tehtävä lisätty!");
    }

    public static void ShowTasks()
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

    public static void RemoveTask()
    {
        Console.Write("Anna poistettavan tehtävän numero: ");
        if (int.TryParse(Console.ReadLine(), out int id))
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
        else
        {
            Console.WriteLine("Virheellinen syöte.");
        }
    }

    public static void CompleteTask()
    {
        Console.Write("Anna tehtävän numero: ");
        if (int.TryParse(Console.ReadLine(), out int id))
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
        else
        {
            Console.WriteLine("Virheellinen syöte.");
        }
    }
}