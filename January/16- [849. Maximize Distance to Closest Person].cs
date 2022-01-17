public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int seen = -1;
        int max = 0;
        
        for (int i = 0; i < seats.Length; i++){
            if (seats[i] == 1){
                if (seen != -1){
                    max = Math.Max(i - seen, max);
                }
                else{
                    max = (i * 2);
                }
                
                seen = i;
            }
        }
        
        if (seen != seats.Length - 1){
            max = Math.Max(((seats.Length - seen) * 2) - 1, max);
        }
        
        return max / 2;
    }
}