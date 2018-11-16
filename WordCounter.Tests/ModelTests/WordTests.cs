using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
    {
        [TestMethod]
        public void RepeatCounter_CountNumberOfTimesWordAppears_Int()
        {
            string testWord = "dog";
            string testSentence = "I walked the dog";

            Word myWord = new Word();
            Assert.AreEqual(1, myWord.RepeatCounter(testWord, testSentence));
        }
    }
}