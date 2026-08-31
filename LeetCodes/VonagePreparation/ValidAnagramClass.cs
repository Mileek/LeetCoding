using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.VonagePreparation
{
    public class ValidAnagramClass
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var dicts = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                dicts.TryAdd(s[i], 0);
                dicts[s[i]]++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dicts.TryAdd(t[i], 0))
                {
                    return false;
                }
                else
                {
                    dicts[t[i]]--;
                    if (dicts[t[i]] == 0)
                    {
                        dicts.Remove(t[i]);
                    }
                }
            }

            return dicts.Count == 0;
        }

        //public bool IsAnagram(string s, string t)
        //{
        //    if (s.Length != t.Length)
        //    {
        //        return false;
        //    }

        // var dicts = new Dictionary<char, int>(); var dictt = new Dictionary<char, int>(); for
        // (int i = 0; i < s.Length; i++) { dicts.TryAdd(s[i], 0); dicts[s[i]]++;

        // dictt.TryAdd(t[i], 0); dictt[t[i]]++; }

        // foreach (var item in dicts) { dictt.TryGetValue(item.Key, out int value); if (item.Value
        // != value) { return false; } }

        //    return true;
        //}

        public void Run()
        {
            var s = "anagram";
            var t = "nagaram";
            var result = IsAnagram(s, t);
            Console.WriteLine(result);
        }
    }
}