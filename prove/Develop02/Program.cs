using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal journal = new Journal();
        bool showMenu = true;
        while (showMenu)
        {
            //Console.Clear();
            Console.WriteLine("\nPlease select one of the following options:");
            Console.WriteLine("\n1. Write an Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load a Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("0. Exit");
            Console.Write("\nWhat would you like to do? ");
           
            switch (Console.ReadLine())
            {
                case "0":
                Console.Write("\nWould you like to exit the program? (Yes or No) ");
                string _userInput = Console.ReadLine();
                if (_userInput.Trim().ToUpper() == "Y")
                {
                    showMenu = false;
                }
                Console.WriteLine("Program ended. Press any key to exit.");
                Console.ReadKey();
                break;

                case "1": //throw exception later
                string prompt = PromptGenerator.PromptRandomizer();
                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.WriteLine();
                DateTime dateTime = DateTime.Now;
                string date = dateTime.ToString("g");
                string response = Console.ReadLine();
                journal.AddEntry(prompt, date, response);
                break;

                case "2":
                Console.WriteLine();
                journal.DisplayAllEntries();
                break;

                case "3": //throw exception later
                Console.Write("\nPlease, enter the name of the file you would like to load: ");
                string _fileToLoad = Console.ReadLine();
                journal._loadFiles = _fileToLoad;
                Console.WriteLine();
                journal.LoadJournal();
                break;

                case "4": //throw exception later
                Console.Write("\nChoose the name of the file you would like to save: ");
                string _fileName = Console.ReadLine();
                journal._saveFiles = _fileName;
                Console.WriteLine();
                journal.SaveJournal();
                break;                

                default:
                Console.WriteLine("\nThis option is not valid. Please, try a different option.");
                Console.Clear();
                break;
            }
        }
    }
}