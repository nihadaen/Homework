using System;
namespace Codes
{
    public class Program4
    {
        public static void binarySearch(int[] arr, int n)
        {
            int min = 0;
            int max = arr.Length- 1;
            int mid = (min + max) / 2;
            while (min <= max)
            {
                if (arr[mid] < n)
                {
                    min = mid + 1;
                }
                else if (arr[mid] == n)
                {
                    Console.WriteLine(mid);
                    break;
                }
                else
                {
                    max = mid - 1;
                }
                mid = (min + max) / 2;
            }
            if (min > max)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
