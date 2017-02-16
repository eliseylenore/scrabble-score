using System;
using System.Collections.Generic;

namespace ScrabbleScoreApp.Objects
{
    public class ScrabbleScore
    {
        private string _userInput;

        public ScrabbleScore(string userInput)
        {
            _userInput = userInput;
        }

        public string GetUserInput()
        {
            return _userInput;
        }

        public string[] SplitWord()
        {

            string[] sentenceSplitArray = new string[] {"this", "sentence"};
            return sentenceSplitArray;
        }
    }
}
