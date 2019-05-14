using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static IList<int> GetFibonacciSequence(int number)
        {
            var result = new List<int>();

            for (var i = 0; i < number; i++)
            {
                var value = GetValue(i);
                
                result.Add(value);
            }

            return result;
        }

        private static int GetValue(int n) {
            return (n < 2)? 1 : GetValue(n - 1) + GetValue(n - 2);
        }
    }
}