public class Solution {
    public List<int> res  = new List<int>();
    
    public List<int> SequentialDigits(int low, int high) {
        BackTrack(low, high, new StringBuilder(), 1, 0);
        res.Sort();
        return res;
    }
    
    public void BackTrack(int low, int high, StringBuilder sb, int start, int prev) {
        
        int num = string.IsNullOrEmpty(sb.ToString()) ? 0 : Convert.ToInt32(sb.ToString());
        
        if(num >= low && num <= high ) res.Add(num);
         
        if(num>high) return;
        
        for(int i = start; i<10; i++) {
            if(i - prev != 1) break;
            sb.Append(i);
            BackTrack(low, high, sb, i+1, i);
            sb.Remove(sb.Length - 1, 1);
            if(start==1) prev += 1;
        }
    }
}