using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
    public class WordCountersController : Controller
    {
        [HttpGet("/wordcounter")]
        public ActionResult Index()
        {
            // inputWords = input1.Split(delimiterChars);
            return View("wordcounter");

        }

        // [HttpGet("/wordcouter/new")]
        // public ActionResult Form()
        // {
        //     return View();
        // }

        [HttpPost("/wordcounter")]
        public ActionResult NewWordCounter()
        {
            CheckWord newCheckWord = new CheckWord(Request.Form["sentence"]);
            List<CheckWord> allCheckWords= CheckWord.GetAll();
            // newWordCounter.SaveWordCounter();
            // List<CheckWord> allWordCounter = WordCounter.GetAll();
            return View("Index", allCheckWords);
        }


    }
}
