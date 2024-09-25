using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Company 1";
        job1._jobTitle = "Customer Experience Agent";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._company = "Company 2";
        job2._jobTitle = "Customer Experience Agent";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Felipe Zardo Cabral";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
    }
}