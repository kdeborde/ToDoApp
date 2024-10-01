
namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var runApp = true;

            ToDoList todo = new ToDoList();
            while (runApp)
            {
                Console.WriteLine("\nPlease enter a number corresponding to the action below or 'q' to quit.");
                Console.WriteLine("1.) Add task");

                // Check if there are any tasks in the list. Don't display unavailable options.
                if (todo.Tasks.Count > 0)
                {
                    Console.WriteLine("2.) Remove task");
                    Console.WriteLine("3.) View tasks");
                }

                string? userChoice = Console.ReadLine();
                if (string.IsNullOrEmpty(userChoice))
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'q' to quit.\n");
                    continue;
                }

                if (userChoice.Trim().ToLower() == "q")
                {
                    Console.WriteLine("Closing program... Press any key to continue.\n");
                    Environment.Exit(0);
                }

                try
                {
                    int choice = Convert.ToInt32(userChoice);
                    string? task = string.Empty;

                    // Task list is empty, invalidate choices.
                    if (todo.Tasks.Count < 1 && (choice == 2 || choice == 3))
                    {
                        Console.WriteLine("Invalid choice. The todo list is empty.");
                    }
                    else
                    {
                        switch (choice)
                        {

                            case 1:
                                Console.WriteLine(todo.AddTask());
                                break;
                            case 2:
                                Console.WriteLine(todo.RemoveTask());
                                break;
                            case 3:
                                Console.WriteLine(todo.PrintTasks());
                                break;
                            default:
                                Console.WriteLine("Invalid input. Please enter a number or 'q'.\n");
                                break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'q'.\n");
                }
            }
        }
    }
}
