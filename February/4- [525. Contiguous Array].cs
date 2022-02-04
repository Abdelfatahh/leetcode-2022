public class Solution {
    public int FindMaxLength(int[] nums) {
        int maxLength = 0;
        // Key is count and value is index;
        var countMap = new Dictionary<int,int>();
		int count = 0;
		
		// we have not started looping so index is -1 and count is zero
        countMap.Add(count,-1);
        
        for(int i = 0; i < nums.Length; i++)
        {
            count += nums[i] == 0? -1 : 1;
            
            if(countMap.ContainsKey(count))
            {
                maxLength = Math.Max(maxLength, i - countMap[count]);
            }
            else
            {
                countMap.Add(count, i);
            }
        }
        
        return maxLength;
    }
}