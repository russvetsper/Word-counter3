using System;
using System.Collections.Generic;


// setup namespace and class
namespace WordCounter
{
  // attribute and name of class
  public class RepeatCounter
  {
    //creating property inside a class
    private string  _wordToFind;
    private string _stringToSearch;

    //constructors
    public RepeatCounter(string wordToFind, string stringToSearch)
    {
      _wordToFind = wordToFind;
      _stringToSearch = stringToSearch;
    }

    //creatting getters and setters

    public string GetWordToFind()
    {
      return _wordToFind;
    }

    public void SetWordToFind(string wordToFind)
    {
      _wordToFind = wordToFind;
    }

    public string GetStringToSearch()
    {
      return _stringToSearch;
    }

    public void SetStringToSearch(string stringToSearch)
    {
      _stringToSearch = stringToSearch;
    }

    //method
    public int CountRepeats()
    {
      string[] stringToSearch = this._stringToSearch.ToLower().Trim().Split(' ');
      string newWordToFind = this._wordToFind.ToLower().Trim();
      if (this._wordToFind == " ")
      {
        return 0;
      }
      int count = 0;
      foreach (string wordToFind in stringToSearch)
      {
        if (wordToFind == newWordToFind)
        {
          count++;
        }
      }
      return count;


    }
  }
}
