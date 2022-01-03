public class Solution {
    public int FindJudge(int n, int[][] trust) {
        
        // handling special cases
        if(n == 1 & trust.Length == 0) 
            return 1;
        
        if(trust.Length <= 0) 
            return -1;
        
        if(trust.Length == 1) 
            return trust[0][1];
        
        Dictionary<int, List<int>> map = new Dictionary<int,List<int>>();
        
        // create the map
        foreach(var t in trust)
        {
            if (map.ContainsKey(t[0]))
            {
                map[t[0]].Add(t[1]);    
            } else {
                map.Add(t[0], new List<int>{t[1]});
            }
        }
        
        // since everybody trusts the town judge except for the town judge 
        if(map.Count != n-1)
            return -1;    
        
        int judge = 0;
        
        for(int i = 1; i <= n; i++) 
        {
            // getting the one who trusts nobody
            if(!map.ContainsKey(i)){
                judge = i;
            }
        }
        
        for(int i = 1; i <= n; i++) 
        {
            if(i==judge)
                continue;
            if(map[i].IndexOf(judge) == -1)
                return -1;
        }
    
        
        return judge;
    }
}