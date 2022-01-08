public class Solution {
    public int CherryPickup(int[][] grid) {
        int m=grid.Length,n=grid[0].Length;
        var dict=new Dictionary<(int,int,int),int>();
        return dp(0,0,n-1,grid,dict);
    }
    
    public int dp(int r,int c1,int c2,int[][] grid,Dictionary<(int,int,int),int> dict)
    {
        if(r<0||r>=grid.Length||c1<0||c1>=grid[0].Length||c2<0||c2>=grid[0].Length) 
            return 0;
        if(dict.ContainsKey((r,c1,c2)))return dict[(r,c1,c2)];
        int ret=0;
        ret+=grid[r][c1];
        if(c1!=c2)
        {
            ret+=grid[r][c2];
        }
        if(r<grid.Length-1)
        {
            int max=0;
            for(int nc1=c1-1;nc1<=c1+1;nc1++)
            {
                for(int nc2=c2-1;nc2<=c2+1;nc2++)
                {
                    max=Math.Max(max,dp(r+1,nc1,nc2,grid,dict));
                }
            }
            ret+=max;
        }
        return dict[(r,c1,c2)]=ret;
    }
}