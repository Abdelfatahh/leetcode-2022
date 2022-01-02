public class Solution {
    public int MaxCoins(int[] onums)
    {
        int n = onums.Length;
        List<int> nums = new List<int>();
        nums.Add(1);
        nums.AddRange(onums);
        nums.Add(1);
        
        int[][] dp = new int[n + 2][];
        for (int i = 0; i < n + 2; i++)
            dp[i] = new int[n + 2];        
        
        for (int len = 1; len <= n; ++len)
        {
            for (int left = 1; left <= n - len + 1; ++left)
            {
                int right = left + len - 1;
                for (int k = left; k <= right; ++k)
                    dp[left][right] = Math.Max(dp[left][right], nums[left - 1] * nums[k] * nums[right + 1] + dp[left][k - 1] + dp[k + 1][right]);
            }            
        }
        
        return dp[1][n];
    }    
}