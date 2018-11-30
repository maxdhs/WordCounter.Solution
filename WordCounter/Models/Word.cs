using System;

namespace WordCounter.Models
{
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

    public int RepeatCounter()
    {
        string[] userSentenceArr = _userSentence.Split();
        int wordCount = 0;
        
        for(int x = 0; x < userSentenceArr.Length; x++)
        {
          if (userSentenceArr[x] == _userWord)
          {
            wordCount++;
          }
        }
        return wordCount;
    }

  }
}