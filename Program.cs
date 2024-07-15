using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turns = 1;
            Random rnd=new Random();
            int dice;
            int totalScore = 0;
            int turnScore=0;
            int endScore = 20;
            int stop = 1;
            char input;

            Console.WriteLine("==================================================");
            Console.WriteLine("Hey Welcome to the PigDiceGame....");
            Console.WriteLine("=================================================="); 
            while (totalScore < endScore && turnScore < endScore) {
                top:
                Console.WriteLine("Enter 'r' to roll the dice or 'h' to hold the dice");
                dice = Convert.ToInt32(rnd.Next(1, 7));
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input == 'r' && dice != stop)
                {
                    Console.WriteLine($"Dice rolled score: {dice}");
                    turnScore += dice;
                    Console.WriteLine($"Your turn score is :{turnScore}");
                    Console.WriteLine($"Your total score is :{totalScore}\n");
                    if (turnScore + totalScore < endScore)
                        goto top;
                    else
                        totalScore += turnScore;
                    break;
                }
                else if (input == 'h' && dice != stop)
                {
                    totalScore += turnScore;
                    turns++;
                    turnScore = 0;
                    Console.WriteLine($"Total score: {totalScore}\n Turn Score: {turnScore}\n");
                }
                else if (dice == stop)
                {
                    Console.WriteLine($"Dice rolled score: {dice}");
                    turnScore = 0;
                    turns++;
                    Console.WriteLine("Turn over \n No score\n");
                }

            }
            Console.WriteLine($"Your final score: {totalScore} and No of turns: {turns}");
        }
    }
}
