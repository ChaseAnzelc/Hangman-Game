using System;
using System.IO;

namespace hangman_obj
{
    public class HangmanWordList
    {
        private Random generator;
        private string filePath;
        private string[] words;

        public HangmanWordList() : this("wordlist.txt")
        {  }

        public HangmanWordList(string filePath)
        {
            generator = new Random((int)System.DateTime.Now.Ticks);
            this.filePath = filePath;
            ReadWordFile();
        }

        private void ReadWordFile()
        {
            words = File.ReadAllLines(filePath);
        }

        public int WordCount()
        {
            return words.Length;
        }

        public string GetWinningWord()
        {
            return words[generator.Next(words.Length)];
        }
    }
}