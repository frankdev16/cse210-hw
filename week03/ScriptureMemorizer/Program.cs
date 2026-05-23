using System;
using System.Collections.Generic; // Added for the List of scriptures

// EXCEEDING REQUIREMENTS:
// To exceed core requirements, I added a "Scripture Library". 
// Instead of hardcoding a single scripture, the program loads a list 
// of 4 different scriptures and uses a Random number generator to 
// select one for the user to memorize each time the program runs.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>();

        Reference ref1 = new Reference("John", 3, 16);
        scriptureLibrary.Add(new Scripture(ref1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        scriptureLibrary.Add(new Scripture(ref2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        Reference ref3 = new Reference("Philippians", 4, 13);
        scriptureLibrary.Add(new Scripture(ref3, "I can do all things through Christ which strengtheneth me."));

        Reference ref4 = new Reference("1 Nephi", 3, 7);
        scriptureLibrary.Add(new Scripture(ref4, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[index];

        string userInput = "";

        while (userInput != "quit" && selectedScripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                selectedScripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("\nGreat job! See you next time.");
    }
}