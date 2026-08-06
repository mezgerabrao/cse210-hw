using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // I added a simple session counter that tracks how many activities the user completed
        // during this run of the program and displays it when the user quits.

        string choice = "";
        int completedActivities = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                completedActivities++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                completedActivities++;
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                completedActivities++;
            }
            else if (choice == "4")
            {
                Console.WriteLine($"You completed {completedActivities} activities this session.");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose again.");
                Thread.Sleep(2000);
            }
        }
    }
}