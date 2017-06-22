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
    }
}
