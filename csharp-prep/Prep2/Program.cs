using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inputGrade = Console.ReadLine();
        int gradePercent = int.Parse(inputGrade);

        string letter = "";

        if (gradePercent>=90)
        {
            letter = "A";
        }
        else if (gradePercent>=80)
        {
            letter = "B";
        }
        else if (gradePercent>=70)
        {
            letter = "C";

        }
        else if (gradePercent>=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is: {letter}.");
        
        if (gradePercent>=70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. Better luck next time.");
        }

    }
}