using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess favorite number betweeen 1 and 1000.");
            var r = new Random();
            var favNumber = r.Next(1, 1000); // change back to 1000 after testing

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (userInput == favNumber) 
            {
                Console.WriteLine("You guessed correctly!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
