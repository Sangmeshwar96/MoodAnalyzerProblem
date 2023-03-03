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
    }
}