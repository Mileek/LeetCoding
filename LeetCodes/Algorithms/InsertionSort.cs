using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Algorithms
{
    public class InsertionSort
    {
        public static void InsertionSortAlgorithm(int[] arr)
        {
            var length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                int comparer = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > comparer)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = comparer;
            }
        }

        //Błędna logika, tzn działa ale to nie InsertionSort
        //public static void InsertionSortAlgorithm(int[] arr)
        //{
        //    var length = arr.Length;
        //    for (int i = 1; i < length; i++)
        //    {
        //        for (int j = i - 1; j > 0; j--) 
        //        {
        //            if (arr[j] < arr[j - 1])
        //            {
        //                (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
        //            }
        //        }
        //    }
        //}

        public void Run()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
            InsertionSortAlgorithm(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
    }
}
