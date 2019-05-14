using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static IList<int> GetFibonacciSequence(int number)
        {
            var result = new List<int>();

            if (number < 1)
            {
                return null;
            }

            result.Add(1);

            if(number.Equals(2))
            {
                result.Add(1);
            }

            return result;
        }
    }
}