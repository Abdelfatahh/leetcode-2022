public class Solution {
    public bool WinnerSquareGame(int n) {
        bool[] dp = new bool[n + 1];
        dp[0] = false;
        
        for (int i = 1; i <= n; i++) 
        {
            int j = 1;
            while (j * j <= i) 
            {
                if (!dp[i - j * j]) 
                {
                    dp[i] = true;
                    break;
                }
                j++;
            }
        }
        
        return dp[n];
    }
}