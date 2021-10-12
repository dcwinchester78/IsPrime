using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoLib
{
    public class NumberWorx
    {
        public static bool IsPrime(long val1)
        {

            //all prime numbers greater than 5 end with 1,3,7,9, so first simplify.
            if(val1 < 2)
            {
                return false;
            }

            if(val1 == 2 || val1 == 3 || val1 == 5)
            {
                return true;
            }

            //get the char of the last digit
            string strVal = val1.ToString();
            char chVal = strVal[strVal.Length - 1];

            //now, there is no need to further evaluate numbers who last digit is even
            if (chVal == '0' || chVal == '2' || chVal == '4' || chVal == '6' || chVal == '8')
            {
                return false;
            }

            //get the square root
            long sqrt = (long)Math.Sqrt(val1);

            //return false if number is divisible by i
            //we can increment by 2 since we are only interested in testing against odd numbers
            for(int i = 3; i <= sqrt; i += 2)
            {            
                    if(val1 % i == 0)
                    {
                        return false;
                    }             
            }

            //vale to check has made it through the gauntlet and is prime
            return true;
        }
    }
}
