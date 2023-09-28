using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string inputNumber = Console.ReadLine();
        //int magicNumber = int.Parse(inputNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess!=magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine()); //simplified version

            if (guess<magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess>magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
} 