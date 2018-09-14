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
            return View();
        }

        // [HttpGet("/wordcouter/new")]
        // public ActionResult Form()
        // {
        //     return View();
        // }

        [HttpPost("/wordcounter/result")]
        public ActionResult Result()
        {
            string inputWord = Request.Form["word"];
            string inputString = Request.Form["sentence"];
            Dictionary<string,object> Result = new Dictionary<string,object>{};
            return View("Form");
            // CheckWord newWord = new CheckWord(Request.Form["/wordcounter"]);
            // List<CheckWord> allCheckWords= CheckWord.GetAll();
            // // newWordCounter.SaveWordCounter();
            // // List<CheckWord> allWordCounter = WordCounter.GetAll();
            // return View("Index", allCheckWords);
        }


    }
}
