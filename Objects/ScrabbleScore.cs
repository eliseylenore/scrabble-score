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
                if (Array.IndexOf(_valueOfOne, letter) >= 0)
                {
                    _letterScore += (letter + " = 1, ");
                }
                if (Array.IndexOf(_valueOfTwo, letter) >= 0)
                {
                    _letterScore += (letter + " = 2, ");
                }
                if (Array.IndexOf(_valueOfThree, letter) >= 0)
                {
                    _letterScore += (letter + " = 3, ");
                }
                if (Array.IndexOf(_valueOfFour, letter) >= 0)
                {
                    _letterScore += (letter + " = 4, ");
                }
                if (Array.IndexOf(_valueOfFive, letter) >= 0)
                {
                    _letterScore += (letter + " = 5, ");
                }
                if (Array.IndexOf(_valueOfEight, letter) >= 0)
                {
                    _letterScore += (letter + " = 8, ");
                }
                if (Array.IndexOf(_valueOfTen, letter) >= 0)
                {
                    _letterScore += (letter + " = 10, ");
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
                if (Array.IndexOf(_valueOfOne, letter) >= 0)
                {
                    _totalScore += 1;
                }
                if (Array.IndexOf(_valueOfTwo, letter) >= 0)
                {
                    _totalScore += 2;
                }
                if (Array.IndexOf(_valueOfThree, letter) >= 0)
                {
                    _totalScore += 3;
                }
                if (Array.IndexOf(_valueOfFour, letter) >= 0)
                {
                    _totalScore += 4;
                }
                if (Array.IndexOf(_valueOfFive, letter) >= 0)
                {
                    _totalScore += 5;
                }
                if (Array.IndexOf(_valueOfEight, letter) >= 0)
                {
                    _totalScore += 8;
                }
                if (Array.IndexOf(_valueOfTen, letter) >= 0)
                {
                    _totalScore += 10;
                }
            }
            return _totalScore;
        }
    }
}
