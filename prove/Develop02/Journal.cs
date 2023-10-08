using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _saveFiles;
    public string _loadFiles;
    public List<Entry> _allEntries = new List<Entry>();

    public void AddEntry(string _prompt, string _date, string _response)
    {
        Entry entry = new Entry(_prompt, _date, _response);
        _allEntries.Add(entry);
    }

    public void SaveJournal()
    {
        using StreamWriter _journalWriter = new StreamWriter(_saveFiles, true);
        foreach (Entry file in _allEntries)
        {
            _journalWriter.Write(file.StoreEntries());
            _journalWriter.Close();
        }
    }
    public void LoadJournal()
    {
        string[] files = File.ReadAllLines(_loadFiles);
        foreach (string file in files)
        {
            string[] parts = file.Split("|");
            string _loadDate = parts[0];
            string _loadPrompt = parts[1];
            string _loadResponse = parts[2];

            Console.WriteLine($"{_loadDate}\n{_loadPrompt}\n{_loadResponse}");
        }
    }

    public void DisplayAllEntries()
    {
        foreach (Entry file in _allEntries)
        {
            file.DisplayEntries();
        }
    }
}