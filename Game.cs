using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    /// <summary>
    /// This is the game class where it has methods to roll the dice and to calculate the score. 
    /// </summary>
     public class Game
     {
            //List to hold values for the dice rolls
            private List<int> rollValues = new List<int>();
           // Access Score class's methods to calculte scores properly
            Score playerScore = new Score();

           /// <summary>
           /// This function rolls the dice randomly. And each random value will be added to the list. 
           /// </summary>
           /// <returns>
           /// List of random numbers
           /// </returns>
            public List<int> Roll()
            {
                var dice = new Random();
                for (int i = 0; i < 5; i++)
                {
                    rollValues.Add(dice.Next(1, 6));
                }

                return rollValues;
            }
            
            /// <summary>
            /// Calculates the total score of the player. It calls other functions such --------------------------
            /// </summary>
            /// <param name="score">
            /// List of random values
            /// </param>
            /// <returns>
            /// Returns the total score for the player
            /// </returns>
            public int CalculateScore(List<int> score)
            {
                int total = 0;
                //Returns the tuple with max value that has max occurances
                (int item, int count) = playerScore.CalculateTriple(score);
                //If the count >3 then call the proper triple function and remove the item from the list so it would not recalculate 
                if (count >= 3) {
                    total = playerScore.CalculateEachTripleValue(item);
                    for (int i = 0; i < 3; i++)
                    {
                        score.Remove(item);
                    }
                }
                total += playerScore.CalculateSingles(score);
                return total;
            }
    }
}
