using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class RotateArrayClass
    {
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length == 1 || nums.Length == k || k == 0)
            {
                return;
            }

            if (nums.Length < k)
            {
                k = k % nums.Length;
            }

            var orgNums = new int[nums.Length];
            Array.Copy(nums, orgNums, nums.Length);

            int j = 0;
            for (int i = k - 1; i >= 0; i--)
            {
                nums[i] = nums[nums.Length - 1 - j];
                j++;
            }

            for (int i = k; i <= orgNums.Length - 1; i++)
            {
                nums[i] = orgNums[i - k];
            }
        }

        //Dobre szybkie i zaakceptowane, ale zdało by się poprawić pamięciowo
        //public void Rotate(int[] nums, int k)
        //{
        //    if (nums.Length == 1 || nums.Length == k || k == 0)
        //    {
        //        return;
        //    }

        //    if (nums.Length < k)
        //    {
        //        k = k % nums.Length;
        //    }

        //    var orgNums = new int[nums.Length];
        //    Array.Copy(nums, orgNums, nums.Length);

        //    int j = 0;
        //    for (int i = k - 1; i >= 0; i--)
        //    {
        //        nums[i] = nums[nums.Length - 1 - j];
        //        j++;
        //    }

        //    for (int i = k; i <= orgNums.Length - 1; i++)
        //    {
        //        nums[i] = orgNums[i - k];
        //    }
        //}

        //Dobre, InPlace, ale dalej za wolne, Hmm
        //public void Rotate(int[] nums, int k)
        //{
        //    for (int i = 0; i < k; i++)
        //    {
        //        var movedValue = 0;
        //        for (int j = nums.Length - 1; j >= 0; j--)
        //        {
        //            if (j == nums.Length - 1)
        //            {
        //                movedValue = nums[nums.Length - 1];
        //            }
        //            else if (j == 0)
        //            {
        //                nums[j + 1] = nums[j];
        //                nums[j] = movedValue;
        //            }
        //            else
        //            {
        //                nums[j+1] = nums[j];
        //            }
        //        }
        //    }

        //    foreach (int i in nums)
        //    {
        //        Console.Write(i + ", ");
        //    }
        //}

        //Działa, ale za wolne - proof of concept
        //public void Rotate(int[] nums, int k)
        //{
        //    for (int i = 0; i < k; i++)
        //    {
        //        var retvalArray = new int[nums.Length];
        //        for (int j = 0; j < nums.Length; j++)
        //        {
        //            if (j == 0)
        //            {
        //                retvalArray[j] = nums[nums.Length - 1];
        //            }
        //            else
        //            {
        //                retvalArray[j] = nums[j - 1];
        //            }
        //        }
        //        Array.Copy(retvalArray, nums, nums.Length);
        //    }

        //    foreach (int i in nums)
        //    {
        //        Console.Write(i + ", ");
        //    }
        //}

        public void Run()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            int k = 3;
            //int[] nums = [-1, -100, 3, 99];
            //int k = 2;
            //int[] nums = [1];
            //int k = 1;
            //int[] nums = [1, 2];
            //int k = 7;
            //int[] nums = [1, 2];
            //int k = 2;
            //int[] nums = [1, 2, 3];
            //int k = 2;
            //int[] nums = [1, 2, 3];
            //int k = 4;
            //int[] nums = [-1, -100, 3, 99];
            //int k = 3;
            Rotate(nums, k);
        }
    }
}
