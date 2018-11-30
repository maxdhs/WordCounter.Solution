using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordController : Controller
  {

    [HttpGet("/word")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/word/new")]
    public ActionResult New()
    {
      return View();
    }


    [HttpPost("/word")]
    public ActionResult Create(string userWord, string userSentence)
    {
      Word myWord = new Word(userWord, userSentence);
      return RedirectToAction("Index");
    }
  }
}