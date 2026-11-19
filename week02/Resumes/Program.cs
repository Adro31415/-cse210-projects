using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._companyName = "Tesla";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2028;
        job1._endYear = 2099;

        Job job2 = new Job();

        job2._companyName = "SpaceX";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2029;
        job2._endYear = 2090;
        
        Resume resume1 = new Resume();

        resume1._personName = "Junior";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResumeDetails();
    }
}