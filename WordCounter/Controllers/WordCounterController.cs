using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/wordcounter")]
        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("Hey, I'm in the /wordCounter route");
            return View();
        }

        // [HttpGet("/wordcouter/new")]
        // public ActionResult Form()
        // {
        //     return View();
        // }

        [HttpPost("/result")]
        public ActionResult Result()
        {
            string inputWord = Request.Form["word"];
            string inputString = Request.Form["sentence"];
            System.Diagnostics.Debug.WriteLine(inputString);
            int numberOfWordsInInputText = WordModel.CountWordsInText(inputWord, inputString.Split(' '));
            return View("Result", numberOfWordsInInputText);

        }





    }
}
