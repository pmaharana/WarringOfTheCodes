using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WarringOfTheCodes
{
    class Orpheus
    {
        public static string[] WordSearch(string query, string[] seq)
        {
            var rv = new List<String>();
            foreach (var item in seq)
            {
                if (item.ToLower().Contains(query.ToLower()))
                {
                    rv.Add(item);
                }
            }
            if (rv.Count == 0)
            {
                rv.Add("Empty");
            }

            return rv.ToArray();
        
        }

        public static string[] WordSearchu(string query, string[] seq)
        {
            var result = seq.Where(x => x.ToLower().Contains(query.ToLower())).ToArray();
            return result.Length > 0 ? result : new string[] { "Empty" };
        }


        public static bool IsEven(int n)
        {
            if ((n / 2) == ((n + 1) / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Sum of all even Fabiconni numbers whose value is less than 4 mil.
        public static int SumOfEvenFabs()
        {
            int iCount = 2;
            int fabNum = 0;
            List<int> seqList = new List<int> { 1, 2 };


            do
            {
                fabNum = seqList[iCount - 1] + seqList[iCount - 2];
                seqList.Add(fabNum);
                iCount++;

            } while (fabNum < 4000000);

            var rv = 0;
            seqList.RemoveAt(seqList.Count - 1);
            //seqList.ForEach(f => Console.Write(f + " "));
            List<int> evenFabs = new List<int>();
            foreach (var x in seqList)
            {
                if (x % 2 == 0)
                {
                    evenFabs.Add(x);
                }
            }
            return rv;
        }

        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(w => w.Length == 4).ToArray();

            //This also works
            //public static IEnumerable<string> FriendOrFoe(string[] names) => names.Where(o => o.Length == 4);
        }

        public static string HoopCount(int n)
        {
            return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
        }

        public static int DescendingOrder(int num)
        {
            var digits = num.ToString().Select(t => int.Parse(t.ToString())).ToList().OrderByDescending(o => o).ToList();
            string rv = "";
            digits.ForEach(f => rv += f);
            return int.Parse(rv);
            
        }

        public static string GetRectangleStringTest(int width, int height)
        {
            string rv = "";
            string space = "";
            for (int s = 0; s < width - 2; s++)
            {
                space += " ";
            }
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height -1)
                {
                    for (int j = 0; j < width; j++)
                    {

                        rv += "*";
                    }
                }
                else
                {
                    rv += "*" + space + "*";

                }


                    
                rv += "\r\n";
            }
            return rv;
        }

        public static string GetRectangleString(int width, int height)
        {
            string rv = "";
           
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height -1)
                {

                rv += new String('*', width) + "\r\n";
                }
                else
                {
                    rv += "*" + new String(' ', width - 2) + "*" + "\r\n";
                }
            }
            return rv;
        }

        public static string GetRectangleStringDeux(int width, int height)
        {
            if (width == 1) return string.Join("", Enumerable.Repeat("*\r\n", height));
            if (width == 2) return string.Join("", Enumerable.Repeat("**\r\n", height));
            return new String('*', width) + "\r\n" + string.Join("", Enumerable.Repeat("*" + new String(' ', width - 2) + "*\r\n", height - 2)) + new String('*', width) + "\r\n";
        }
    }
}
