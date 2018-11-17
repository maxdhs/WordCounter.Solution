using System;

namespace WordCounter
{
  
  public class Program
  {
    public static void Main()
    {
      Word myWord = new Word();
      Console.WriteLine("Please enter a word: ");
      string userWord = Console.ReadLine();
      Console.WriteLine("Please enter a sentence: ");
      string userSentence = Console.ReadLine();
      Console.WriteLine("Your word appears " + myWord.RepeatCounter(userWord, userSentence) + " times.");
      Console.ReadLine();
    }
  }
  
  public class Word
  {
    
    public bool IsUserInputStrings (string UserWord, string UserSentence)
    {
        return UserWord is string && UserSentence is string;
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