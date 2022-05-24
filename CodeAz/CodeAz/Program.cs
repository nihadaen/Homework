using System;

namespace CodeAz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digitSum(20022));
            Console.WriteLine(indexFind(new int[]{11,45,12,45,12,65,654,133}, 654));
            Console.WriteLine(maxFind(new int[]{540,65,121}));
        }

        #region task1
        //1. Verilmiş ədədin rəqəmləri cəmini tapıb qaytaran  metod
        static int digitSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                num = (num - digit) / 10;
                sum += digit;
            }
            return sum;
        }
        #endregion

        #region task2

        //2. Verilmiş interger arrayində verilmiş integer ədədinin yerləşdiyi ilk
        //indexi tapıb qaytaran metod.Əgər tapmasa -1 qaytarsın.(Metodu işlətdikdə içinə
        //arqument olaraq bir integer array və bir ədəd göndərilir)
        static int indexFind(int[] nums, int num)
        {
            int index = -1;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        #endregion

        #region task3
        
        //3. Verilmiş 3 ədədən ən böyüyünü qaytaran metod

        static int maxFind(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }

            return max;
        }
        #endregion
    }
}