public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        if(accounts == null || accounts.Length == 0)
            return 0;
        
        int max = 0;
        int sum= 0;
        for(int i = 0; i < accounts.Length; i++ ) {
            for(int j = 0; j < accounts[0].Length; j++) {
                sum += accounts[i][j];
            }
            if(sum > max)
                max = sum;
            sum = 0;
        }
        return max;
    }
}