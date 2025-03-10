using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What was your grade for this class this semester? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";


        if (number >= 90) {
            letter = "A";
        }

        else if (number >=80) {
           letter = "B";

        }

         else if (number >=70) {
            letter = "C";

        }

         else if (number >=60) {
            letter = "D";

        }

         else if (number <=60) {
            letter = "F";

        }

        Console.WriteLine($"Your grade was an {letter} ");

        if (number >=70) {

            Console.WriteLine("Great you passed");

        }

        else if (number<=50) {

            Console.WriteLine("Better luck next time");

        }




    }
}