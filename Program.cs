using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 100); // Random number between 1 and 99
            int numberOfTries = 0;
            const int maxTries = 6;
            bool GuessedCorrectly = false;

            Console.WriteLine("Guess the number between 1 and 99!");

            while (numberOfTries < maxTries && !GuessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                int playerGuess;

                if (int.TryParse(Console.ReadLine(), out playerGuess))
                {
                    numberOfTries++;

                    if (playerGuess < numberToGuess)
                    {
                        Console.WriteLine("The number is higher than your guess.");
                    }
                    else if (playerGuess > numberToGuess)
                    {
                        Console.WriteLine("The number is lower than your guess.");
                    }
                    else
                    {
                        GuessedCorrectly = true;
                        Console.WriteLine($"Congratulations! You've guessed the number in {numberOfTries} tries.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number between 1 and 99.");
                }
            }

            if (!GuessedCorrectly)
            {
                Console.WriteLine($"Sorry, you've reached the maximum number of tries. The number was {numberToGuess}.");
            }
        }
    }
}
