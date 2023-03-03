using System;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    public class MoodTest
    {
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
        [Test]
        public void GivenSadMessage_WhenAnalyze_ShouldReturnSadMood()
        {
            string result = moodAnalyzer.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(result, "Sad");
        }
    }
}