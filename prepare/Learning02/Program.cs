using System;
using System.ComponentModel.DataAnnotations;


class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Hello Learning02 World!"); */

        Job job1 = new Job();
        job1._company = "Asus";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "Samsung";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Spencer Sedano";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }


}