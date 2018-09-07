using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void TestParseStringToArrayStrings()
    {
      //This is the string to be searched in
      string input1 = "bread is my fave, i can not live without bread";

      WordModel testWordModel = new WordModel();

      string[] expectedWords = new string[] {"bread","is","my","fave","","i","can","not","live","without","bread"};
      Assert.AreEqual(expectedWords[1], testWordModel.ParseStringToArrayStrings(input1)[1]);
    }
  }
}
