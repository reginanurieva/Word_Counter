using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangMan.Models;

namespace HangMan.Tests
{
  [TestClass]
  public class HangManTests
  {
    [TestMethod]
    public void TestPickRandomWord()
    {
      //Arrange
      HangManGame newHangManGame = new HangManGame();

      //Act
      string mySolution = newHangManGame.GetSolution();
      int mySpaces = newHangManGame.GetSpaces();
      //type nameOfVariable = ...

      //Assert
      Assert.IsTrue(mySolution.Length > 0);
      Assert.IsTrue(mySpaces > 0);
    }
  }
}
