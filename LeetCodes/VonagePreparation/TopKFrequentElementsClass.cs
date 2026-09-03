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
        //Totalnie zje**** zadanie po raz 10 zapomniałem o co chodzi
        // najczęściej występujące elementy,czyli jak mam k == 2 to ma zwrócić 2 NAJCZĘŚCIEJ występujące cyfry, nie muszą się powtarzać k razy!

        ////Totalnie nieefektywne, jeszcze bardziej a nawet najbardziej! Niesamowite, nie umiem tego napisać lepiej! Super!
        public int[] TopKFrequent(int[] nums, int k)
        {
            var tempDict = new Dictionary<int, int>();
            var retDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!tempDict.TryAdd(nums[i], 0))
                {
                    tempDict[nums[i]]++;
                }
                if (!retDict.TryAdd(nums[i], tempDict[nums[i]]))
                {
                    retDict[nums[i]] = tempDict[nums[i]];
                }

                if (retDict.Count > k)
                {
                    var minKey = retDict.MinBy(x => x.Value).Key;
                    retDict.Remove(minKey);
                }
            }

            return retDict.Keys.ToArray();
        }

        //Gorsze i próby poprawy??? Nie udane narazie
        //public int[] TopKFrequent(int[] nums, int k)
        //{
        //    var tempDict = new Dictionary<int, int>();
        //    var retDict = new Dictionary<int, int>();
        //    var currentlyAddedKey = 0;
        //    var currentlyAddedValue = 0;
        //    var smallestKey = int.MaxValue;
        //    var smallestValue = int.MaxValue;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (!tempDict.TryAdd(nums[i], 1))
        //        {
        //            tempDict[nums[i]]++;
        //            currentlyAddedKey = nums[i];
        //            currentlyAddedValue = tempDict[nums[i]];
        //            if (smallestValue >= currentlyAddedValue)
        //            {
        //                smallestKey = currentlyAddedKey;
        //                smallestValue = currentlyAddedValue;
        //            }
        //        }
        //        else
        //        {
        //            currentlyAddedKey = nums[i];
        //            currentlyAddedValue = tempDict[nums[i]];
        //            if (smallestValue >= currentlyAddedValue)
        //            {
        //                smallestKey = currentlyAddedKey;
        //                smallestValue = currentlyAddedValue;
        //            }
        //        }

        // if (!retDict.TryAdd(nums[i], tempDict[nums[i]])) { retDict[nums[i]] = tempDict[nums[i]]; }

        // if (currentlyAddedValue >= smallestValue && retDict.Count > k) {
        // retDict.Remove(smallestKey); smallestKey = currentlyAddedKey; smallestValue =
        // currentlyAddedValue; } }

        //    return retDict.Keys.ToArray();
        //}

        //Jeszcze gorsze ... WTF
        //public int[] TopKFrequent(int[] nums, int k)
        //{
        //    var tempDict = new Dictionary<int, int>();
        //    var retDict = new Dictionary<int, int>();

        // for (int i = 0; i < nums.Length; i++) { if (!tempDict.TryAdd(nums[i], 1)) {
        // tempDict[nums[i]]++; }

        // if (!retDict.TryAdd(nums[i], tempDict[nums[i]])) { retDict[nums[i]] = tempDict[nums[i]]; }

        // if (retDict.Count > k) { int smallestFlag = retDict[nums[i]]; int smallestKey = nums[i];
        // foreach (var retDictItem in retDict) { if (smallestFlag > retDictItem.Value) {
        // smallestFlag = retDictItem.Value; smallestKey = retDictItem.Key; } }
        // retDict.Remove(smallestKey); } }

        //    return retDict.Keys.ToArray();
        //}

        ////Totalnie nieefektywne, do poprawy ale nie miałem czasu. Robiłem to z 10 min? mniej?
        //public int[] TopKFrequent(int[] nums, int k)
        //{
        //    var retDict = new Dictionary<int, int>();

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (!retDict.TryAdd(nums[i], 0))
        //        {
        //            retDict[nums[i]]++;
        //        }
        //    }
        //    var sortedDict = retDict.OrderByDescending(x => x.Value).ToDictionary();
        //    return sortedDict.Keys.Take(k).ToArray();
        //}

        public void Run()
        {
            //var nums1 = new int[] { 3, 0, 1, 0 };
            //var nums2 = 1;

            //var nums1 = new int[] { 1, 1, 1, 2, 2, 3 };
            //var nums2 = 2;

            //var nums1 = new int[] { 1, 2, 1, 2, 1, 2, 3, 1, 3, 2 };
            //var nums2 = 2;

            //var nums1 = new int[] { 1 };
            //var nums2 = 1;

            //var nums1 = new int[] { 1, 2 };
            //var nums2 = 2;

            var nums1 = new int[] { 4, 1, -1, 2, -1, 2, 3 };
            var nums2 = 2;

            var result = TopKFrequent(nums1, nums2);
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}