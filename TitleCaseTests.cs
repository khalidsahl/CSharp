using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TitleCaseProblem
{
    /*
     * Title Capitalization Many writers are often confused by the different methods of capitalization
     * There are several forms of capitalization rules, but on of the most popular is called "title case" or "up style".
     * Implement a function that will take a title in the form of a string and return the string with correct capitalization
     * for a title according to these rules.
     * 
     * Always capitalize the first word in a title.
     * Always capitalize the last word in a title.
     * 
     * Lowercase the following words, unless they are the first or last word of the title: 
     * "a", "the", "to", "at", "in", "with", "and", "but", "or".
     * 
     * Uppercase any words not in the list above.
    */

    [TestClass]
    public class TitleCaseTests
    {

        [TestMethod]
        public void Example1()
        {
            var result = TitleCase("i love solving problems and it is fun");
            Assert.AreEqual("I Love Solving Problems and It Is Fun", result);
        }


        [TestMethod]
        public void Example2()
        {
            var result = TitleCase("wHy DoeS A biRd Fly?");
            Assert.AreEqual("Why Does a Bird Fly?", result);

        }

        // Split the title string by spaces
        // Capitalize word[0]
        // Captialize word[last]
        // For each word from word[1] to word[last-1]
        // If list contains the word
        // Lowercase word
        // Else
        // Capitalize word
        // Combine words into sentence

        public string TitleCase(string title)
        {

            LinkedList<string> wordsList = new LinkedList<string>();
            string[] listToCheck = { "a", "the", "to", "in", "with", "and", "but", "or" };
            string[] words = title.Split(null);
            var last = words.Length - 1;
            var firstWord = CapitalizeWord(words[0]);
            var lastWord = CapitalizeWord(words[last]);

            wordsList.AddFirst(firstWord);
            for (var i = 1; i <= last - 1; i++)
            {
                if (listToCheck.Contains(words[i], StringComparer.OrdinalIgnoreCase))
                {
                    wordsList.AddLast(LowercaseWord(words[i]));
                }
                else
                {
                    wordsList.AddLast(CapitalizeWord(words[i]));
                }
            }
            wordsList.AddLast(lastWord);
            var sentence = string.Join(" ", wordsList);
            return sentence;
        }

        /*
         * Alternative solution. No need for linkedlist. Sort using words list.
        public string TitleCase(string title)
        {
            var listToCheck = new[] { "a", "the", "to", "in", "with", "and", "but", "or" };
            var words = title.Split(null);

            //Loop through all words in the array 
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0 || i == (words.Length - 1) || !listToCheck.Contains(words[i], StringComparer.OrdinalIgnoreCase))
                {
                    words[i] = CapitalizeWord(words[i]);
                }
                else
                {
                    words[i] = LowercaseWord(words[i]);
                }
            }
            return string.Join(" ", words);
        }
        */

        // Capitalize word
        // Lowercase word
        // Capitalize word[0]
        public string CapitalizeWord(string word)
        {
            string lowercase = word.ToLower();
            char[] a = lowercase.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        // Lowercase word
        // foreach letter in word
        // Lowercase letter
        public string LowercaseWord(string word)
        {
            string lowercase = word.ToLower();
            return lowercase;
        }
    }
}
