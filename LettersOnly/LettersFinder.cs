using System;
using System.Linq;

namespace LettersOnly
{
    class LettersFinder
    {
        public void Finder(string word)
        {
            var hiddenWord = new string(word.Where(char.IsLetter).ToArray());

            Console.WriteLine("Word hidden in the ---   {0}   ----- is : {1}", word, hiddenWord);
        }
    }
}
