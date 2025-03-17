using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobtitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startyear = 2019;
        job1._endyear = 2022;

        Job job2 = new Job();
        job2._jobtitle = "Software Engineer";
        job2._company = "Facebook";
        job2._startyear = 2023;
        job2._endyear = 2024;

        Resume MyResume = new Resume();

        MyResume._name = "Bren Miller";

        MyResume._jobs.Add(job1);
        MyResume._jobs.Add(job2);

        MyResume.Display();

        
    }
}