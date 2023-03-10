using System;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    public class MoodTest
    {
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSadMood()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(result, "Sad");
        }
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnHappyMood()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Happy Mood");
            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMessage_WhenAnalyze_ShouldReturnHappyMood()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            string result = moodAnalyzer.AnalyzeMood();
            Assert.AreEqual(result, "Mood should not be Null");
        }
        [Test]
        public void GivenNullMood_WhenAnalyse_ShouldThrowMoodAnalysisException()
        {
            try
            {
                MoodAnalyzer mood = new MoodAnalyzer(null);
                string result = mood.AnalyzeMood();
                Assert.AreEqual(result, "Mood should not be Null");
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood Should not be Null", e.Message);
            }
        }
    }
}