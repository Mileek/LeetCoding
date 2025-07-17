using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class RemoveDuplicatesClass
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            int prevVal = -101;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != prevVal)
                {
                    nums[k] = nums[i];
                    k++;
                }
                prevVal = nums[i];
            }

            return k;
        }

        public void Run()
        {
            int[] nums = [1, 1, 2];
            RemoveDuplicates(nums);
        }
    }
}