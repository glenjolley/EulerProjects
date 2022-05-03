using System;
using System.Collections.Generic;

namespace Euler
{
    public class Euler3 : IEuler
    {
        public void PerformEuler()
        {
            //long target = 6008514751437362153;
            long target = 600851475143;
            List<long> foundPrimeFactors = new();

            while (LowestPrime(target) != target)
            {
                foundPrimeFactors.Add(LowestPrime(target));
                target /= foundPrimeFactors[foundPrimeFactors.Count - 1];
                Console.WriteLine($"Prime factor found! {foundPrimeFactors[foundPrimeFactors.Count - 1]}");
                Console.WriteLine($"Target is now: {target}");
            }

            foundPrimeFactors.Add(LowestPrime(target));
            Console.WriteLine($"Final prime factor found! {foundPrimeFactors[foundPrimeFactors.Count - 1]}");
        }

        private long LowestPrime(long target)
        {
            long lowestPrime = 0;

            //check if our target is already a prime
            if (CheckPrime(target))
            {
                lowestPrime = target;
            }
            else
            {
                for (long p = 1; p <= target; p++)
                {
                    if (CheckPrime(p))
                    {
                        if (target % p == 0 && p != 1)
                        {
                            lowestPrime = p;
                            break;
                        }
                    }
                }
            }

            return lowestPrime;
        }

        private bool CheckPrime(long l)
        {
            bool isPrime = true;

            for (long n = 1; n < Math.Floor(Math.Sqrt(l)); n++)
            {
                if (l % n == 0 && (n != 1 && n != l))
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
