public class Solution {
    public int MinJumps(int[] arr) {
        if(arr == null || arr.Length <= 1)
            return 0;
        
        Dictionary<int,List<int>> dic = new Dictionary<int,List<int>>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(!dic.ContainsKey(arr[i]))
                dic.Add(arr[i], new List<int>(){i});
            else
                dic[arr[i]].Add(i);
        }
        
        bool[] visited = new bool[arr.Length];
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);
        visited[0] = true;
        int res = 0;
        while(queue.Count > 0)
        {
            int size = queue.Count;
            for(int i = 0; i < size; i++)
            {
                int curr = queue.Dequeue();
                if(curr == arr.Length - 1)
                    return res;

                int left = curr - 1;
                int right = curr + 1;
                if(left >= 0 && !visited[left])
                {
                    queue.Enqueue(left);
                    visited[left] = true;
                }
                if(right < arr.Length && !visited[right])
                {
                    queue.Enqueue(right);
                    visited[right] = true;
                }
                foreach(int next in dic[arr[curr]])
                {
                    if(!visited[next])
                    {
                        queue.Enqueue(next);
                        visited[next] = true;
                    }
                }
                dic[arr[curr]].Clear(); // this is critical. Once the all cells with current value are visited, no need to checck again
            }         
            res++;
        }
        
        return -1;
    }
}