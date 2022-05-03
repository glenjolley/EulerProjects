using System;

namespace Euler
{
    public class Euler4 : IEuler
    {
        public void PerformEuler()
        {
            int digitLength = 3;
            int maxD = 0;
            string maxDString = "";
            long maxNumber = 0;
            long minNumber = 0;
            int minD = 0;
            string minDString = "";

            for (int i = 0; i < digitLength; i++)
            {
                maxDString += "9";
            }
            for (int i = 0; i < digitLength; i++)
            {
                if (i == 0)
                {
                    minDString = "1";
                }
                else
                {
                    minDString += "0";
                }
            }
            maxD = int.Parse(maxDString);
            minD = int.Parse(minDString);

            maxNumber = maxD * maxD;
            minNumber = minD * minD;
            
            for (long num = maxNumber; num >= minNumber; num--)
            {
                if (IsPalindrome(num.ToString()))
                {
                    if (HasXDigitDenominators(num, digitLength, maxD, minD))
                    {
                        Console.WriteLine(num);
                        break;
                    }
                }
            }
            
        }

        bool IsPalindrome(string check)
        {
            char[] arr = check.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);
            return check == reversed;
        }

        bool HasXDigitDenominators(long check,int digits, int maxNumber, int minNumber)
        {
            int x = 0;
            int y = 0;

            for (int i = maxNumber; i >= minNumber; i--)
            {
                if (check % i == 0)
                {
                    if ((check / i).ToString().Length == 3)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
