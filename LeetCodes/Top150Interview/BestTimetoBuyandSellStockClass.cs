using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes.Top150Interview
{
    public class BestTimetoBuyandSellStockClass
    {
        public int MaxProfit(int[] prices)
        {
            var buyPrice = prices[0];
            var sellPrice = prices[0];
            int maxVal = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buyPrice)
                {
                    buyPrice = prices[i];
                    sellPrice = prices[i];
                }
                else if (prices[i] > sellPrice)
                {
                    sellPrice = prices[i];
                }

                if (sellPrice - buyPrice > maxVal)
                {
                    maxVal = sellPrice - buyPrice;
                }
            }

            Console.WriteLine(maxVal);
            return maxVal;
        }
        
        //Działa ale wolne w cholere
        //public int MaxProfit(int[] prices)
        //{
        //    var buyPrice = prices[0];
        //    var prevBuyPrice = prices[0];
        //    var sellPrice = prices[0];
        //    var prevSellPrice = prices[0];
        //    List<int> fin = new List<int>();

        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        if (prices[i] < buyPrice && i < prices.Length - 1)
        //        {
        //            prevBuyPrice = buyPrice;
        //            prevSellPrice = sellPrice;

        //            buyPrice = prices[i];
        //            sellPrice = prices[i];
        //        }
        //        else if (prices[i] > sellPrice)
        //        {
        //            sellPrice = prices[i];
        //        }

        //        //if (prevSellPrice - prevBuyPrice > sellPrice - buyPrice)
        //        //{
        //        //    sellPrice = prevSellPrice;
        //        //    buyPrice = prevBuyPrice;
                    
        //        //}
        //        fin.Add(sellPrice - buyPrice);
        //    }

        //    Console.WriteLine(fin.Max());
        //    return fin.Max();
        //}

        public void Run()
        {
            //int[] prices = [7, 1, 5, 3, 6, 4];
            //int[] prices = [1, 2];
            //int[] prices = [1];
            //int[] prices = [2, 4, 1];
            //int[] prices = [3, 2, 6, 5, 0, 3];
            //int[] prices = [2, 1, 2, 1, 0, 1, 2];
            //int[] prices = [3, 2, 6, 5, 0, 3];
            int[] prices = [4, 7, 2, 1];
            MaxProfit(prices);
        }
    }
}
