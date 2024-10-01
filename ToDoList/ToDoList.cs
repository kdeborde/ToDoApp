namespace ToDoList
{
    public class ToDoList
    {
        private readonly List<string> _tasks;
        public List<string> Tasks { get; } = new List<string>();

        public ToDoList()
        {
            _tasks = Tasks;
        }
        public string AddTask()
        {
            Console.WriteLine("Enter the name of the task to add:");
            string? task = Console.ReadLine();
            string output;
            if (string.IsNullOrEmpty(task))
            {
                output = "Task cannot be empty.";
            }
            else if (_tasks.Contains(task))
            {
                output = $"Task {task} already exists.";
            }
            else
            {
                _tasks.Add(task);
                output = $"Task {task} added.";
            }
            return $"\n{output}";
        }

        public string RemoveTask()
        {
            string output;
            Console.WriteLine("Enter the name of the task to remove:");
            string? task = Console.ReadLine();
            if (string.IsNullOrEmpty(task))
            {
                output = "Task cannot be empty.";
            }
            else if (_tasks.Contains(task))
            {
                _tasks.Remove(task);
                output = $"Task {task} removed.";
            }
            else
            {
                output = $"Task {task} not found.";
            }
            return $"\n{output}";
        }

        public string PrintTasks()
        {
            string? taskString;
            //Console.WriteLine("Tasks:");
            //for (int i = 0; i < _tasks.Count; i++)
            //{
            //    Console.WriteLine($"Task {i + 1}: {_tasks[i]}");
            //}
            //Console.WriteLine("\nPress any key to continue...\n");
            //Console.ReadKey();

            taskString = $"Task List: \n[{string.Join(", ", _tasks)}]\n";

            return taskString;
        }
    }
}
