public class Solution {
       public int[] TopKFrequent(int[] nums, int k) {
        // 1. Frequency map
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }

        // 2. Min-heap by frequency
        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

        foreach (var kvp in freq) {
            heap.Enqueue(kvp.Key, kvp.Value);

            if (heap.Count > k)
                heap.Dequeue(); // remove smallest frequency
        }

        // 3. Extract result
        int[] result = new int[k];
        for (int i = k - 1; i >= 0; i--) {
            result[i] = heap.Dequeue();
        }

        return result;
    }
}
