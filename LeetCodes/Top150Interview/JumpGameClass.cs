using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class JumpGameClass
    {
        /*
         You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

Return true if you can reach the last index, or false otherwise.

Example 1:

Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
        Tak na przyszłość, zadanie jest Zje****, tak naprawdę zaczynam od indeksu 0, i muszę odnaleźć jakąkolwiek ścieżkę, więc w pierwszym przykładzie mogę skoczyć o 1, albo o 2, algorytm wybrał skok o 1, potem mogę skoczyć znowu o 1 albo o 2 albo o 3, i aby dojść do końca skaczę o 3 bo tak wybrał algorytm.
         */

        public bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                //Już jesteś na końcu
                return true;
            }

            if (nums[0] == 0)
            {
                return false;
            }

            return CanJump(nums, 0, nums[0] + 1, false);
        }

        public bool CanJump(int[] nums, int startIndex, int length, bool canJump)
        {
            for (int i = startIndex; i < length; i++)
            {
                if (canJump)
                {
                    return canJump;
                }

                if (i == nums.Length - 1 /*|| i + length == nums.Length - 1*/)
                {
                    return canJump = true;
                }
                else if (nums[startIndex] == 0)
                {
                    continue;
                }
                else
                {
                    int start = i + 1;
                    canJump = CanJump(nums, start, nums[start], canJump);
                }
            }
            return canJump;
        }

        //public bool CanJump(int[] nums, int step, ref bool reachedEnd, int startIndex = 0)
        //{
        //    //nums[ 2 3 2 5 1 3 2 4 6 2
        //    //index 0 1 2 3 4 5 6 7 8 9
        //    //step  <1;2> <1;3> <1;2> <1;5>...

        // //nums[ 1 2 3 //index 0 1 2 //step <1;1> <1;2> <1;3> var canJump = false; for (int i =
        // startIndex; i < nums.Length; i += step) { if (reachedEnd) { break; }

        //        if ((i + step > nums.Length) || //Jeśli jesteś poza zakresem, nie możesz skakać
        //            (nums[i] == 0 && i != nums.Length)// Jeśli nie jesteś na końcu, a twój wynik wynosi 0, nie możesz skakać
        //            )
        //        {
        //            canJump = false;
        //            break;
        //        }
        //        else if (i + step == nums.Length - 1)
        //        {
        //            return reachedEnd = true;
        //        }
        //        else if (step < nums[i]) // Sprawdź czy możesz skoczyć, skok musi być dalej niż maksymalna wartość obecnego nums
        //        {
        //            step += 1;
        //            canJump = CanJump(nums, step, ref reachedEnd, i);
        //        }
        //        else
        //        {
        //            step = 1;
        //            canJump = true;
        //        }
        //    }
        //    canJump = reachedEnd;
        //    return canJump;
        //}

        //public bool CanJump(int[] nums, int step, int startIndex = 0)
        //{
        //    var canJump = false;
        //    for (int i = startIndex; i < nums.Length; i += step)
        //    {
        //        if (i == nums.Length - 1// Czy znajdujesz się na końcu nums?
        //            || i + step == nums.Length) // Czy po wykonaniu obecnego kroku znajdziesz się na kończu nums?
        //        {
        //            return canJump = true;
        //        }
        //        else if (step == 0 || (nums[i] == 0 && i != nums.Length - 1)) // Czy krok wynosi 0? Wtedy nie pójdziesz już nigdzie do przodu!
        //        {
        //            canJump = false;
        //            break;
        //        }
        //        else if (i < nums.Length - 1 && nums[i] > 0 && i < step)
        //        {
        //            canJump = CanJump(nums, step, startIndex + 1);
        //        }
        //        else
        //        {
        //            step = nums[i];
        //        }
        //    }
        //    return canJump;
        //}

        public void Run()
        {
            int[] nums = [2, 3, 1, 1, 4]; //True
            //int[] nums = [3, 2, 1, 0, 4]; // False
            //int[] nums = [0, 1];
            //int[] nums = [1, 2];
            //int[] nums = [2, 0]; //true
            //int[] nums = [2, 0, 0]; // true
            //int[] nums = [1, 2, 3]; //True
            //int[] nums = [1, 0, 2]; //False
            //int[] nums = [2, 5, 0, 0]; //True
            //int[] nums = [3, 0, 8, 2, 0, 0, 1]; //True
            Console.WriteLine(CanJump(nums));
        }

        //public bool CanJump(int[] nums)
        //{
        //    if (nums.Length == 1)
        //    {
        //        //Już jesteś na końcu
        //        return true;
        //    }

        // if (nums[0] == 0 && nums.Length > 1) { return false; }

        // //if (nums[1] >= nums.Length - 1) //{ // return false; //}
        //    bool canJump = false;
        //    for (int i = 1; i < nums.Length;)
        //    {
        //        if (nums[i] <= nums.Length && nums[i] > 0)
        //        {
        //            i = i + nums[i];
        //            canJump = true;
        //        }
        //        else if (i == nums.Length - 1)
        //        {
        //            canJump = true;
        //            break;
        //        }
        //        else
        //        {
        //            canJump = false;
        //            break;
        //        }
        //    }
        //    return canJump;
        //}
    }
}