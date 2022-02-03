public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        int res = 0, n = nums1.Length;
        
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                int sum = nums1[i] + nums2[j];
                if(dic.ContainsKey(sum))
                    dic[sum]++;
                else
                    dic.Add(sum,1);
            }
        }
        
        for(int p = 0; p < n; p++)
        {
            for(int q = 0; q < n; q++)
            {
                int sum = nums3[p] + nums4[q];
                if(dic.ContainsKey(-sum))
                    res += dic[-sum];
            }
        }
        
        return res;
    }
}