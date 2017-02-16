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

        public char[] SplitWord()
        {

            return _userInput.ToCharArray();
        }
    }
}
