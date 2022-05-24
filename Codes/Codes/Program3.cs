using System;
namespace Codes
{
    public class Program3
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 4, 3, 2, 4, 5 };
            int[] arr2 = { 1, 4, 3 };
            isSubset(arr1, arr2);
        }
        public static bool isSubset(int[] arr1, int[] arr2)
        {

            int j = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                    if (arr2[i] == arr1[j])
                        break;
                if (j == arr1.Length)
                    return false;
            }

            return true;
        }
    }
}
