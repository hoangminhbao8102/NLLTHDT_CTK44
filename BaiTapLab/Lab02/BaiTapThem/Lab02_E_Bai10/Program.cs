using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] wordList = { "apple", "banana", "cherry", "date", "elderberry" };
            int maxGuesses = 5;

            while (true)
            {
                string secretWord = wordList[random.Next(wordList.Length)];
                int guesses = 0;
                bool isGuessed = false;

                Console.WriteLine("Welcome to the Word Guess Game!");
                Console.WriteLine($"The word has {secretWord.Length} letters. You have {maxGuesses} attempts to guess it.");

                while (guesses < maxGuesses && !isGuessed)
                {
                    Console.Write("Enter your guess: ");
                    string guessWord = Console.ReadLine().Trim().ToLower();

                    if (guessWord.Length != secretWord.Length)
                    {
                        Console.WriteLine("Invalid guess length, please try again.");
                        continue;
                    }

                    int correctPositionCount = 0;
                    int correctCharacterWrongPositionCount = 0;
                    bool[] visited = new bool[secretWord.Length];

                    // Check correct positions
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (guessWord[i] == secretWord[i])
                        {
                            correctPositionCount++;
                            visited[i] = true;
                        }
                    }

                    // Check correct characters in wrong positions
                    for (int i = 0; i < guessWord.Length; i++)
                    {
                        if (guessWord[i] != secretWord[i])
                        {
                            for (int j = 0; j < secretWord.Length; j++)
                            {
                                if (!visited[j] && guessWord[i] == secretWord[j])
                                {
                                    correctCharacterWrongPositionCount++;
                                    visited[j] = true;
                                    break;
                                }
                            }
                        }
                    }

                    Console.WriteLine($"Correct characters in correct positions: {correctPositionCount}");
                    Console.WriteLine($"Correct characters but in wrong positions: {correctCharacterWrongPositionCount}");

                    if (correctPositionCount == secretWord.Length)
                    {
                        Console.WriteLine("Congratulations! You've guessed the word correctly!");
                        isGuessed = true;
                    }
                    else
                    {
                        guesses++;
                        if (guesses < maxGuesses)
                        {
                            Console.WriteLine($"Try again. You have {maxGuesses - guesses} guesses left.");
                        }
                    }
                }

                if (!isGuessed)
                {
                    Console.WriteLine("You've run out of guesses. Better luck next time!");
                    Console.WriteLine($"The correct word was: {secretWord}");
                }

                Console.WriteLine("Do you want to play again? (yes/no)");
                if (Console.ReadLine().Trim().ToLower() != "yes")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
