using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int output = 0;
            foreach (int i in numbers) {
                if (i%2 == 0){
                    output += i;
                } else {
                    output -= i;
                }
            }
            return output;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strings = new List<string> {str1, str2, str3, str4};
            return strings.OrderByDescending(x=> x.Length).Reverse().ToList()[0].Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int> {number1, number2, number3, number4};
            return numbers.OrderByDescending(x=> x).Reverse().ToList()[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ((sideLength1 <= 0) || (sideLength2 <= 0) || (sideLength3 <= 0)) {return false;}
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1);

        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int runningOut = 0;
            foreach (var i in objs) {
                if (i == null) {runningOut++;}
            }
            return runningOut>(objs.Length/2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || !numbers.Any() || numbers.Where(x => x%2 == 0).Count() == 0) {
                return 0;
            }
            return numbers.Where(x => x%2 == 0).Average();
        }

        public int Factorial(int number) {
            if (number < 0) {
                throw new ArgumentOutOfRangeException("number", "number cannot be negitive");
            }
            int output = 1;
            for (int i = number; i>0; i--) {
                output *= i;
            }
            return output;
        }
    }
}
