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
                if (check.Count > 0)
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

        public static int[] getRecord(int[] s)
        {
            var highRecord = 0;
            var lowRecord = 0;
            var maxNum = s[0];
            var minNum = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] > maxNum)
                {
                    maxNum = s[i];
                    highRecord++;
                }
                if (s[i] < minNum)
                {
                    minNum = s[i];
                    lowRecord++;
                }
            }
            return new int[] { highRecord, lowRecord };
        }

        public static string AverageString(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return "n/a";
            }
            var myDic = new Dictionary<string, int>()
           {
               {"zero", 0 }, {"one", 1 }, {"two", 2 }, {"three", 3 }, {"four", 4 }, {"five", 5},
               {"six", 6 }, {"seven", 7}, {"eight", 8}, {"nine", 9}
           };
            var input = str.ToLower().Split(' ');
            var inputKey = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (myDic.ContainsKey(input[i]))
                {
                    inputKey.Add(input[i]);
                }
            }
            var numero = inputKey.ToList().Select(s => myDic[s]).ToList().Average();
            var number = Math.Floor(numero);
            var rv = myDic.FirstOrDefault(x => x.Value == number).Key;
            return rv;
        }

        public static bool IsAlt(string word)
        {
            var input = word.ToLower();
            var vowel = "aeiou";
            var rv = true;
            int Vowel(char x)
            {
                return vowel.Contains(x) ? 1 : 0;
            }

            for (int i = 1; i < input.Length; i++)
            {
                if (Vowel(input[i]) == Vowel(input[i - 1]))
                {
                    rv = false;
                }

            }

            return rv;

        }

        //var startChar = input.First(f => vowel.Contains(f.ToString()));
        //var firstIndex = input.IndexOf(startChar);
        //var testString = input.Substring(firstIndex);
        //var everyOther = testString.Where((t, i) => (i % 2) == 0).ToList();
        //foreach (var x in everyOther)
        //{
        //    if (vowel.Contains(x))
        //    {
        //        rv++;
        //    }
        //}
        //return everyOther.Count() == rv;

        public static int Solution(int value)
        {
            var rv = new List<int>();
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    rv.Add(i);
                }
            }
            return rv.Sum();
        }

    }
}
