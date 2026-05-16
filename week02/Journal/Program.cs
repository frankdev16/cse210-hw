using System;

// EXCEEDING REQUIREMENTS:
// To exceed the core requirements, I added a "Mood" tracker to the Entry class. 
// When the user writes a new entry, the program asks them for their current mood. 
// This mood is saved as a specific variable, displayed nicely when reading the journal, 
// and properly saved/loaded from the text file using our custom separators.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string userChoice = "";

        Console.WriteLine("Hello World! This is the Journal Project.");

        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = promptGen.GetRandomPrompts();
                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("What is your mood right now? ");
                string currentMood = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = currentMood;

                myJournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                // DISPLAY 
                myJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                // LOAD 
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.ReadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                // SAVE 
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (userChoice != "5")
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}