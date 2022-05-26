using System;

namespace CodeAz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,5,1,32,52,3223};
            addArray(ref nums, 56);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine("");
            string str = " Hikmet Abbasov ";
            deleteSpace(ref str);
            Console.WriteLine(str);
            int x = -12;
            positiveNum(ref x);
            Console.WriteLine(x);
            int[] numbers = new[] { 1, 3, 5, -1, -4, -52, 54, -2 };
            positiveArr(ref numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        #region Task1

        // 1. Parameter olaraq integer array variable-i ve bir integer value qebul eden ve
        // hemin integer value-nu integer array-e yeni element kimi elave eden metod.

        static void addArray(ref int[] arr, int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[newArr.Length - 1] = value;

            arr = newArr;
        } 
        
        #endregion

        #region Task2

        //2. Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri əvvəlində və
        //sonunda boşluqlar qalmayacaq hala gətirən metod.

        static void deleteSpace(ref string str)
        {
            char[] ch = str.ToCharArray();
            string newStr = "";
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    
                }
                else
                {
                    newStr += ch[i];
                }
            }

            str = newStr;
        }


        #endregion

        #region Task3

        //3. Qəbul etdiyi ədədi musbətə ceviren metod

        static void positiveNum(ref int num)
        {
            if (num < 0)
            {
                num *= -1;
            }
        }

        #endregion

        #region Task4
        
        //4. Qəbul etdiyi ədədlər siyahısının içərisindəki bütün ədədləri müsbət hala gətirən metod

        static void positiveArr(ref int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] *= -1;
                }
                
            }
        }
        #endregion
    }
}