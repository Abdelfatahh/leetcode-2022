public class Solution {
    public int SetAllBitsToRightOfHighest(int num){
        num |= num >> 1;
        num |= num >> 2;  
        num |= num >> 4; 
        num |= num >> 8;
        num |= num >> 16;
        return num;
    }
    
    public int FindMaximumXOR(int[] nums) {
        
        Array.Sort(nums, (a, b) => b - a);
        
        int answer = 0;
        for(int i = 0; i < nums.Length; i++){
            if(answer >= SetAllBitsToRightOfHighest(nums[i])) break;
            for(int j = i + 1; j < nums.Length; j++){
                int test = nums[i] ^ nums[j];
                if(test > answer) answer = test;
            }
        }
        
        return answer;
    } 
}