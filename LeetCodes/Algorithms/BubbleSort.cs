using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Algorithms
{
    public class BubbleSort
    {
        /*
        < - arr.Length - >
   /\   64, 34, 25, 12, 22, 11, 90 
        34, 64, 25, 12, 22, 11, 90
        34, 25, 64, 12, 22, 11, 90
        34, 25, 12, 64, 22, 11, 90
        34, 25, 12, 22, 64, 11, 90
        34, 25, 12, 22, 11, 64, 90
   \/   34, 25, 12, 22, 11, 64, 90

        25, 34, 12, 22, 11, 64, 90
        25, 12, 34, 22, 11, 64, 90
        25, 12, 22, 34, 11, 64, 90
        25, 12, 22, 11, 34, 64, 90

        12, 25, 22, 11, 34, 64, 90
        12, 22, 25, 11, 34, 64, 90
        12, 22, 11, 25, 34, 64, 90

        12, 22, 11, 25, 34, 64, 90
        12, 11, 22, 25, 34, 64, 90
        12, 11, 22, 25, 34, 64, 90

        11, 12, 22, 25, 34, 64, 90
         */

        //Złożoność czasowa najgorsza to O(n^2), średnia to O(n^2), a najlepsza to O(n)
        public static void BubbleSortAlgorithm(int[] arr)
        {
            var length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length -  i -  1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

        public void Run()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
            BubbleSortAlgorithm(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
    }
}
