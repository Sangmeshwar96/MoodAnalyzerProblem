using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE
        }
        public ExceptionType type;
        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

        public MoodAnalyzerCustomException()
        {
        }
    }
}
