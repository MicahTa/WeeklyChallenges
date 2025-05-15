using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            // Account for empty list
            if (words == null) {
                return false;
            }

            bool passed = false;
            // Go thought Every word
            foreach (string? i in words) {
                // Skip if value is null
                if (i == null) {continue;}
                // Test and leave if passed
                if (ignoreCase) {
                    passed = i.ToUpper() == word.ToUpper();
                    if (passed) {break;}
                // Test and leave if passed
                } else {
                    passed = i == word;
                    if (passed) {break;}
                }
            }
            // Return Values
            return passed;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) {
                return false;
            }
            for (int i = num - 1; i>1; i--) {
                if (num % i == 0) {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            char testing;
            bool passed;
            List<int> values = new List<int> {};
            for (int i = 0; i<str.Length; i++) {
                passed = true;
                testing = str[i];
                for (int s = 0; s<str.Length; s++) {
                    if (testing == str[s] && i != s) {
                        passed = false;
                        break;
                    }
                }
                if (passed) {
                    values.Add(i);
                }
            }
            if (values.Count == 0) {
                return -1;
            }
            return values[values.Count-1];
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int largest = 1;
            int current = 0;
            int? value = null;
            foreach (int i in numbers) {
                if (value == i) {
                    current += 1;
                    if (current > largest) {
                        largest = current;
                    }
                } else {
                    value = i;
                    current = 1;
                }
            }
            return largest;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count < n || n < 0 || elements.Count == 0) {
                return new List<double> {}.ToArray();
            }
            List<double> output = new List<double> {};
            for (int i = n-1; i < elements.Count; i+=n) {
                output.Add(elements[i]);
            }

            return output.ToArray();
        }
    }
}
