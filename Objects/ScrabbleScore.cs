using System;
using System.Collections.Generic;

namespace ScrabbleScoreApp.Objects
{
    public class ScrabbleScore
    {
        private string _userInput;
        private string _letterScore;
        private int _totalScore;
        private static char[] _valueOfOne = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
        private static char[] _valueOfTwo = { 'd', 'g' };
        private static char[] _valueOfThree = { 'b', 'c', 'm', 'p' };
        private static char[] _valueOfFour = { 'f', 'h', 'v', 'w', 'y' };
        private static char[] _valueOfFive = { 'k' };
        private static char[] _valueOfEight = { 'j', 'x' };
        private static char[] _valueOfTen = { 'q', 'z' };
        private static Dictionary<int, char[]> _allValues = new Dictionary<int, char[]>()
        {
            {1, _valueOfOne},
            {2, _valueOfTwo},
            {3, _valueOfThree},
            {4, _valueOfFour},
            {5, _valueOfFive},
            {8, _valueOfEight},
            {10, _valueOfTen}
        };

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

        public string FindLetterScore()
        {
            char[] userArray = this.SplitWord();
            _letterScore = "";
            foreach (char letter in userArray)
            {
                foreach (KeyValuePair<int, char[]> entry in _allValues)
                {
                    if (Array.IndexOf(entry.Value, letter) >= 0)
                    {
                        _letterScore += (letter + " = " + entry.Key + ", ");
                    }
                }
            }
            return _letterScore;
        }

        public int FindTotalScore()
        {
            char[] userArray = this.SplitWord();
            _totalScore = 0;
            foreach (char letter in userArray)
            {
                foreach (KeyValuePair<int, char[]> entry in _allValues)
                {
                    if (Array.IndexOf(entry.Value, letter) >= 0)
                    {
                        _totalScore += entry.Key;
                    }
                }
            }
            return _totalScore;
        }
    }
}
