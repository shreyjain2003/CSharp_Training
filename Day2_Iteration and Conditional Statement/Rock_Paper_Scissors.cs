using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capgemini_Training
{
    /// <summary>
    /// Represents a console-based implementation of the Rock, Paper, Scissors game for two players.
    /// </summary>
    /// <remarks>This class provides an interactive game where two players enter their choices, and the winner
    /// is determined based on standard Rock, Paper, Scissors rules. The application prompts each player for input and
    /// displays the result in the console. Input is case-insensitive, but only the exact words "rock", "paper", or
    /// "scissors" are valid choices.</remarks>
    class Rock_Paper_Scissors
    {
        static void Main(string[] args)
        {
            // Input from Player 1
            Console.WriteLine("Player 1 - Enter Rock, Paper or Scissors: ");
            string p1 = Console.ReadLine().ToLower();

            // Input from Player 2
            Console.WriteLine("Player 2 - Enter Rock, Paper or Scissors: ");
            string p2 = Console.ReadLine().ToLower();

            // Checking if both players entered the same choice
            if (p1 == p2)
            {
                Console.WriteLine("Game Draw!");
            }
            else
            {
                // Nested conditions for Player 1 winning cases
                if ((p1 == "rock" && p2 == "scissors") ||
                    (p1 == "scissors" && p2 == "paper") ||
                    (p1 == "paper" && p2 == "rock"))
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                // If Player 1 does not win, Player 2 wins
                else
                {
                    Console.WriteLine("Player 2 Wins!");
                }
            }
        }
    }
}
