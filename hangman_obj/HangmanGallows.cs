using System;
using System.IO;

namespace hangman_obj
{
    public class HangmanGallows
    {
        private string[] bodyParts;

        public HangmanGallows()
        {
            bodyParts = new string[] { " O\n", "\\", "|", "/\n", " |\n", "/", " \\\n" };
        }

        public void DisplayGallows(int wrongGuessCount)
        {
            Console.WriteLine("\n\n");
            for (int i = 0; i < wrongGuessCount; i++)
            {
                Console.Write(bodyParts[i]);
            }
            Console.WriteLine("\n\n");
        }
    }
}