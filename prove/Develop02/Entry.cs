using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
  public string Prompt {get;}
  public string Date{get;}
  public string Response {get;}
  public Entry(string _prompt, string _date, string _response)
  {
    Prompt = _prompt;
    Date = _date;
    Response = _response;
  }
  public string StoreEntries()
  {
    string _storePrompt = Prompt;
    string _storeDate = Date;
    string _storeResponse = Response;
    return $"{_storeDate} | {_storePrompt} | {_storeResponse}";
  }
  public void DisplayEntries()
  {
    Console.WriteLine($"{Date}\n{Prompt}\n{Response}");
    Console.WriteLine("\n***********************************");
  }
}