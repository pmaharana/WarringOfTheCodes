﻿using System;
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

    }
}
