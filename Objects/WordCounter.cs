using System;
using System.Linq;

// setup namespace and class
namespace WordCounter.Objects
{
  // attribute and name of class
  public class ReapetCounter
  {
    //creating property inside a class
    private string _wordToFind;
    private string _stringToSearch;

    public ReapetCounter(string wordToFind, string stringToSearch)
    {
      _wordToFind =wordToFind;
      _stringToSearch = stringToSearch;
    }

    //creatting getters and setters

    public string GetWordToFind()
    {
      return _wordToFind;
    }

    public void SetWordToFind(string newWordToFind)
    {
      _wordToFind = newWordToFind;
    }

    public string GetStringToSearch()
    {
      return _stringToSearch;
    }

    public void SetStringToSearch(string newStringToSearch)
    {
      _stringToSearch = newStringToSearch;
    }
    
  }
}
