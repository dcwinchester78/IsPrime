using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeStrings
{
    public class NumberWorx
    {
        /// <summary>
        /// returns true if the value passed in is prime
        /// </summary>
        /// <param name="val1"></param>
        /// <returns></returns>
        public bool IsPrime(long val1)
        {
            //all prime numbers greater than 5 end with 1,3,7,9, so first simplify.
            if (val1 < 2)
            {
                return false;
            }

            if (val1 == 2 || val1 == 3 || val1 == 5)
            {
                return true;
            }

            //get the char of the last digit
            string strVal = val1.ToString();
            char chVal = strVal[strVal.Length - 1];

            //now, there is no need to further evaluate numbers who last digit is even
            char[] cArr = { '0','2','4','5','6','8' };          
            if (cArr.Contains(chVal))
            {
                return false;
            }

            //get the square root
            long sqrt = (long)Math.Sqrt(val1);

            //return false if number is divisible by i
            //we can increment by 2 since we are only interested in testing against odd numbers
            for (int i = 3; i <= sqrt; i += 2)
            {
                if (val1 % i == 0)
                {
                    return false;
                }
            }

            //vale to check has made it through the gauntlet and is prime
            return true;
        }

        /// <summary>
        /// gets the next prime number after the value passed in
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public long NextPrime(long val)
        {
            //2 is even and prime
            if (val == 2)
                return 3;

            //next value
            long startVal = ++val;

            //we only want to run odd numbers through the loop
            if (startVal % 2 == 0) startVal++;

            //if not prime, iterate by 2
            while(!IsPrime(startVal))
            {
                startVal += 2;
            }

            return startVal;        
        }

        /// <summary>
        /// returns a min number by digits
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public long StartNumberPerDigitCount(int digits)
        {
            if(digits > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("1");
                for (int i = 1; i < digits; i++)
                {
                    sb.Append("0");
                }
                return Int64.Parse(sb.ToString());
            }
            return 0; 
        }

        /// <summary>
        /// returns a max number by digits
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public long MaxDigit(int digits)
        {
            if(digits > 0)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < digits; i++)
                {
                    sb.Append("9");
                }

                return Int64.Parse(sb.ToString());
            }
            return 0;
        }
    }
}
