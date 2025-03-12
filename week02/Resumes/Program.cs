using System;

class Program
{

    public class Job
    {
        public string _jobTitle;
        public string _company;
        public string _startYear;
        public string _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

    public class Resumes
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public void Display()
        {
            Console.WriteLine($"Name : {_name}");
            Console.WriteLine("Jobs : ");
            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2023";

        Job job2 = new Job();
        job2._jobTitle = "Ios Developer";
        job2._company = "Apple";
        job2._startYear = "2020";
        job2._endYear = "2026";

        Resumes myResumes = new Resumes();
        myResumes._name = "Benajamin Asante";
        myResumes._jobs.Add(job1);
        myResumes._jobs.Add(job2);

        myResumes.Display();
    }
}