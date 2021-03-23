using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Greed
{
    /// <summary>
    /// Score class implements all the functions in the IRules class. 
    /// </summary>
    class Score : IRules
    {
        /// <summary>
        /// Rule for calculating single of ones and fives
        /// </summary>
        /// <param name="scores">
        /// The list of scores
        /// </param>
        /// <returns>
        /// Returns the score for singles
        /// </returns>
      
        public int CalculateSingles(List<int> scores)
        {
            int scoreValue = 0;
            foreach (int val in scores)
            {
                switch (val)
                {
                    case 1:
                        scoreValue += 100;
                        break;
                    case 5:
                        scoreValue += 50;
                        break;
                }
            }
            return scoreValue;
        }

        /// <summary>
        /// Rules for calculating triple numbers
        /// </summary>
        /// <param name="scores">
        /// The list of scores
        /// </param>
        /// <returns>
        /// Tuple that has a count of 3 or more
        /// </returns>
        public Tuple<int, int> CalculateTriple(List<int> scores)
        {

            var scoreValue = scores.GroupBy(i => i);
            int count = 0;
            int item = 0;
            //Go through the list to group and find number of occurances
            foreach (var values in scoreValue)
            {
                count = values.Count();
                item = values.Key;
                //Get the max count of occurances and return it as a tuple and then break
                if (count >= 3)
                {
                    return new Tuple<int, int>(item, count);
                    break;
                }
            }
            return new Tuple<int, int>(item, count);
        }

        /// <summary>
        /// This function will call other functions that returns specific value for each triple value
        /// </summary>
        /// <param name="number">
        /// Get the specific number
        /// </param>
        /// <returns>
        /// Returns the value for triple
        /// </returns>
        public int CalculateEachTripleValue(int number)
        {
            //Switch the number and call the proper triple function based on the number
            switch (number)
            { 
                case 1:
                    return ScoreOne(number);
                case 2:
                    return ScoreTwo(number);
                case 3:
                    return ScoreThree(number);
                case 4:
                    return ScoreFour(number);
                case 5:
                    return ScoreFive(number);
                case 6:
                    return ScoreSix(number);
            }

            return 0;
        }

        /// <summary>
        /// This function is for triple of ones
        /// </summary>
        /// <param name="number">
        /// Passed 1 as the triple value
        /// </param>
        /// <returns><
        /// Returns 1000 since it is the total for triple 1
        /// returns>
        public int ScoreOne(int number)
        {
            return 1000;
        }

        /// <summary>
        /// This function is for triple of twos
        /// </summary>
        /// <param name="number">
        /// Passed 2 as the triple value
        /// </param>
        /// <returns><
        /// Returns 200 since it is the total for triple 2
        /// returns>
        public int ScoreTwo(int number)
        {
            return 200;
        }

        /// <summary>
        /// This function is for triple of threes
        /// </summary>
        /// <param name="number">
        /// Passed 3 as the triple value
        /// </param>
        /// <returns><
        /// Returns 300 since it is the total for triple 3
        /// returns>
        public int ScoreThree(int number)
        {
            return 300;
        }

        /// <summary>
        /// This function is for triple of fours
        /// </summary>
        /// <param name="number">
        /// Passed 4 as the triple value
        /// </param>
        /// <returns><
        /// Returns 400 since it is the total for triple 4
        /// returns>
        public int ScoreFour(int number)
        {
            return 400;
        }

        /// <summary>
        /// This function is for triple of fifths
        /// </summary>
        /// <param name="number">
        /// Passed 5 as the triple value
        /// </param>
        /// <returns><
        /// Returns 500 since it is the total for triple 5
        /// returns>
        public int ScoreFive(int number)
        {
            return 500;
        }

        /// <summary>
        /// This function is for triple of six
        /// </summary>
        /// <param name="number">
        /// Passed 6 as the triple value
        /// </param>
        /// <returns><
        /// Returns 600 since it is the total for triple 6
        /// returns>
        public int ScoreSix(int number)
        {
            return 600;
        }
    }
}
