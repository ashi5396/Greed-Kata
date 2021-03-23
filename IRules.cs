using System;
using System.Collections.Generic;
using System.Text;

namespace Greed
{
    /// <summary>
    /// Interface class for game rules
    /// </summary>
    interface IRules
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
        public int CalculateSingles(List<int> scores);

        /// <summary>
        /// Rules for calculating triple numbers
        /// </summary>
        /// <param name="scores">
        /// The list of scores
        /// </param>
        /// <returns>
        /// Tuple that has a count of 3 or more
        /// </returns>
        public Tuple<int, int> CalculateTriple(List<int> scores);

        /// <summary>
        /// This function will call other functions that returns specific value for each triple value
        /// </summary>
        /// <param name="number">
        /// Get the specific number
        /// </param>
        /// <returns>
        /// Returns the value for triple
        /// </returns>
        public int CalculateEachTripleValue(int number);

        /// <summary>
        /// This function is for triple of ones
        /// </summary>
        /// <param name="number">
        /// Passed 1 as the triple value
        /// </param>
        /// <returns><
        /// Returns 1000 since it is the total for triple 1
        /// returns>
        public int ScoreOne(int number);

        /// <summary>
        /// This function is for triple of twos
        /// </summary>
        /// <param name="number">
        /// Passed 2 as the triple value
        /// </param>
        /// <returns><
        /// Returns 200 since it is the total for triple 2
        /// returns>
        public int ScoreTwo(int number);

        /// <summary>
        /// This function is for triple of threes
        /// </summary>
        /// <param name="number">
        /// Passed 3 as the triple value
        /// </param>
        /// <returns><
        /// Returns 300 since it is the total for triple 3
        /// returns>
        public int ScoreThree(int number);

        /// <summary>
        /// This function is for triple of fours
        /// </summary>
        /// <param name="number">
        /// Passed 4 as the triple value
        /// </param>
        /// <returns><
        /// Returns 400 since it is the total for triple 4
        /// returns>
        public int ScoreFour(int number);

        /// <summary>
        /// This function is for triple of fifths
        /// </summary>
        /// <param name="number">
        /// Passed 5 as the triple value
        /// </param>
        /// <returns><
        /// Returns 500 since it is the total for triple 5
        /// returns>
        public int ScoreFive(int number);

        /// <summary>
        /// This function is for triple of six
        /// </summary>
        /// <param name="number">
        /// Passed 6 as the triple value
        /// </param>
        /// <returns><
        /// Returns 600 since it is the total for triple 6
        /// returns>
        public int ScoreSix(int number);
    }
}
