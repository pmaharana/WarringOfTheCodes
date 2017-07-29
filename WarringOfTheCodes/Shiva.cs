using System;
using System.Collections.Generic;
using System.Text;

namespace WarringOfTheCodes
{

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            
            var rv = 0;
            if (n == 0)
            {
                return 0;
            }
            for (int i = 1; i < n+1; i++)
            {
                if (n % i == 0)
                {
                    rv += i;
                }

            }
            return rv;
        }
    }

    class Shiva
    {
        public static string BandNameGenerator(string str)
        {
            var rv = "";
            var the = "The ";
            var modified = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
            return String.Equals(str.Substring(0, 1), str.Substring(str.Length - 1)) ?  modified + str : the + modified;
        }

    }
}
