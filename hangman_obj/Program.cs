using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman_obj
{
    /*  Line Count:
    Program:         19
    HangmanEntity:   48
    HangmanGallows:  25
    HangmanGame:     100
    HangmanUtils:    83
    HangmanWordList: 37    ( total: 312 )   */

    public class Program
    {
        public static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();
            game.PlayGame();
            Console.ReadLine();
        }
    }
}
