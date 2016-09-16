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

      
  }
}
