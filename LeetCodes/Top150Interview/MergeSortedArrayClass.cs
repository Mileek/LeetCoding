using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class MergeSortedArrayClass
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums2.Length > 0)
            {
                int j = 0;
                int k = 0;
                int[] copy1 = (int[])nums1.Clone();
                for (int i = 0; i < n + m; i++)
                {
                    if (k >= n || ((copy1[j] < nums2[k]) && j < m))
                    {
                        nums1[i] = copy1[j];
                        j++;
                    }
                    else
                    {
                        nums1[i] = nums2[k];
                        k++;
                    }
                }
            }
            //for (int i = 0; i < nums1.Length; i++)
            //{
            //    Console.Write(nums1[i] + " ");
            //}
        }

        public void Run()
        {
            //int[] nums1 = [1, 2, 3, 0, 0, 0];
            //int m = 3;
            //int[] nums2 = [2, 5, 6];
            //int n = 3;
            //Merge(nums1, m, nums2, n);

            int[] nums1 = [2, 0];
            int m = 1;
            int[] nums2 = [1];
            int n = 1;
            Merge(nums1, m, nums2, n);

            //int[] nums1 = [1];
            //int m = 1;
            //int[] nums2 = [];
            //int n = 0;
            //Merge(nums1, m, nums2, n);
        }
    }
}