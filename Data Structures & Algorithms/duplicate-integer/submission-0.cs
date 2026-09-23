public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        Dictionary<int,int> hash = new();

        foreach(int i in nums){
            if (hash.ContainsKey(i))
                return true;
            else
                hash[i] = 0;
        }

        return false;
    }
}