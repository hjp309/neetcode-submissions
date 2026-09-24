public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (nums.Length == 1)
            return new int[]{nums[0]};

        List<int> output = new();

        GetMostFrequent(output, nums, k);

        return output.ToArray();
    }

    public void GetMostFrequent(List<int> output, int[] n, int k){
        // Base Case
        if (k == 0)
            return; 

        // Body
        // Create frequency map of all values and find max.
        Dictionary<int, int> freq = new();
        int max = 0;
        int freqKey = n[0];
        for (int i = 0; i < n.Length; i++){
            if (!freq.ContainsKey(n[i])){
                freq[n[i]] = 1;
                continue;
            }
            freq[n[i]]++;
            if (freq[n[i]] > max){
                max = freq[n[i]];
                freqKey = n[i];
            }
        }

        // Find most frequent value and add it to output.
        output.Add(freqKey);
        List<int> removed = new(n);
        
        // Remove most frequent value
        removed.RemoveAll(x => x == freqKey);

        // Recursive Step        
        GetMostFrequent(output, removed.ToArray(), k - 1);
    }
}
