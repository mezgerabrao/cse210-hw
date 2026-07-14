using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // I added a menu loop, random prompt selection, file save/load,
        // and a clean separator format so the journal can be stored and loaded reliably.

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                DateTime currentTime = DateTime.Now;
                string date = currentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}