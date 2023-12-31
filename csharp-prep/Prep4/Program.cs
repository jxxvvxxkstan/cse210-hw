using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            
            if (userNumber!=0)
            {
                numbers.Add(userNumber);
            }
        }
//find sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
//find average
        float average = ((float)sum) / numbers.Count;

//find max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

//output results
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The Max is: {max}");

    }
}