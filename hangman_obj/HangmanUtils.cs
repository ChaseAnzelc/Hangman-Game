using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace hangman_obj
{
    public class HangmanUtils
    {
        public HangmanUtils()
        {
        }

        public bool CheckAlreadyGuessed(HangmanEntity model, string newGuess)
        {
            foreach(string temp in model.GuessList)
            {
                if (temp.Equals(newGuess))
                {
                    return true;
                }
            }
            return false;
        }

        public void GenerateDisplayWordString(HangmanEntity hangman)
        {
            StringBuilder sb = new StringBuilder();
            bool correctLetter = false;
            string winningWord = hangman.WinningWord;

            for (int i=0; i< winningWord.Length; i++)
            {
                correctLetter = false;
                foreach (string temp in hangman.GuessList)
                {
                    if (winningWord[i].ToString().Equals(temp))
                    {
                        correctLetter = true;
                    }
                }
                if(!correctLetter)
                {
                    sb.Append("_ ");
                }
                else
                {
                    sb.Append(winningWord[i].ToString()).Append(" ");
                }
            }
            hangman.DisplayWordString = sb.ToString();
        }

        public void CheckLatestGuess(HangmanEntity hangman, string newGuess)
        {
            StringBuilder sb = new StringBuilder();
            bool correctLetter = false;
            string winningWord = hangman.WinningWord;
            hangman.GuessList.Add(newGuess);
            for (int i = 0; i < winningWord.Length; i++)
            {
                if (winningWord[i].ToString().Equals(newGuess))
                {
                    hangman.CorrectGuessCount++;
                    correctLetter = true;
                }
            }
            if (!correctLetter)
            {
                hangman.WrongGuessCount++;
                hangman.WrongGuessList.Add(newGuess);
            }

            sb.Append("Wrong Guesses: ");
            foreach(string temp in hangman.WrongGuessList)
            {
                sb.Append(temp).Append(" ");
            }
            hangman.WrongGuesses = sb.ToString();
        }
    }
}