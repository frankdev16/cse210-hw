using System;

// EXCEEDING REQUIREMENTS:
// I added a Leveling and Rank system inside the GoalManager.cs file. 
// Every time the user crosses a 1000-point threshold, they level up 
// and earn a new title (e.g., Novice, Apprentice, Journeyman, Master). 
// This title and level are displayed every time the menu is shown, 
// adding a strong gamification element to keep the user motivated.

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}