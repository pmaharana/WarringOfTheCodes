using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace WarringOfTheCodes
{
    class Thanatos
    {
        public static string Unlock(string str)
        {
            var myDic = new Dictionary<char, int>()
            {
                {'a', 2 }, {'b', 2}, {'c', 2}, {'d', 3}, {'e', 3}, {'f', 3},
                {'g', 4 }, {'h', 4}, {'i', 4}, {'j', 5}, {'k', 5}, {'l', 5},
                {'m', 6 }, {'n', 6}, {'o', 6}, {'p', 7}, {'q', 7}, {'r', 7}, {'s', 7},
                {'t', 8 }, {'u', 8}, {'v', 8}, {'w', 9}, {'x', 9}, {'y', 9}, {'z', 9}

            };

            var rv = str.ToLower().Select(s => myDic[s]).ToList();
            return String.Join("", rv);
        }

        private static string _keys = "abcdefghijklmnopqrstuvwxyz22233344455566677778889999";

        public static string UnlockU(string str) => string.Join("", str.ToLower().
            Select(x => _keys[26 + _keys.IndexOf(x)]));
         
        public static string super_reduced_string(string s)
        {
            string toCheck = "(.)\\1";
            var rv = s;
            while (Regex.IsMatch(rv, toCheck))
            {

            rv = Regex.Replace(rv, toCheck, "");
            }
            return rv.Length > 0 ? rv : "Empty String";
        }

       public static string HackerRankInString(string s)
        {
            var x = s.ToLower();
            var check = "hackerrank".ToList();
            string rv = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (check.Count> 0)
                {
                    if (x[i] == check[0])
                    {
                        rv += x[i];
                        check.RemoveAt(0);
                    }
                }
            }
            return rv;
        }
               


    }
}
