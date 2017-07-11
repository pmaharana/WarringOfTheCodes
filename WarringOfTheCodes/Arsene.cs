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

    }
}
