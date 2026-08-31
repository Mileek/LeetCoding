using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.VonagePreparation
{
    public class IntersectionofTwoArraysClass
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> retval = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        retval.Add(nums1[i]);
                    }
                }
            }
            return retval.ToArray();
        }
        
        //public int[] Intersection(int[] nums1, int[] nums2)
        //{
        //    var test = nums1.Intersect(nums2).ToArray();
        //    return test;
        //}

        public void Run()
        {
            var nums1 = new int[] { 1, 2, 2, 1 };
            var nums2 = new int[] { 2, 2 };
            var result = Intersection(nums1, nums2);
            foreach (var x in result)
            {
                Console.WriteLine(x);

            }
        }
    }
}
