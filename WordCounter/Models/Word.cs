namespace WordCounter
{
  public class Word
  {
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