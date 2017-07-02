using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace WarringOfTheCodes
{
    class Izanagi
    {
        public static int FindSmallestInt(int[] args)
        {
            return args.ToList().Min();
        }

        public static string BowlingPins(int[] arr)
        {
            int SwitchItUp(int number)
            {
                int rv = 0;
                switch (number)
                {
                    case 10: rv =3; break;
                    case 9: rv = 2; break;
                    case 8: rv = 1; break;
                    case 7: rv = 0; break;
                    case 6: rv = 6; break;
                    case 5: rv = 5; break;
                    case 4: rv = 4; break;
                    case 3: rv = 8; break;
                    case 2: rv = 7; break;
                    case 1: rv = 9; break;
                }
                return rv;
            }
            string input = "I I I I\n I I I \n  I I  \n   I   ";
            var indices = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'I')
                {
                    indices.Add(i);
                }
            }
            var myArray = input.ToCharArray();

            foreach (var x in arr)
            {
                var y = SwitchItUp(x);
                myArray[indices[y]] = ' ';
            }
            
            return new string(myArray);
        }


           



    }
}
