using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WarringOfTheCodes
{
    class Program


    {

        //Hacker rank pangram

        public static string Pangram(string sentence)
        {
            var comparison = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            var input = sentence.ToLower();
            int count = 0;

            foreach (var item in comparison)
            {
                if (input.Contains(item.ToString()))
                {
                    count++;
                }
            }

            if (count == 26)
            {
                return "pangram";
            }
            else
            {
                return "not pangram";
            }
        }






        public static string FizzBuzz(string sentence)
        {
            var rv = String.Empty;
            var upperVowel = new List<char> { 'A', 'E', 'I', 'O', 'U' };
            var lowerVowel = new List<char> { 'a', 'e', 'i', 'o', 'u' };


            foreach (var letter in sentence)
            {
                if (upperVowel.Contains(letter))
                {
                    rv += "Iron Yard";
                }
                else if (char.IsUpper(letter) && !upperVowel.Contains(letter))
                {

                    rv += "Iron";
                }
                else if (lowerVowel.Contains(letter))
                {

                    rv += "Yard";
                }
                else
                {
                    rv += letter;

                }
            }

            return rv;
        }









        public static bool XO(string input)
        {
            var lower = input.ToLower();
            int xCount = lower.Count(c => c == 'x');
            int oCount = lower.Count(c => c == 'o');



            if (lower.Contains("x") && lower.Contains("o") && xCount == oCount)
            {
                return true;
            }
            if (!lower.Contains("x") && !lower.Contains("o"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static string repeatStr(int n, string s)
        {
            string rv = "";
            for (int i = 0; i < n; i++)
            {
                rv += s;
            }
            return rv;
        }

        public static List<string> wave(string str)
        {
            List<string> yugi = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {

                    yugi.Add(str.Substring(0, i) + str.Substring(i, 1).ToUpper() + str.Substring(i + 1));
                }
            }
            return yugi;
        }

        //Solution for alphabet war code wars - https://www.codewars.com/kata/59377c53e66267c8f6000027/solutions/csharp

        public static string AlphabetWar(string fight)
        {
            var leftDic = new Dictionary<char, int>();
            var rightDic = new Dictionary<char, int>();
            int leftValue = 0;
            int rightValue = 0;

            leftDic.Add('w', 4);
            leftDic.Add('p', 3);
            leftDic.Add('b', 2);
            leftDic.Add('s', 1);

            rightDic.Add('m', 4);
            rightDic.Add('q', 3);
            rightDic.Add('d', 2);
            rightDic.Add('z', 1);

            var fightu = fight.ToLower().ToList();

            foreach (var letter in fightu)
            {
                if (leftDic.ContainsKey(letter))
                {
                    leftValue += leftDic[letter];
                }
                else if (rightDic.ContainsKey(letter))
                {
                    rightValue += rightDic[letter];
                }
            }

            if (leftValue > rightValue)
            {
                return "Left side wins!";
            }
            else if (rightValue > leftValue)
            {
                return "Right side wins!";
            }
            else
            {

                return "Let's fight again!";
            }
        }


        public static string SortTheInnerContent(string words)
        {
            var i = words.Split(' ').ToList();
            var rv3 = new List<string>();

            for (int z = 0; z < i.Count; z++)
            {
                if (i[z].Length < 2)
                {
                    rv3.Add(i[z]);
                }
                else
                {
                    string rv = "";
                    i[z].Substring(1, i[z].Length - 2).ToList().OrderByDescending(o => o).ToList().
                        ForEach(x => rv += x.ToString());

                    string rv2 = i[z].Substring(0, 1) + rv + i[z].Substring(i[z].Length - 1);
                    rv3.Add(rv2);
                }

            }
            string rv4 = String.Join(" ", rv3);
            return rv4;
        }

        public static string Reverse(string text)
        {
            var mylist = text.Split(' ').ToList();

            mylist.Reverse();

            return String.Join(" ", mylist);
        }

        public static int[] PreFizz(int n)
        {
            var rv = new List<int>();
            for (int i = 1; i < n + 1; i++)
            {
                rv.Add(i);
            }
            return rv.ToArray();
        }

        public static int HowManyLightsabersDoYouOwn(string name)
        {
            if (name == "Zach")
            {
                return 18;
            }
            else
            {
                return 0;
            }

        }


        public static string SwitchItUp(int number)
        {
            string rv = "";
            switch (number)
            {
                case 0: rv = "Zero"; break;
                case 1: rv = "One"; break;
                case 2: rv = "Two"; break;
                case 3: rv = "Three"; break;
                case 4: rv = "Four"; break;
                case 5: rv = "Five"; break;
                case 6: rv = "Six"; break;
                case 7: rv = "Seven"; break;
                case 8: rv = "Eight"; break;
                case 9: rv = "Nine"; break;
            }
            return rv;
        }

        public static string Covfefe(string tweet)
        {

            return tweet;

        }


        static void Main(string[] args)
        {

            //var input = Console.ReadLine().Split(' ').Select(s => long.Parse(s));
            //input.Reverse();
            //var min = input.Sum() - input.Max();
            //var max = input.Sum() - input.Min();
            //Console.WriteLine($"{min} {max}");

            //string s = Console.ReadLine();
            //int count = 1;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (char.IsUpper(s[i]))
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //string s = Console.ReadLine();
            //int count = 1;
            //var answer = s.Count(i => char.IsUpper(i));

            //var neya = int.Parse(Console.ReadLine());

            //var answer = (neya < 0) ? "negative" : "positibe";
            //Console.WriteLine(answer);

            //char ar = 'a';
            //var art = ar++;
            //Console.WriteLine(art++);
            //Console.WriteLine(art++);
            //Console.WriteLine(art++);
            //Console.WriteLine(art++);


            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //int k = Convert.ToInt32(Console.ReadLine());

            ////var answer = s.Select(o => o++).Where(w ;
            //var newAnswer = "";
            ////Console.WriteLine(newAnswer);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    newAnswer += i++;

            //}

            //Console.WriteLine(newAnswer);

            //var result = XO("xoxoxo");
            //Console.WriteLine(result);


            ////Code Kata TIY Fizz Buzz
            //var result = FizzBuzz("A");
            //Console.WriteLine(result);



            ////Hacker Rank Pangram
            //Console.WriteLine(Pangram("We promptly judged antique ivory buckles for the next prize"));

            //string hel = "two words";
            //Console.WriteLine(hel.Substring(0, 4) + hel.Substring(4, 1).ToUpper() + hel.Substring(4 + 1));

            //var rv = wave("two cord");
            //rv.ForEach(f => Console.WriteLine(f));


            //string qv = "lettha me testu thisu";
            //var i = qv.Split(' ').ToList();
            //var rv3 = new List<string>();

            //for (int z = 0; z < i.Count; z++)
            //{
            //    string rv = "";
            //    i[z].Substring(1, i[z].Length - 2).Reverse().ToList().ForEach(x => rv += x.ToString());
            //    string rv2 = i[z].Substring(0, 1) + rv + i[z].Substring(i[z].Length - 1);
            //    rv3.Add(rv2);
            //}
            //string rv4 = String.Join(" ", rv3);

            //Console.WriteLine(rv4);

            //string trydis = "inner";
            //var lmao = "";
            //trydis.ToList().OrderByDescending(o => o).ToList().ForEach(x => lmao += x);
            //Console.WriteLine(lmao);



        }
    }
}
