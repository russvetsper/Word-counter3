using Xunit;
using System;

namespace WordCounting
{
  public class WordCounterTest
  {

    [Fact]
    {
      public void Test1_Comparing_letterAToLetterA_1()
      {
        ReapetCounter testCounter = new ReapetCounter("a","a");
        Assert.Equal(1, testCounter.CountRepeats());
      }
    }
  }
}
