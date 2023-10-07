using System;

class Program
{
    static void Main(string[] args)
    {
        bool showMenu = true;
        while(showMenu)
        {
            showMenu = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        Journal journal = new Journal();
        
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("\nPlease select one of the following options:");
        Console.WriteLine("\n1. Write an Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Load a Journal");
        Console.WriteLine("4. Save Journal");
        Console.WriteLine("0. Exit");
        Console.Write("\nWhat would you like to do? ");
        switch (Console.ReadLine())
        {
            case "0": // need to include exceptions later
            return false;

            case "1":
            string prompt = PromptGenerator.PromptRandomizer();
            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.WriteLine();
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("g");
            string response = Console.ReadLine();
            journal.AddEntry(prompt, date, response);
            return true;

            case "2": //maybe try the Show method later
            journal.DisplayAllEntries();
            return true;

            case "3":
            Console.Write("\nPlease, enter the name of the file you would like to load: ");
            string _fileToLoad = Console.ReadLine();
            journal._loadFiles = _fileToLoad;
            Console.WriteLine();
            journal.LoadJournal();
            return true;

            case "4":
            Console.Write("\nChoose the name of the file you would like to save: ");
            string _fileName = Console.ReadLine();
            journal._saveFiles = _fileName;
            Console.WriteLine();
            journal.SaveJournal();
            return true;

            default:
            Console.WriteLine("\nThis option is not valid. Please, try a different option.");
            return true;
        }
    }
}