public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        var dict = new SortedDictionary<int, int>();
        foreach(var trip in trips)
        {
            if(!dict.ContainsKey(trip[1])) dict[trip[1]] = 0;
            if(!dict.ContainsKey(trip[2])) dict[trip[2]] = 0;
            dict[trip[1]] += trip[0];
            dict[trip[2]] -= trip[0];
        }
        
        int count = 0;
        foreach(var kvp in dict)
        {
            count += kvp.Value;
            if(count > capacity) 
				return false;
        }
        
        return true;
	}
    }
}