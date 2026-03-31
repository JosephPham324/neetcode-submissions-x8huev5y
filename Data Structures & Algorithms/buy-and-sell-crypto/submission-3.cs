public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length< 2)
{
	return 0;
}
       int l = 0;
int r = 1;
int currMax = prices[r] - prices[l];
while (r < prices.Length)
{
	if (prices[r] < prices[l])
	{//if right is less than left, update left
		l = r;
	}
	else
	{//if right is more than left, check max profit
		Console.WriteLine($"l: {l} r: {r}  = {prices[r] - prices[l]}");
		currMax = Math.Max(currMax, prices[r] - prices[l]);
	}
	r++;
}
return currMax < 0? 0:currMax;
    }
}
