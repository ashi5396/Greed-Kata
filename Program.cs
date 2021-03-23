using System;
using System.Collections.Generic;

namespace Greed
{
    /// <summary>
    /// This is the main program. It allows the player to play the game or exit the game. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            List<int> myList = new List<int>();
            int choice = 0, totalScore = 0;

            //Let the user chose from play the game or exit the game. Based on the input, the proper functions will be called
            do
            {
                Console.WriteLine("1.Play the game");
                Console.WriteLine("2 Exit the game");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Write('\n');
                //If the user choses 1 then call Roll function and calculate score to get total values
                if (choice == 1)
                {
                    myList.Clear();
                    myList = myGame.Roll();
                    foreach (int value in myList)
                    {
                        Console.WriteLine("Dice Value: " +  value);
                    }
                    totalScore = myGame.CalculateScore(myList);
                    Console.WriteLine("Score : " + totalScore);
                    Console.WriteLine();
                }
                //If the user choses 2 then simply exit the program
                else
                {
                    Environment.Exit(0);
                }

            } while (choice != 1 || choice != 2);
        }
    }
}
