using System;
using System.Collections.Generic;
using System.Text;

/*
 * https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
 You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.

Find and return the maximum profit you can achieve.

Input: prices = [7,1,5,3,6,4]
Output: 7

Input: prices = [1,2,3,4,5]
Output: 4

 */

namespace Array.Problems
{
    public static class BestTimeBuySellStock
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length <= 1)
                return 0;

            int maxProfit = 0;
            int currentBuy = -1;

            for (int i = 0, j = 1; j < prices.Length; i++, j++)
            {
                if (prices[i] < prices[j] && currentBuy < 0)
                {
                    currentBuy = prices[i];
                }
                else if (currentBuy >= 0 && currentBuy < prices[i] && prices[i] > prices[j])
                {
                    maxProfit += prices[i] - currentBuy;
                    currentBuy = -1;
                }
            }

            if (currentBuy >= 0)
                maxProfit += prices[prices.Length - 1] - currentBuy;

            return maxProfit;
        }

    }
}
