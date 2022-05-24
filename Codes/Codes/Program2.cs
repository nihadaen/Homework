using System;
namespace Codes
{
    public class Program2
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 4, 5, 6, 7, 2, 5, 6 };
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        int tmp = 0;
                        if (arr[i] > arr[j])
                        {
                            tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
                    }
                }
            }
        }
    }

