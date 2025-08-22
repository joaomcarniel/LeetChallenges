public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var response = new List<IList<int>>();
        Backtrack(response, new List<int>(), nums, 0);
        return response;
    }

    public void Backtrack(IList<IList<int>> response, IList<int> current,int[] nums, int cont){
        response.Add(new List<int>(current));

        for(int i = cont; i < nums.Length; i++){
            current.Add(nums[i]);
            Backtrack(response, current, nums, i+1);
            current.RemoveAt(current.Count - 1);
        }
    }
}