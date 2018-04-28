using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTests
  {
    [TestMethod]
    public void Count_Word()
    {
      string _word = "Hello";
      int count = 0;
      foreach(char letter in _word)
      {
        // count += 1;

      if(letter == 'l')
      {
        count += 1;

      }
       Console.WriteLine("The letter is:"+letter);
               Console.Write("Count is :" + count);
    }
  }
  [TestMethod]
  public void Count_Others()
  {
    string _word = "Word";
    int count = 0;
    foreach(char letter in _word)
    {
      if(letter == 'a'){
        count += 1;
      }
    else
    {
      count = 0;

    }
    Console.Write("False" + count);
  }
}
}
}
