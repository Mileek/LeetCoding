using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class LengthOfLongestSubstringClass
    {
        public int LengthOfLongestSubstring(string s)
        {
            string currentLongest = string.Empty;
            int unique = 0;
            int current = 0;
            foreach (char c in s)
            {
                if (!currentLongest.Contains(c))
                {
                    currentLongest += c;
                    current++;
                }
                else
                {
                    int start = currentLongest.IndexOf(c);

                    currentLongest += c;

                    currentLongest = currentLongest.Remove(0, start + 1);

                    current = currentLongest.Length;
                }

                if (unique < current)
                {
                    unique = current;
                }
            }
            return unique;
        }

        //Trochę wolniejsze o 1 ms :/
        //public int LengthOfLongestSubstring(string s)
        //{
        //    string currentLongest = string.Empty;
        //    int unique = 0;
        //    int current = 0;
        //    foreach (char c in s)
        //    {
        //        if (!currentLongest.Contains(c))
        //        {
        //            currentLongest += c;
        //            current++;
        //        }
        //        else
        //        {
        //            foreach (var newc in currentLongest)
        //            {
        //                if (newc != c)
        //                {
        //                    currentLongest = currentLongest.Replace(newc.ToString(), "");
        //                }
        //                else
        //                {
        //                    currentLongest = currentLongest.Replace(newc.ToString(), "");
        //                    currentLongest += c;
        //                    break;
        //                }
        //            }
        //            current = currentLongest.Length;
        //        }

        //        if (unique < current)
        //        {
        //            unique = current;
        //        }
        //    }
        //    return unique;
        //}

        public void Run()
        {
            var result = LengthOfLongestSubstring("anviaj");
            //anviaj

            Console.WriteLine($"{result}");
        }
    }
}