using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
    public class WordCounter : Controller
    {
        [HttpGet("/wordcouter")]
        public ActionResult Index()
        {
            List<WordCounter> allWordCounter = WordCounter.GetAll();
            return View(allWordCounter);
        }

        [HttpGet("/wordcouter/new")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/wordcouter")]
        public ActionResult NewWordCounter()
        {
            WordCounter newWordCounter = new WordCounter(Request.Form["sentence"], Request.Form["word"]);
            // newWordCounter.SaveWordCounter();
            List<WordCounter> allWordCounter = WordCounter.GetAll();
            return View("Index", allWordCounter);
        }
        [HttpGet("/wordcouter/{id}")]
        public ActionResult Form(int id)
        {
          WordCounter place = WordCounter.Find(id);
          return View(place);
        }


    }
}
