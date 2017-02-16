using Xunit;
using ScrabbleScoreApp.Objects;
using System;
using System.Collections.Generic;

namespace ScrabbleScoreApp
{
    public class ScrabbleScoreTest
    {
        //Test to see if the user's word is returned
        [Fact]
        public void ReturnWord_ReturnUserInput_String()
        {
            //arrange
            string word = "word";
            ScrabbleScore newScrabbleScore = new ScrabbleScore("word");
            //act
            string result = newScrabbleScore.GetUserInput();
            //assert
            Assert.Equal(word, result);
        }

        //Test to see if user input is broken down into individualcharacters
        [Fact]
        public void SplitWord_BreakUserInputUpInto_Array()
        {
            //arrange
            char[] splitWordArray = new char[] { 'w', 'o', 'r', 'd' };
            ScrabbleScore newScrabbleScore = new ScrabbleScore("word");
            //act
            char[] result = newScrabbleScore.SplitWord();
            //assert
            Assert.Equal(splitWordArray, result);
        }
    }
}
