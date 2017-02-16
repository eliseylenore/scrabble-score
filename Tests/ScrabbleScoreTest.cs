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
    }
}
