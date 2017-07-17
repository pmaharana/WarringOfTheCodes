using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarringOfTheCodes
{
    class Arsene
    {
        public static int stringsconstruction(string A, string B)
        {
            return A.Distinct().Min(x => B.Count(y => y == x) / A.Count(z => z == x));
        }

        public static string AlphabetWar(string fight)
        {
            string input = fight.ToLower();
            var myDic = new Dictionary<char, int>();
            myDic.Add('w', 4);
            myDic.Add('p', 3);
            myDic.Add('b', 2);
            myDic.Add('s', 1);
            myDic.Add('m', -4);
            myDic.Add('q', -3);
            myDic.Add('d', -2);
            myDic.Add('z', -1);
            var middle = input.Split('*');
            var endstring = "";
            var rv = 0;
            if (!input.Contains('*'))
            {
                endstring = input;
            }
            else
            {
                for (int i = 0; i < middle.Length; i++)
                {

                    if (middle[i].Length > 1)
                    {
                        if (i == 0)
                        {
                            endstring += middle[0].Substring(0, middle[0].Length - 1);
                        }
                        else if (i == middle.Length - 1)
                        {
                            endstring += middle[middle.Length - 1].Substring(1);
                        }
                        else
                        {
                            endstring += middle[i].Substring(1, middle[i].Length - 2);
                        }

                    }
                }
            }

            var keyList = new List<char>();
            foreach (var x in endstring)
            {
                if (myDic.ContainsKey(x))
                {
                    keyList.Add(x);
                }
            }
            rv = keyList.Select(s => myDic[s]).ToList().Sum();


            if (rv > 0)
            {
                return "Left side wins!";
            }
            else if (rv < 0)
            {
                return "Right side wins!";
            }
            else
            {
                return "Let's fight again!";
            }
            
        }

        public static string AlphabetWarU(string fight)
        {
            var left = new Dictionary<char, int>() { { 'w', 4 }, { 'p', 3 }, { 'b', 2 }, { 's', 1 } };
            var right = new Dictionary<char, int>() { { 'm', 4 }, { 'q', 3 }, { 'd', 2 }, { 'z', 1 } };
            var rightScore = 0;
            var leftScore = 0;
            var bombIdx = new List<int>();
            for (int i = 0; i < fight.Length; i++)
            {
                var letter = fight[i];
                if (letter == '*') bombIdx.Add(i);
            }
            var str = fight.ToCharArray();
            foreach (int idx in bombIdx)
            {
                str[idx] = '_';
                if (idx > 0) str[idx - 1] = '_';
                if (idx < str.Length - 1) str[idx + 1] = '_';
            }
            fight = new string(str);
            for (int i = 0; i < fight.Length; i++)
            {
                var letter = fight[i];
                if (left.ContainsKey(letter)) leftScore += left[letter];
                if (right.ContainsKey(letter)) rightScore += right[letter];

            }
            if (rightScore > leftScore) return "Right side wins!";
            if (rightScore < leftScore) return "Left side wins!";
            return "Let's fight again!";
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            var rv = new List<double>();
            if (n == 0)
            {
                rv.Add(0.0);

            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (i < 3)
                    {
                        rv.Add(signature[i]);
                    }
                    else
                    {
                        rv.Add(rv[i - 1] + rv[i - 2] + rv[i - 3]);
                    }

                }
            } 
          
            return rv.ToArray();
        }

        public double[] TribonacciU(double[] s, int n)
        {
            double[] res = new double[n];
            Array.Copy(s, res, Math.Min(3, n));

            for (int i = 3; i < n; i++)
                res[i] = res[i - 3] + res[i - 2] + res[i - 1];

            return n == 0 ? new double[] { 0 } : res;
        }

        public static string Rps(string p1, string p2)
        {
            if (p1 == p2)
            {
                return "Draw!";
            }
            else if (p1 == "rock" && p2 == "scissors" ||
                 p1 == "scissors" && p2 == "paper" || 
                 p1 == "paper" && p2 == "rock")
            {
                return "Player 1 Won!";
            }
            else
            {
                return "Player 2 Won!";
            }
        }

        public static string RpsU(string p1, string p2)
        {
            return p1 == p2 ? "Draw!" :
                          (p1 == "rock" && p2 == "scissors" || p1 == "scissors" && p2 == "paper" || p1 == "paper" && p2 == "rock")
                          ? "Player 1 won!" : "Player 2 won!";
        }

        private static readonly HashSet<string> map = new HashSet<string> { "scissorspaper", "paperrock", "rockscissors" };

        public string RpsAh(string p1, string p2) => p1 == p2 ? "Draw!" : map.Contains(p1 + p2) ? "Player 1 won!" : "Player 2 won!";

    }
}
