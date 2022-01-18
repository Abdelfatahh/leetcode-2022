
public class Solution {
    public bool WordPattern(string pattern, string s) {
            string[] arr = s.Split(' ');
            if (pattern.Length != arr.Length)
                return false;

            var dic = new Dictionary<char, string>();
            var dic2 = new Dictionary<string, char>();
            for (int i = 0; i < pattern.Length; i++)
            {
                if (dic.ContainsKey(pattern[i]))
                {
                    if (dic[pattern[i]] != arr[i])
                        return false;
                }
                else
                    dic.Add(pattern[i], arr[i]);

                if (dic2.ContainsKey(arr[i]))
                {
                    if (dic2[arr[i]] != pattern[i])
                        return false;
                }
                else
                    dic2.Add(arr[i], pattern[i]);
            }

            return true;
    }
}