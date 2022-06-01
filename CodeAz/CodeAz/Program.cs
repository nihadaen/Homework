using System;
using System.IO;

namespace CodeAz
{
    class Program
    {
        static void Main(string[] args)
        {
            #region practice

            string str = "abca";
            string newStr = "abca";
            Console.WriteLine(str.Clone());
            Console.WriteLine(str.CompareTo(newStr));
            Console.WriteLine(str.EndsWith("ca"));
            Console.WriteLine(str.IndexOf("b"));
            string str1 = "ABCD";
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str.ToUpper());
            string fruits = "alma,armud,banan,gilas,kivi";
            string[] arr = fruits.Split(",");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string example = "   sadf asads    ";
            Console.WriteLine(example.Trim());
            char ch = 'a';
            Console.WriteLine(Char.IsDigit(ch));
            Console.WriteLine(Char.IsLetter(ch));

            #endregion

            string abc = "Ab1";
            Console.WriteLine(check(abc));
            string newString = " Salam Aze Code";
            Console.WriteLine(firstWord(ref newString));
            int[] arrInts = { 1, 4, 5, 6, 4, 3, 4 };
            int num = 12;
            addArr(ref arrInts, num);
            foreach (var i in arrInts)
            {
                Console.WriteLine(i);
            }
        }

        static bool check(string str)
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsDigit(chars[i]))
                {
                    check1= true;
                }

                if (Char.IsLower(chars[i]))
                {
                    check2 = true;
                }

                if (Char.IsUpper(chars[i]))
                {
                    check3 = true;
                }
            }

            return (check1 && check2 && check3);
        }

        static string firstWord(ref string str)
        {
            string newStr = str.Trim();
            char[] chars = newStr.ToCharArray();
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    index = i;
                    Console.WriteLine(chars[i]);
                    break;
                }
            }

            return newStr.Substring(0, index);
        }

        static void addArr(ref int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;

        }
    }
}