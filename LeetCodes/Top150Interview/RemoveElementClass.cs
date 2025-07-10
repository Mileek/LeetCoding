using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class RemoveElementClass
    {
        //poprawne - wolne O(n2)
        //public int RemoveElement(int[] nums, int val)
        //{
        //    int k = 0;
        //    int temp = 0;

        // for (int i = 0; i < nums.Length; i++) { k = 0;

        // for (int j = 0; j < nums.Length; j++) { if (nums[j] != val) { k++; } else if (j + 1 <
        // nums.Length - i) { temp = nums[j]; nums[j] = nums[j + 1]; nums[j + 1] = temp; } } }

        //    foreach (var item in nums)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine("[" + k + "]");
        //    return k;
        //}

        //Powalone, wsyatrczyła informacja że da się to zrobić w jednej pętli i zrobiłem to w 2 min, podobno nazywa się to "Two pointers"

        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("[" + k + "]");
            return k;
        }

        public void Run()
        {
            int[] nums = [3, 3, 2, 2, 3, 3];
            int val = 3;
            RemoveElement(nums, val);
        }
    }
}