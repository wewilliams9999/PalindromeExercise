using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome (string word)
        {
            //see if word is a palindrome
            //is reverse of word the same as word
            //how do i reverse a word?
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string (charArray);

            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
