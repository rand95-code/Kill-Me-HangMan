using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangMan
{
    class HangManGame
    {   // checking for word 
        static bool IsWord(string secreword, List<string> letterGuessed)
        {

            bool word = false;
            // loop through secretword
            for (int i = 0; i < secreword.Length; i++)
            {
                // initialize c with the index of secretword[i]
                string c = Convert.ToString(secreword[i]);
                // check if c is in list of letters Guess
                if (letterGuessed.Contains(c))
                {
                    word = true;
                }
                /*if c is not in the letters guessed then we dont have the
                 * we dont have the full word*/
                else
                {
                    // change the value of word to false and return false
                    return word = false;

                }

            }
            return word;
        }

        // check for single letter 
        static string Isletter(string secretword, List<string> letterGuessed)
        {
            // set guessedword as empty string
            string correctletters = "";
            // loop through secret word
            for (int i = 0; i < secretword.Length; i++)
            {
                /* initialize c with the value of index i
                 * mean when i = 0
                 * c = secretword[0] is the first index of secretword
                 * c = secretword[1] is the second index of secretword and so on */
                string c = Convert.ToString(secretword[i]);

                // if c is in list of lettersGuessed 
                if (letterGuessed.Contains(c))
                {
                    // add c to correct letters
                    correctletters += c;
                }
                else
                {
                    // else print (__) to show that the letter is not in the secretword
                    correctletters += "_ ";
                }

            }
            // after looping return all the correct letters found
            return correctletters;

        }

        // The alphabet to use
        static void GetAlphabet(string letters)
        {
            List<string> alphabet = new List<string>();

            for (int i = 1; i <= 26; i++)
            {
                char alpha = Convert.ToChar(i + 96);
                alphabet.Add(Convert.ToString(alpha));
            }

            // for regulating the number of alphabet left
            int num = 49;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Letters Left are :");

            for (int i = 0; i < num; i++)
            {
                if (letters.Contains(letters))
                {
                    alphabet.Remove(letters);
                    num -= 1;
                }
                Console.Write("[" + alphabet[i] + "] ");
            }

            Console.WriteLine();

        }
        /* random strings
        static string randomword(string secretword) 
        {
           random rnd = new random();

        }*/


        static void Main()
        {
            Console.Title = ("HangMan");

            // secretWord


            List<string> letterGuessed = new List<string>();
            List<string> mySecrets = new List<string>();
            mySecrets.Add("superwoman");
            mySecrets.Add("nice");
            mySecrets.Add("powerful");
            mySecrets.Add("vip");

            int live = 5;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Hangman Game");

            // while live is greater than 0
            for (int k = 0; k < mySecrets.Count; k++)
            {
                string secretword = mySecrets[k];
                Console.WriteLine("Playing secret word #{0}", k + 1);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Guess for a {0} letter Word ", secretword.Length);
                Console.ForegroundColor = ConsoleColor.Magenta;


                while (live > 0)
                {
                    Console.WriteLine("You have {0} live", live);
                    Isletter(secretword, letterGuessed);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string input = Console.ReadLine();

                    // if letterGuessed contains input



                    if (letterGuessed.Contains(input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Entered letter [{0}] already", input);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Try a different word");
                        GetAlphabet(input);
                        continue;
                    }
                }
            }
        }
    }
}
