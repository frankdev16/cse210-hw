using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // int x = 6;

        // int y = 3;

        Console.Write("Enter your score? ");
        int score = int.Parse(Console.ReadLine());

        // Console.Write("enter a number? ");
        // int secNum = int.Parse(Console.ReadLine());

        string grade;

        string sign;

        if (score % 10 >= 7 && score < 93 && score >= 60)
        {
            sign = "+";
        }
        else if (score % 10 < 3 && score != 100 && score >= 60)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (score >= 90)
        {
            grade = "A";
            Console.WriteLine($"You Got an {grade}{sign}");
        }

        else if (score >= 80)
        {
            grade = "B";
            Console.WriteLine($"You Got a {grade}{sign}");
        }
        else if (score >= 70)
        {
            grade = "C";
            Console.WriteLine($"You Got a {grade}{sign}");
        }
        else if (score >= 60)
        {
            grade = "D";
            Console.WriteLine($"You Got a {grade}{sign}");
        }
        else
        {
            grade = "F";
            Console.WriteLine($"You Got an {grade}{sign} ");
        }

        if (score >= 70)
        {
            Console.WriteLine("Congratulations you passed😎");
        }

        else
        {
            Console.WriteLine("Sorry you failed😔");
        }
    }
}

    