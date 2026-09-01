using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.VonagePreparation
{
    public class TopKFrequentElementsClass
    {
        //Totalnie nieefektywne, do poprawy ale nie miałem czasu. Robiłem to z 10 min? mniej?
        public int[] TopKFrequent(int[] nums, int k)
        {
            var retDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!retDict.TryAdd(nums[i], 0))
                {
                    retDict[nums[i]]++;
                }
            }
            var sortedDict = retDict.OrderByDescending(x => x.Value).ToDictionary();
            return sortedDict.Keys.Take(k).ToArray();
        }

        public void Run()
        {
            var nums1 = new int[] { 3, 0, 1, 0 };
            var nums2 = 1;
            var result = TopKFrequent(nums1, nums2);
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}