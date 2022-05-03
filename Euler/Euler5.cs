using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Euler
{
    class Euler5 : IEuler
    {
        public void PerformEuler()
        {
            long i = 20;
            bool answerFound = false;

            var timer = new Stopwatch();
            timer.Start();

            //int divisorMax = 20;
            //int[] p = generatePrimes(divisorMax);
            //int result = 1;

            //for (int i = 0; i < p.Length; i++)
            //{
            //    int a = (int)Math.Floor(Math.Log(divisorMax) / Math.Log(p[i]));
            //    result = result * ((int)Math.Pow(p[i], a));
            //}

            while (!answerFound)
            {
                bool thisOne = true;
                //if (i % 2 != 0)
                //{
                //    i++;
                //    continue;
                //}
                //else
                //{
                //    answerFound = DividesByAll(i);
                //}

                //if (!answerFound)
                //    i++;
                for (int n = 20; n >= 11; n--)
                {
                    if (i % n != 0)
                    {
                        thisOne = false;
                        break;
                    }
                }

                if (!thisOne)
                    i += 20;
                else
                    break;
            }

            //while (!DividesByAll(i))
            //{
            //    i += 20;
            //}
            timer.Stop();

            Console.WriteLine($"Answer: {i}. Time taken: {timer.ElapsedMilliseconds}");

        }
        bool DividesByAll(long check)
        {
            bool result = true;

            for (int i = 20; i >= 11; i--)
            {
                if (check % i != 0) {
                    return false;
                }
            }

            return result;
        }

        private int[] generatePrimes(int upperLimit)
        {
            List<int> primes = new List<int>();
            bool isPrime;
            int j;

            primes.Add(2);

            for (int i = 3; i <= upperLimit; i += 2)
            {
                j = 0;
                isPrime = true;
                while (primes[j] * primes[j] <= i)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }
    }
}
