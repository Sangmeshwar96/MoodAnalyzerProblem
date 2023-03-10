using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyzerProblem.MoodAnalyzerCustomException;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    if (message.Equals(" "))
                    throw new MoodAnalyzerCustomException(ExceptionType.EMPTY_MESSAGE, "Mood Should not be empty");
                else if (message.Equals(null))
                    throw new MoodAnalyzerCustomException(ExceptionType.NULL_MESSAGE, "Mood Should not be null");
                else
                    return "Happy";
            }
            catch(NullReferenceException)
            {
                return "Mood should not be Null";
            }
            catch(MoodAnalyzerCustomException)
            {
                return "Mood should not be Empty";
            }
        }
    }
}
