using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
       
        Reference myReference = new Reference("Proverbs", 3, 5, 6);
        Scripture myScripture = new Scripture(myReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        myScripture.GetDisplayText();
        myScripture.HideRandomWords(3);
        myScripture.IsCompletelyHidden();

        Console.WriteLine("All stubs are connected and working!");
    }
}