using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

       
        Assignment assignment = new Assignment("Peter", "Algebra");
        Console.WriteLine(assignment.GetSummary());

        // assignment._studentName = "Peter";
        // assignment._topic = "Peter";
        MathAssignment mathobj = new MathAssignment("7.3", "8 - 19", "Peter", "Algebra");
        Console.WriteLine(mathobj.GetHomeworkList());

        WritingAssignment writingObj = new WritingAssignment("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(writingObj.GetWritingInformation());

    }
}