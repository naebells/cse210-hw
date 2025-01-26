using System;

public class Resume
{
    public string _personName;
    public List<Job> _jobList = new List<Job>();
    public void Display()
    {
        Console.WriteLine("Name: Nathan Pack");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobList)
        {
            job.Display();
        }
    }
}