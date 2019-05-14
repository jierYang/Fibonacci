using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static IList<int> GetFibonacciSequence(int number)
        {
            var result = new List<int>();
            
            result.Add(number);

            return result;
        }
    }
}