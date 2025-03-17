using System;
using System.Threading.Tasks.Dataflow;

public class Resume {

    public string _name;
 
    public List<Job> _jobs = new List<Job>();


    public void Display(){

        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Job Title: ");

        foreach (Job Job in _jobs){

            Job.Display();
        }
    }
}


