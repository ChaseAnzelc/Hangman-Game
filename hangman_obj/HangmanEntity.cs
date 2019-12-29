using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hangman_obj
{
    public class HangmanEntity
    {
        public string WinningWord { get; set; }
        public string DisplayWordString { get; set; }
        public string GuessedLetter { get; set; }
        public List<string> GuessList { get; set; }
        public List<string> WrongGuessList { get; set; }
        public string Guesses { get; set; }
        public string WrongGuesses { get; set; }
        public int WrongGuessCount;
        public int CorrectGuessCount;

        public HangmanEntity()
        {
            WrongGuessCount = 0;
            CorrectGuessCount = 0;
            WinningWord = string.Empty;
            DisplayWordString = string.Empty;
            GuessedLetter = string.Empty;
            GuessList = new List<string>();
            WrongGuessList = new List<string>();
            Guesses = string.Empty;
            WrongGuesses = string.Empty;
        }

        public bool GameIsFinished()
        {
            return ((WrongGuessCount == 7) || (CorrectGuessCount ==  WinningWord.Length));
        }

        public bool UserWon()
        {
            return (CorrectGuessCount == WinningWord.Length);
        }

        public bool UserLost()
        {
            return (WrongGuessCount == 7);
        }
    }
}