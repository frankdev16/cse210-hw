using System;

// EXCEEDING REQUIREMENTS:
// I added a feature to keep a log of how many total activities the user performs 
// during their session. It tracks the count and displays a customized farewell message 
// showing their total session accomplishments when they choose to quit.

class Program
{
    static void Main(string[] args)
    {
        int activityLog = 0;
        string choice = "";

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
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                activityLog++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                activityLog++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                activityLog++;
            }
        }

        Console.WriteLine($"\nThank you for taking time for yourself today.");
        Console.WriteLine($"You completed {activityLog} mindfulness activities this session. Goodbye!\n");
    }
}