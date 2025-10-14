using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class RemoveDuplicatesIIClass
    {
        public int RemoveDuplicates(int[] nums)
        {
            int count = 2;
            bool repetition = false;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    repetition = false;
                    nums[count] = nums[i];
                    count++;
                }
                else if (nums[i - 1] == nums[i] && !repetition)
                {
                    repetition = true;
                    nums[count] = nums[i];
                    count++;
                }
            }
            Console.WriteLine(count);

            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
            return count;
        }

        //public int RemoveDuplicates(int[] nums)
        //{
        //    int count = 0;
        //    bool repetition = false;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        var prevVal = nums[0];
        //        var currentVal = nums[i];
        //        if (i == 0)
        //        {
        //            count++;
        //        }
        //        else
        //        {
        //            prevVal = nums[i - 1];
        //            if (i < 2)
        //            {
        //                count++;
        //                continue;
        //            }

        //            if (i >= 2)
        //            {
        //                var twoBehind = nums[i - 2];
        //                if (((prevVal == currentVal && twoBehind == currentVal) || repetition))
        //                {
        //                    if (i == nums.Length - 1 && nums[i-1] == -1)
        //                    {
        //                        nums[count] = currentVal;
        //                        count++;
        //                    }
        //                    repetition = false; 
        //                    continue;
        //                }
        //                else
        //                {   
        //                    nums[i] = -1;
        //                    nums[count] = currentVal;
        //                    count++;
        //                }

        //                

        //                if (nums[i-2] == currentVal && nums[i - 2] == nums[i - 1] && nums[i] == -1)
        //                {
        //                    repetition = true;
        //                }
        //                else
        //                {
        //                    repetition = false;
        //                }
        //            }
        //        }
        //    }
        //    Console.WriteLine(count);

        //    foreach (var item in nums)
        //    {
        //        Console.Write(item + ", ");
        //    }
        //    return count;
        //}

        public void Run()
        {
            //int[] nums = [0, 0, 1, 1, 1, 1, 2, 3, 3];
            //int[] nums = [1, 1, 1, 2, 2, 3];
            //int[] nums = [1, 2];
            //int[] nums = [1, 1, 1, 2, 2, 2, 3, 3];
            //int[] nums = [1, 1, 1];
            //int[] nums = [1, 1, 2];
            int[] nums = [0, 0, 0, 0, 0, 1, 2, 2, 3, 3, 4, 4];
            //int[] nums = [0, 0, 0, 1, 1, 2, 3, 4, 4];
            RemoveDuplicates(nums);
        }
    }
}
