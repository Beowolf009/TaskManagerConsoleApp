




namespace TaskTrackerApp2
{
    public class Task
    {
        public string Title { get; set; }
        public Task(string title)
        {
            Title = title;
        }
    }

    public class TaskCreation
    {
        public static Task CreateTask()
        {
            //prompt the user to enter a title
            Console.WriteLine("Enter a title for the task.");

            //read user input
            string title = Console.ReadLine();
            //create a new task object with the entered title
            Task task = new Task(title);

            return task;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> taskList = new List<Task>();

            Console.WriteLine("Current Tasks");
            foreach (Task task in taskList) {
                Console.WriteLine(task.Title);
            }
            //create a new task
            Task newTask = TaskCreation.CreateTask();
            taskList.Add(newTask);

            Console.WriteLine("\nUpdated Tasks: ");
            foreach(Task task in taskList)
            {
                Console.WriteLine(task.Title);
            }
        //wait for user input before exiting
        Console.WriteLine("Press any key to exit.....");
            Console.ReadKey();
        
        }


    }
}