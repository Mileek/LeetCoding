using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class BestTimetoBuyandSellStockIIClass
    {
        public int MaxProfit(int[] prices)
        {
            var profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                var gain = prices[i] - prices[i - 1];
                if (gain > 0)
                {
                    profit += gain;
                }
            }

            return profit;
        }

        public void Run()
        {
            //int[] prices = [7, 1, 5, 3, 6, 4];
            int[] prices = [1, 2, 3, 4, 5];
            Console.WriteLine(MaxProfit(prices));
        }
    }
}