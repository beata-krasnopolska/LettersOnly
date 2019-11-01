using System;

namespace LettersOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program removes any non-letters from a string, returning a word");

            string word1 = "R!=:~0o0./c&}9k`60=y";
            string word2 = "^,]%4B|@56a![0{2m>b1&4i4";
            string word3 = "^U)6$22>8p).";

            var wordFinder = new LettersFinder();
            wordFinder.Finder(word1);
            wordFinder.Finder(word2);
            wordFinder.Finder(word3);

            Console.ReadKey();
        }
    }
}
