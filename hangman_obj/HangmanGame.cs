using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman_obj
{
    public class HangmanGame
    {
        private HangmanUtils utils;
        private HangmanEntity hangmanEntity;
        private HangmanWordList wordList;
        private HangmanGallows gallows;
        private string letterGuess;

        public HangmanGame()
        {
            hangmanEntity = new HangmanEntity();
            utils = new HangmanUtils(); ;
            wordList = new HangmanWordList();
            gallows = new HangmanGallows();
        }

        public void PlayGame()
        {
            SelectWinningWord();
            //DisplayWinningWord();
            utils.GenerateDisplayWordString(hangmanEntity);
            do
            {
                DisplayGallows();
                DisplayMatchedGuesses();
                DisplayWrongGuesses();
                PromptUserForLetter();
                CheckUserGuess();
            } while (!hangmanEntity.GameIsFinished());
            DisplayEpiloque();
        }

        private void DisplayEpiloque()
        {
            if (hangmanEntity.GameIsFinished() && hangmanEntity.UserWon())
            {
                Console.WriteLine("YAY ! YOU WIN !!");
            }
            else
            {
                Console.WriteLine("Sorry, you lost");
            }
            DisplayGallows();
            DisplayWinningWord();
        }

        public void DisplayWinningWord()
        {
            Console.WriteLine("\n{0}", hangmanEntity.WinningWord);
        }

        private void SelectWinningWord()
        {
            hangmanEntity.WinningWord = wordList.GetWinningWord();
        }

        private void PromptUserForLetter()
        {
            do
            {
                Console.Write("Enter a guess for a letter: ");
                letterGuess = Console.ReadLine();
            } while (utils.CheckAlreadyGuessed(hangmanEntity, letterGuess));

            hangmanEntity.GuessList.Add(letterGuess);
        }
        
        private void CheckUserGuess()
        {
            utils.CheckLatestGuess(hangmanEntity, letterGuess);
            utils.GenerateDisplayWordString(hangmanEntity);
        }

        private void DisplayWrongGuesses()
        {
            Console.WriteLine(hangmanEntity.WrongGuesses);
            Console.WriteLine("");
        }

        private void DisplayMatchedGuesses()
        {
            Console.WriteLine(hangmanEntity.DisplayWordString);
            Console.WriteLine("");
        }

        private void DisplayGallows()
        {
            gallows.DisplayGallows(hangmanEntity.WrongGuessCount);
        }
    }
}
