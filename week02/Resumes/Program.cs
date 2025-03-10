using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine();

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        job2.DisplayJobDetails();

        Resumes resume1 = new Resumes();
        resume1._name = "Anselem Obianuju Samuel";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Console.WriteLine(resume1._jobs[0]._jobTitle); This code was used to find the job title of the first
        // job details

        Console.WriteLine();
        resume1.DisplayResumes();
    }
}