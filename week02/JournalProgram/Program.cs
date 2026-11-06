using System;

class Program
{
    static void Main()
    {
        // Extra feature: This journal program helps reduce procrastination by showing
        // a random prompt and making it easy to save and load entries from a file.
        Journal journal = new Journal();

        Console.WriteLine("Welcome to your Journal Program!");

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = journal.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Write your response: ");
                string response = Console.ReadLine();

                journal.AddEntry(prompt, response);
                Console.WriteLine("Your entry was added.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter a file name: ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Journal saved to " + fileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter a file name: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("Journal loaded from " + fileName);
            }
            else if (choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please choose a valid option.");
            }
        }
    }
}
