namespace DSAStriver._2._Arrays.LeetCodeProblems
{
    public class BestTimeToBuySellStock
    {
        #region O(n) Time Complexity
        //int[] prices = { 7, 1, 5, 3, 6, 4 };
        // int[] prices = { 7,6,4,3,1 }
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 1) return 0;
            int minPrice = int.MaxValue;    // Smallest Price
            int maxPrice = 0;               // Max Profit

            foreach (var price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price; // New cheaper Price
                }
                else
                {
                    int profit = price - minPrice;
                    if (profit > maxPrice)
                    {
                        maxPrice = profit;  // Update Max Profit
                    }
                }
            }
            return maxPrice;
        }
        #endregion
    }
}
