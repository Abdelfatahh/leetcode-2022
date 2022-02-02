public class Solution {
    public IList<int> FindAnagrams(string s, string p)
    {        
        var list = new List<int>();        
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p))
            return list;

        var hash = new int[256];
        foreach (char c in p)
            hash[c]++;
        
        int l = 0;
        int r = 0;
        int count = 0;
        while (r < s.Length)
        {           
            char rc = s[r];
            r++;
            if (hash[rc]-- > 0)
                count++;
            
            if (count == p.Length)
                list.Add(l);
            
            if (r - l == p.Length)
            {
                char lc = s[l];
                if (hash[lc]++ >= 0)
                    count--;                
                l++;
            }
        }
        
        return list;
        
    }
}