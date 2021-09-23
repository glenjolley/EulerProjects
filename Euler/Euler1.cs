using System.Collections.Generic;

namespace Euler
{
    public class Euler1 : IEuler
    {
        public void PerformEuler()
        {
            List<int> multiples = new();
            int multipleSum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    multiples.Add(i);
            }

            foreach (int i in multiples)
            {
                multipleSum += i;
            }

            System.Console.WriteLine($"Final sum is: {multipleSum}");
        }
    }
}
