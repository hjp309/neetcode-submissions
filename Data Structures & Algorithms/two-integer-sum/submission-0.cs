public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int, int> addend = new();

        for( int i = 0; i < nums.Length; i++){
            int second = target - nums[i];

            if (addend.ContainsKey(second))
                return new int[] { addend[second], i};
            else
                addend[nums[i]] = i;
        }

        return null;

    }
}
