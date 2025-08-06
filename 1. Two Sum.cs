public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            int missingNumber = target - nums[i];
            if(map.ContainsKey(missingNumber)){
                return new int[]{map[missingNumber], i};
            }

            if(!map.ContainsKey(nums[i])){
                map[nums[i]] = i;
            }
        }
        return Array.Empty<int>();
    }
}