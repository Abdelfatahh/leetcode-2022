public class Solution {
    public IList<IList<string>> Partition(string s) 
    {
        var result = new List<IList<string>>();
        if(string.IsNullOrEmpty(s))
            return result;
        Helper(s, 0, result, new List<string>());
        return result;
    }
    
    private void Helper(string str, int start, List<IList<string>> result, IList<string> temp)
    {
        if(start == str.Length)
        {
            result.Add(new List<string>(temp));
            return;
        }
        
        for(int i=1; i+start<=str.Length; i++)
        {
            if(IsPalindrome(str.Substring(start, i)))
            {
                temp.Add(str.Substring(start,i));
                Helper(str, start+i, result, temp);
                temp.RemoveAt(temp.Count-1);
            }
        }
    }
    
    private bool IsPalindrome(string str)
    {
        if(string.IsNullOrEmpty(str))
            return true;
        var left = 0;
        var right = str.Length-1;
        while(left<=right)
        {
            if(str[left++] != str[right--])
                return false;
        }
        return true;
    }
}