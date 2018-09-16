using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
      [TestMethod]
        public void WordCounter_ReturnProperView_View()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ViewResult indexView = controller.Index() as ViewResult;
            // ViewResult result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }
      // [TestMethod]
      //   public void WordCounter_ReturnViewAndNumberResult()
      //   {
      //     //Arrange
      //     WordCounterController controller = new WordCounterController();
      //
      //     //Act
      //     ViewResult resultView = controller.Result() as ViewResult;
      //     //Assert
      //     Assert.IsInstanceOfType(resultView, typeof(ViewResult));
      //     Assert.IsInstanceOfType(resultData, typeof(int));
      //   }
    }
}
