using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.VonagePreparation
{
    public class ContainsDuplicateClass
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hash.Add(nums[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void Run()
        {
            var result = ContainsDuplicate([1, 2, 3, 1]);
            Console.WriteLine(result);
        }
    }
}