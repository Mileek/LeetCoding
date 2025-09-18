using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Algorithms
{
    public class SelectionSort
    {
        //Złożoność czasowa najgorsza to O(n^2), średnia to O(n^2), a najlepsza to O(n)
        public static void SelectionSortAlgorithm(int[] arr)
        {
            var length = arr.Length;
            int minimumValueIndex, currentValueIndex;
            for (int i = 0; i < length - 1; i++)
            {
                minimumValueIndex = i;
                for (int j = i; j < length; j++)
                {
                    currentValueIndex = j;
                    if (arr[currentValueIndex] < arr[minimumValueIndex])
                    {
                        minimumValueIndex = currentValueIndex;
                    }
                }

                (arr[i], arr[minimumValueIndex]) = (arr[minimumValueIndex], arr[i]);
            }
        }

        public void Run()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
            SelectionSortAlgorithm(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
    }
}
