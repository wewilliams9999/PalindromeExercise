using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {   
        //testing whether my IsAPalindromeMethod works correctly
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void TestPalindrome(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
