// brute force solution O(n^2)
public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        int counter=0;
        for(int i=0;i<time.Length;i++)
            for(int j=i+1;j<time.Length;j++)
                if((time[i]+time[j]) % 60 == 0)
                    counter++;
        return counter;
    }
}


// O(n) solution
public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        int[] mod = new int[60];
        int count = 0; 

        foreach(int t in time ){
            count += mod[(60-t % 60)%60];
            mod[t%60]++;
        }
        return count;
    }
}