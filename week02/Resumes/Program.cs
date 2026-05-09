using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Development";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Project Manager";
        job2._companyName = "Apple";
        job2._startYear = 2021;
        job2._endYear = 2025;


        // Console.WriteLine(job1._companyName);
        // Console.WriteLine(job2._companyName);

        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

    }


    //     public class Resume

    //     {
    //         // Keeps track of the person's name and a list of their jobs.

    //         public string _name = "";
    //         public string _job = "";
    //     }
}