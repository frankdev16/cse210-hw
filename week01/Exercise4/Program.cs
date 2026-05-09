using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.Write("Enter a number? ");
        int number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            numbers.Add(number);

            Console.Write("Enter a number? ");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }


        int maxNum = numbers[0];
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > maxNum)
            {
                maxNum = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {maxNum}"); 

        double sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        double average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}"); 
        Console.WriteLine($"The average is: {average}"); 
    }
}