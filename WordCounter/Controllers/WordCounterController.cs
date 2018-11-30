using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordController : Controller
  {

    [HttpGet("/word/new")]
    public ActionResult New()
    {
      return View();
    }

     [Route("/word")]
    public ActionResult Index(string userWord, string userSentence)
    {
        Word myWord = new Word(userWord, userSentence);
        return View(myWord);
    }  
  }
}