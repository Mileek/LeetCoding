using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class MajorityElementClass
    {
        //O(n)
        public int MajorityElement(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out int value))
                {
                    dict[nums[i]] = value + 1;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }
            Console.WriteLine(dict.MaxBy(x => x.Value).Key);
            return dict.MaxBy(x => x.Value).Key;
        }
        
        //O(n log n)
        //public int MajorityElement(int[] nums)
        //{
        //    if (nums.Length == 1)
        //    {
        //        return nums[0];
        //    }

        //    nums = nums.OrderBy(x => x).ToArray();
        //    int count = 0;
        //    int newCount = 1;
        //    int retval = 0;
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        if (count > (nums.Length / 2))
        //        {
        //            break;
        //        }

        //        if (nums[i] == nums[i - 1])
        //        {
        //            newCount++;
        //        }
        //        else
        //        {
        //            newCount = 1;
        //        }

        //        if (newCount > count)
        //        {
        //            retval = nums[i];
        //            count = newCount;
        //        }
        //    }
        //    return retval;
        //}

        public void Run()
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2, 3, 3, 3];
            MajorityElement(nums);
        }
    }
}
