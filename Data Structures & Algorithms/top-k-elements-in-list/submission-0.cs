public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int,int>();
        foreach(var num in nums){
            if (freq.ContainsKey(num)){
                freq[num] = freq[num] + 1;
            } else {
                freq.Add(num,1);
            }
        }
        List<int> res = freq.OrderByDescending(kvp=>kvp.Value).Select(kvp => kvp.Key).ToList();
        return res.Take(k).ToArray();
    }
}
