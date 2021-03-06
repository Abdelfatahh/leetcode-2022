public class Solution {
    public bool ValidMountainArray(int[] A) {
        int i = 0;
        int n = A.Length;
        
        while(i+1<n && A[i]<A[i+1])
            i++;
        
        if(i==0||i==n-1)
            return false;
        
        while(i+1<n && A[i]>A[i+1])
            i++;
        
        return i == n-1;
    }


}