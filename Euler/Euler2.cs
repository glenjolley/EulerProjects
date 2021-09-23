using System.Collections.Generic;

namespace Euler
{
    public class Euler2 : IEuler
    {
        public void PerformEuler()
        {
            List<int> fibb = new() { 0, 1 };
            int fibbEvenSum = 0;

            while (fibb[fibb.Count - 1] < 4000000)
            {
                if ((fibb[fibb.Count - 1] + fibb[fibb.Count - 2]) % 2 == 0)
                    fibbEvenSum += (fibb[fibb.Count - 1] + fibb[fibb.Count - 2]);

                fibb.Add(fibb[fibb.Count - 1] + fibb[fibb.Count - 2]);
            }

            //foreach (int i in fibb)
            //{
            //    if (i % 2 == 0)
            //        fibbEvenSum += i;
            //}

            System.Console.WriteLine($"Final sum is: {fibbEvenSum}");
        }
    }
}
