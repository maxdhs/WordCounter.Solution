namespace WordCounter
{
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