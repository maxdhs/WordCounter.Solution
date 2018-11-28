using System;

namespace WordCounter
{
  
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word: ");
      string userWord = Console.ReadLine();
      Console.WriteLine("Please enter a sentence: ");
      string userSentence = Console.ReadLine();
      Word myWord = new Word(userWord, userSentence);
      Console.WriteLine("Your word appears " + myWord.RepeatCounter(userWord, userSentence) + " times.");
      Console.ReadLine();
    }
  }
  
  public class Word
  {
    private string _userWord;
    private string _userSentence;

    public Word (string userWord, string userSentence)
    {
      _userWord = userWord;
      _userSentence = userSentence;
    }

    public string GetWord()
    {
      return _userWord;
    }

    public string GetSentence()
    {
      return _userSentence;
    }

    public int RepeatCounter(string userWord, string userSentence)
    {
        string[] userSentenceArr = userSentence.Split();
        int wordCount = 0;
        
        for(int x = 0; x < userSentenceArr.Length; x++)
        {
          if (userSentenceArr[x] == userWord)
          {
            wordCount++;
          }
        }
        return wordCount;
    }

  }
}