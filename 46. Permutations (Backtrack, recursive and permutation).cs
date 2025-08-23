public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var response = new List<IList<int>>();
        Backtrack(response, new List<int>(), nums);
        return response;
    }

    public void Backtrack(IList<IList<int>> response, List<int> current, int[] nums){
        if(current.Count == nums.Length){
            response.Add(new List<int>(current));
            return;
        }
        for(int i = 0; i < nums.Length; i++){
            if(current.Contains(nums[i])) continue;
            current.Add(nums[i]);
            Backtrack(response, current, nums);
            current.RemoveAt(current.Count - 1);
        }
    }
}