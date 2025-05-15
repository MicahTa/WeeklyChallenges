using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while (true) {
                startNumber += 1;
                if (startNumber % n == 0) {
                    return startNumber;
                }
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business buzz in businesses) {
                if (buzz.TotalRevenue == 0) {
                    buzz.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) {
                return false;
            }
            int prev = numbers[0];
            foreach (int i in numbers) {
                if (prev > i) {
                    return false;
                }
                prev = i;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null) {
                return 0;
            }
            int previous = 1;
            int output = 0;
            foreach (int i in numbers) {
                if (previous % 2 == 0) {
                    output += i;
                }
                previous = i;
            }
            return output;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            // Null or empty exception
            if (words == null || words.Length == 0) {
                return "";
            }

            // Go through words
            string sentance = "";
            foreach (string word in words) {
                // Add word and space if thers a word
                if (word.Trim(' ') != "") {
                    sentance += $"{word.Trim(' ')} ";
                }
            }
            // Empty sentances return nothing
            if (sentance.Length == 0 ) {
                return "";
            }
            // Remove extra space and add .
            return sentance.Remove(sentance.Length - 1, 1) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) {
                return new List<double> {}.ToArray();
            }
            List<double> output = new List<double> {};
            for (int i = 3; i < elements.Count; i+=4) {
                output.Add(elements[i]);
            }

            return output.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i<nums.Length; i++) {
                for (int s = 0; s<nums.Length; s++) {
                    if (nums[i] + nums[s] == targetNumber && i != s) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
