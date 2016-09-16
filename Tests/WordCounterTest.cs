using Xunit;
using System;

namespace WordCounter
{
  public class WordCounterTest
  {

    [Fact]
      public void Test1_Comparing_letterAToLetterA_1()
      {
        RepeatCounter testCounter = new RepeatCounter("a","a");
        Assert.Equal(1, testCounter.CountRepeats());
      }

    [Fact]
      public void Test2_Comparing_letterAtoLettersABA_2()
      {
        RepeatCounter testCounter = new RepeatCounter("a","a d a");
        Assert.Equal(2, testCounter.CountRepeats());
      }

    [Fact]
      public void Test3_Comapring_wordRedToMyCarIsRed_1()
      {
      RepeatCounter testCounter = new RepeatCounter("red","my car is red");
      Assert.Equal(1, testCounter.CountRepeats());
      }

    [Fact]
    public void Test4_Comapring_letterAToLetterC_0()
    {
    RepeatCounter testCounter = new RepeatCounter("a","c");
    Assert.Equal(0, testCounter.CountRepeats());
    }

    //another way to test for true or fals

    [Fact]
    public void Get5_TwoWordsMatchInPhrase_true()
    {
      string wordToFind = "super";
      string stringToSearch = "super super fun";
      RepeatCounter testNewWord = new RepeatCounter(wordToFind,stringToSearch);
      int count = testNewWord.CountRepeats();

      Assert.Equal(2, count);
    }


  }
}
