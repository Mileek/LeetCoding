using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class GenerateParenthesesClass
    {
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            Backtrack(result, "", 0, 0, n);
            return result;
        }

        private void Backtrack(IList<string> result, string current, int open, int close, int max)
        {
            if (current.Length == max * 2)
            {
                result.Add(current);
                return;
            }
            if (open < max)
                Backtrack(result, current + "(", open + 1, close, max);
            if (close < open)
                Backtrack(result, current + ")", open, close + 1, max);
        }

        public void Run()
        {
            var result = GenerateParenthesis(6);
            foreach (var item in result)
            {
                Console.Write($"{item}");
                Console.WriteLine();
            }
        }
    }
}