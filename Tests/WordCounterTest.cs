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
  }
}
