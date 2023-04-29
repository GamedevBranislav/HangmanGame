using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] words = { "jump", "programming", "sky", "pictures", "river", "start", "grass", "google" };

            Random random = new Random();
            int randomIndex = random.Next(0, 8);
            string selectedWord = words[randomIndex];
            string hiddenWord = "";
            for (int i = 0; i < selectedWord.Length; i++)
            {
                //put star for characters (player don't see a word)
                hiddenWord += "*";
            }
            
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word : {0}", hiddenWord);
                Console.Write("Guess a letter >> ");
                char letter = char.Parse(Console.ReadLine());
                bool containsLetter = false;
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if(selectedWord[i] == letter)
                    {
                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        containsLetter = true;
                        
                    }
                }
                if(containsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("yes! {0} is in the word", letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, {0} is not in the word", letter);
                }
                Console.ResetColor();
            }

            //you won
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Congratulation! You Win! The word was {0}.", selectedWord);




        }
    }
}
