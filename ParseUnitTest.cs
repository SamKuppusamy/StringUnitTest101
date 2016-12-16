using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParsingApp;
using System.Collections.Generic;

namespace ParseAppUnitTestProject001
{
    [TestClass]
    public class ParseUnitTest
    {
        [TestMethod]
        public void ParseWordTestMethod()
        {
            string testSentence = "Where are you, going today?";
            string finalSentence = string.Empty;
            List<string> myLst = WordParser.ReadSentence(testSentence);

            foreach (var item in myLst)
            {
                finalSentence = finalSentence + WordParser.ConvertWordAfterRules(item) + " ";
            }
            finalSentence = finalSentence.Trim();

            // Assert.AreSame("xyz", finalSentence);
            Assert.AreEqual("W3e a1e y1u, g3g t3y?", finalSentence);
        }

        [TestMethod]
        public void StartProcessTestMethod()
        {
            string testSentence = "Where are you, going today?";
            string finalSentence = string.Empty;
            finalSentence = WordParser.start_Processing(testSentence);

            // Assert.AreSame("xyz", finalSentence);
            Assert.AreEqual("W3e a1e y1u, g3g t3y?", finalSentence);
        }
    }
}