using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
    {
        [TestMethod]
        public void IsUserInputStrings_ConfirmUserInputIsString_Bool()
        {
            string testWord = "bread";
            string testSentence = "the bread baked in the oven";
            Word myWord = new Word();
            
            Assert.AreEqual(true, myWord.IsUserInputStrings(testWord, testSentence));
        }

        [TestMethod]
        public void RepeatCounter_CountNumberOfTimesWordAppears_Int()
        {
            string testWord = "dog";
            string testSentence = "I walked the dog and then the dog pooped";
            Word myWord = new Word();

            Assert.AreEqual(2, myWord.RepeatCounter(testWord, testSentence));
        }
    }
}