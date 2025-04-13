using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) return 0;
            if (numbers.Count() == 0) return 0;
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length) return str1.Length;
            else {return str2.Length;}
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) { return 0; }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            int sum = 0;
            foreach (int i in numbers) {
                sum += Math.Abs((i+1)% 2) * i;
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) { return false; }
            return Math.Abs(numbers.Sum() % 2) == 1;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0) return 0;
            return number / 2;
        }
    }
}
