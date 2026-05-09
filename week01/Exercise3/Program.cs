using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int myNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your magic number?");
        int yourNumber = int.Parse(Console.ReadLine());

        while (myNumber != yourNumber)
        {
            if (myNumber > yourNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (myNumber < yourNumber)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            yourNumber = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");
    }
}