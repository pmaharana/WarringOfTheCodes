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


    }
}
