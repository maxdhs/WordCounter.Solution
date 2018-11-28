using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
    {
        [TestMethod]
        public void WordConstructor_ConfirmUserWordInput_Bool()
        {   
            string testWord = "rain";
            string testSentence = "the rain was fierce yesterday.";
            Word myWord = new Word(testWord, testSentence);
            Assert.AreEqual(testWord, myWord.GetWord());
        }

        [TestMethod]
        public void WordConstructor_ConfirmUserSentenceInput_Bool()
        {   
            string testWord = "red";
            string testSentence = "the red door was open.";
            Word myWord = new Word(testWord, testSentence);
            Assert.AreEqual(testSentence, myWord.GetSentence());
        }

        [TestMethod]
        public void WordConstructor_ConfirmUserInputIsString_Bool()
        {
            Word myWord = new Word("dog", "the dog went for a walk.");
            Assert.AreEqual(myWord.GetWord() is string, myWord.GetSentence() is string);
        }

        [TestMethod]
        public void RepeatCounter_CountNumberOfTimesWordAppears_Int()
        {
            string testWord = "dog";
            string testSentence = "I walked the dog and then the dog pooped";
            Word myWord = new Word(testWord, testSentence);
            Assert.AreEqual(2, myWord.RepeatCounter(testWord, testSentence));
        }

    }
}