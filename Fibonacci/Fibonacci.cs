using System;
using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static IList<BigInteger> GetFibonacciSequence(int number)
        {
            var result = new List<BigInteger>();

            for (var i = 0; i < number; i++)
            {
                if (i < 3)
                {
                    result.Add(1);
                }

                else
                {
                    result.Add(result[i - 1] + result[i - 2] + result[i - 3]);
                }
            }

            return result;
        }
    }
}