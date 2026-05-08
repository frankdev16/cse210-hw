using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Console.Write("What is the magic number?");
        // int myNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int myNumber = randomGenerator.Next(1, 101); // Picks a number between 1 and 100
        Console.Write("What is your magic number?");
        int yourNumber = int.Parse(Console.ReadLine());

        string choice = "";
        while (myNumber != yourNumber)
        {

            if (myNumber > yourNumber)
            {
                Console.WriteLine($"My number is higher than your number {yourNumber}");
            }
            else if (myNumber < yourNumber)
            {
                Console.WriteLine($"My number is lower than your number {yourNumber}");
            }

            else
            {
                Console.WriteLine($"Our numbers are same");
            }

            // Console.WriteLine($"Your number {yourNumber} is not equal to mine");
            Console.Write("Do you want to continue? enter Yes or No ");
            choice = Console.ReadLine();

            if (choice == "Yes")
            {
                Console.Write("What is your magic number? ");
                yourNumber = int.Parse(Console.ReadLine());
                // yourNumber = newNumber;
            }

            if (choice == "No")
            {
                Console.WriteLine("See ya later!");
                break;
            }

        }

        if (myNumber == yourNumber)
        {
            Console.WriteLine("Congratulations! You guessed the magic number!");
        }
        // int newNumber;
        // myNumber = newNumber;






    }
}