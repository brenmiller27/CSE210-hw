using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");

        String First = Console.ReadLine();

        Console.Write("What is your last name? ");

        String last = Console.ReadLine();

        Console.WriteLine($"My name is {last} , {First} {last}");
    }
}