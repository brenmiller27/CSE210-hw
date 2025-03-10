using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("Try to guess a magic number. Good Luck!");

        Random randomNumberGenerator = new Random();

        int Number = randomNumberGenerator.Next(1,100);

        int guess = -1;

        while (guess != Number) {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            

            if (guess > Number) {
                Console.WriteLine("Lower");
            }

            else if (guess < Number) {
                Console.WriteLine("Higher");
            }

            else {
                Console.WriteLine("Correct");
            }


        }



    }


}