﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string message)
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
                return "Happy";
        }
    }
}