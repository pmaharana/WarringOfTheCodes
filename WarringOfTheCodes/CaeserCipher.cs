using System;
using System.Collections.Generic;
using System.Text;

namespace WarringOfTheCodes
{
    public class CaesarCipher
    {
        public static List<char>CharConvert(string iv)
        {
            var rv = new List<char>();
            foreach (var c in iv)
            {
                rv.Add(c);
            }
            return rv;
        }




        public static List<string> movingShift(string s, int shift)
        {

            var eve = CharConvert(s);
            var ascii = new List<int>();
            var asciiToChar = new List<char>();
            

            return null;
        }

        public static string demovingShift(List<string> s, int shift)
        {
            return "";
        }
    }
}
